// Licensed to the .NET Foundation under one or more agreements. The .NET Foundation licenses this
// file to you under the MIT license.
#nullable disable

using Medical.Areas.Identity.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Memory;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Medical.Areas.Identity.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly SignInManager<AccountUser> _signInManager;
        private readonly UserManager<AccountUser> _userManager;
        private readonly ILogger<LoginModel> _logger;
        private readonly IMemoryCache _memoryCache;

      //  private readonly DBContextService? dBContextService;//{ set; get; }

        public LoginModel(IMemoryCache cache,
         
            SignInManager<AccountUser> signInManager,
            UserManager<AccountUser> userManager,
            ILogger<LoginModel> logger)
        {
            _signInManager = signInManager;
            _logger = logger;
            _userManager = userManager;
            _memoryCache = cache;
         //   dBContextService = dBContext;
        }

        /// <summary>
        /// This API supports the ASP.NET Core Identity default UI infrastructure and is not
        /// intended to be used directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        /// This API supports the ASP.NET Core Identity default UI infrastructure and is not
        /// intended to be used directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        /// <summary>
        /// 此 API 支持 ASP.NET Core Identity 默认 UI 基础结构，不打算直接从您的代码中使用。此 API 可能会在未来的版本中更改或删除。
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        /// This API supports the ASP.NET Core Identity default UI infrastructure and is not
        /// intended to be used directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [TempData]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// This API supports the ASP.NET Core Identity default UI infrastructure and is not
        /// intended to be used directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            /// <summary>
            /// This API supports the ASP.NET Core Identity default UI infrastructure and is not
            /// intended to be used directly from your code. This API may change or be removed in
            /// future releases.
            /// </summary>
            [Required]
            //[EmailAddress]
            [DataType(DataType.Text)]
            public string UserName { get; set; }

            /// <summary>
            /// This API supports the ASP.NET Core Identity default UI infrastructure and is not
            /// intended to be used directly from your code. This API may change or be removed in
            /// future releases.
            /// </summary>
            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            /// <summary>
            /// This API supports the ASP.NET Core Identity default UI infrastructure and is not
            /// intended to be used directly from your code. This API may change or be removed in
            /// future releases.
            /// </summary>
            [Display(Name = "记住账号")]
            public bool RememberMe { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl ??= Url.Content("~/");

            //清除现有的外部 cookie 以确保干净的登录过程
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            // ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
            _logger.LogInformation($"登录页面：OnGetAsync-ReturnUrl:{ReturnUrl}");
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            // _logger.LogInformation($"点击登录按钮：OnPostAsync -returnUrl{returnUrl} ");
            returnUrl ??= Url.Content("~/");

            // ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            if (ModelState.IsValid)
            {
                //用户名与账号 都可以登录
                AccountUser mudCallCenter = Activator.CreateInstance<AccountUser>(); //= await _signInManager.CreateAsync(this, returnUrl);
                if (IsEmail(Input.UserName))
                {
                    mudCallCenter = await _userManager.FindByEmailAsync(Input.UserName);
                }
                else
                {
                    mudCallCenter = await _userManager.FindByNameAsync(Input.UserName);
                }

                if (mudCallCenter is null)
                {
                    ModelState.AddModelError(string.Empty, $"用户名或者邮箱不存在");
                    return Page();
                }
                // 这不会将登录失败计入帐户锁定要启用密码失败以触发帐户锁定，请设置 lockout On Failure: true
                var result = await _signInManager.PasswordSignInAsync(mudCallCenter, Input.Password, Input.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    _logger.LogInformation($"登录成功:{mudCallCenter.UserName}");

                    return LocalRedirect(returnUrl);
                }
                if (result.RequiresTwoFactor)
                {
                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                }
                if (result.IsLockedOut)
                {
                    _logger.LogWarning($":用户登录失败，帐户被锁定");
                    return RedirectToPage("./Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, $"登录失败，请检查用户名或者密码是否正确");
                    return Page();
                }
            }
            //如果我们走到这一步，有些事情失败了，重新显示表格
            return Page();
        }

        //public static bool IsEmail(string inputData)
        //{
        //    Regex RegEmail = new Regex("^[\\w-]+@[\\w-]+\\.(com|net|org|edu|mil|tv|biz|info)$");//w 英文字母或数字的字符串，和 [a-zA-Z0-9] 语法一样
        //    Match m = RegEmail.Match(inputData);
        //    return m.Success;
        //}

        private bool IsEmail(string inputData)
        {
            Regex RegEmail = new Regex("^[a-zA-Z0-9_-]+@[a-zA-Z0-9_-]+(\\.[a-zA-Z0-9_-]+)+$");//w 英文字母或数字的字符串，和 [a-zA-Z0-9] 语法一样
            Match m = RegEmail.Match(inputData);
            return m.Success;
        }

        //public async Task<IActionResult> Logout()
        //{
        //    var returnUrl = Url.Action("Index", "Home");
        //}

        //public bool IsMobelPhone()
        //{
        //    return  Regex.IsMatch
        //}
        // bool IsEmail(string email)
        //{
        //    return Regex.IsMatch(email, @"^[\w\.]?" );
        //}

        //public async Task GetCache()
        //{
        //    using (var context = )
        //}
    }
}
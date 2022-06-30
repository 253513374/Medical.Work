// Licensed to the .NET Foundation under one or more agreements. The .NET Foundation licenses this
// file to you under the MIT license.
#nullable disable

using Medical.Areas.Identity.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Medical.Areas.Identity.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<AccountUser> _signInManager;
        private readonly UserManager<AccountUser> _userManager;
        private readonly IUserStore<AccountUser> _userStore;
        private readonly IUserPhoneNumberStore<AccountUser> _userPhoneNumber;
        private readonly IUserEmailStore<AccountUser> _emailStore;
        private readonly ILogger<RegisterModel> _logger;
        private readonly EmailSender _emailSender;

        public RegisterModel(
            UserManager<AccountUser> userManager,
            IUserStore<AccountUser> userStore,
            SignInManager<AccountUser> signInManager,
            ILogger<RegisterModel> logger,
            EmailSender emailSender)
        {
            _userManager = userManager;
            _userStore = userStore;
            _emailStore = GetEmailStore();
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _userPhoneNumber = GetUserPhoneNumberStore();
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
        public string ReturnUrl { get; set; }

        /// <summary>
        /// This API supports the ASP.NET Core Identity default UI infrastructure and is not
        /// intended to be used directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        /// <summary>
        /// This API supports the ASP.NET Core Identity default UI infrastructure and is not
        /// intended to be used directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            [Required( ErrorMessage ="邮箱必须填写") ]
            [EmailAddress]
            [Display(Name = "邮箱")]
            public string Email { get; set; }

            [Required(ErrorMessage = "姓名必须填写")]
            [DataType(DataType.Text)]
            [Display(Name = "姓名")]
            public string UserName { get; set; }

            //[Required]
            //[DataType(DataType.Text)]
            //[Display(Name = "出生日期")]
            //public DateTime Birthday { get; set; }

            [Required(ErrorMessage = "手机号码必须填写")]
            [DataType(DataType.Text)]
            [Display(Name = "手机号码")]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// This API supports the ASP.NET Core Identity default UI infrastructure and is not
            /// intended to be used directly from your code. This API may change or be removed in
            /// future releases.
            /// </summary>
            [Required]
            [StringLength(100, ErrorMessage = "{0} 必须至少为 {2} 且最多为 {1} 个字符.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "密码")]
            public string Password { get; set; }

            /// <summary>
            /// This API supports the ASP.NET Core Identity default UI infrastructure and is not
            /// intended to be used directly from your code. This API may change or be removed in
            /// future releases.
            /// </summary>
            [DataType(DataType.Password)]
            [Display(Name = "确认密码")]
            [Compare("Password", ErrorMessage = "密码和确认密码不匹配.")]
            public string ConfirmPassword { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = CreateUser();

                await _userPhoneNumber.SetPhoneNumberAsync(user, Input.PhoneNumber, CancellationToken.None);
                await _userStore.SetUserNameAsync(user, Input.UserName, CancellationToken.None);
                await _emailStore.SetEmailAsync(user, Input.Email, CancellationToken.None);

                var result = await _userManager.CreateAsync(user, Input.Password);

                if (result.Succeeded)
                {
                    _logger.LogInformation("用户使用密码创建了一个新帐户.");
                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    if (error.Code is "DuplicateUserName") ModelState.AddModelError(error.Code, $"{Input.UserName}被占用,请更换用户名");
                    if (error.Code is "DuplicateEmail") ModelState.AddModelError(error.Code, $"{Input.Email}被占用,请更换邮箱");
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }

        private AccountUser CreateUser()
        {
            try
            {
                return Activator.CreateInstance<AccountUser>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(AccountUser)}'. " +
                    $"Ensure that '{nameof(AccountUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }

        private IUserEmailStore<AccountUser> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("默认 UI 需要具有电子邮件支持的用户存储.");
            }
            return (IUserEmailStore<AccountUser>)_userStore;
        }

        private IUserPhoneNumberStore<AccountUser> GetUserPhoneNumberStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("默认 UI 需要具有电子邮件支持的用户存储.");
            }
            return (IUserPhoneNumberStore<AccountUser>)_userStore;
        }
    }
}
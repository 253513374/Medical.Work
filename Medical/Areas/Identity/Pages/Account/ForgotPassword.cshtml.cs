// Licensed to the .NET Foundation under one or more agreements. The .NET Foundation licenses this
// file to you under the MIT license.
#nullable disable

using Medical.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Encodings.Web;

namespace Medical.Areas.Identity.Pages.Account
{
    public class ForgotPasswordModel : PageModel
    {
        private readonly UserManager<AccountUser> _userManager;
        private readonly EmailSender _emailSender;
        private readonly ILogger<ForgotPasswordModel> Logger;

        public ForgotPasswordModel(ILogger<ForgotPasswordModel> logger, UserManager<AccountUser> userManager, EmailSender emailSender)
        {
            _userManager = userManager;
            _emailSender = emailSender;
            Logger = logger;
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
        public class InputModel
        {
            /// <summary>
            /// This API supports the ASP.NET Core Identity default UI infrastructure and is not
            /// intended to be used directly from your code. This API may change or be removed in
            /// future releases.
            /// </summary>
            [Required]
            [EmailAddress]
            [Display(Name = "邮箱")]
            public string Email { get; set; }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(Input.Email);
                if (user == null || !(await _userManager.IsEmailConfirmedAsync(user)))
                {
                    // Don't reveal that the user does not exist or is not confirmed
                    Logger.LogWarning("密码找回失败，邮箱没有注册或者没有确认邮箱");
                    ModelState.AddModelError(string.Empty, $"邮件发送失败,邮箱没有注册或者不存在");
                    return Page(); //RedirectToPage("./ForgotPassword");
                }

                // For more information on how to enable account confirmation and password reset
                // please visit https://go.microsoft.com/fwlink/?LinkID=532713
                var code = await _userManager.GeneratePasswordResetTokenAsync(user);
                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                var callbackUrl = Url.Page(
                    "/Account/ResetPassword",
                    pageHandler: null,
                    values: new { area = "Identity", code },
                    protocol: Request.Scheme);

                //发送重置密码邮件
                await _emailSender.SendEmailAsync(user, HtmlEncoder.Default.Encode(callbackUrl));

                return RedirectToPage("./ForgotPasswordConfirmation", new { email = Input.Email, returnUrl = "" });
            }

            return Page();
        }
    }
}
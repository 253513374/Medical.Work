
using MailKit.Security;
using Microsoft.AspNetCore.Identity;
using MimeKit;
using System.Threading.Tasks;

namespace Medical.Work
{
    public class EmailSender
    {
        public async Task SendEmailAsync(IdentityUser user, string url)
        {
            // 设置邮件内容
            var mailmessage = new MimeMessage();

            mailmessage.From.Add(new MailboxAddress("系统超级管理员", "452845625@qq.com"));//添加发件人
            mailmessage.To.Add(new MailboxAddress(user.UserName, address: user.Email));//收件人
            mailmessage.Subject = "系统密码重置";

            //var plain = new TextPart("plain")
            //{
            //    Text = @"你好,忘记了您的密码？

            //    欢迎使用拍拍看密码找回功能。请点击以下连接重置你得密码"
            //};

            var html = new TextPart("html")
            {
                Text = string.Format(@"<p>欢迎使用密码找回功能。请点击以下连接重置你得密码</p><br/><a href=""{0}""> {0} </a><br/><p> 点击没有跳转连接，请复制连接到浏览器地址栏中打开 </p>", url)
            };

            var Multipart = new Multipart();
            Multipart.Add(html);
            mailmessage.Body = Multipart;

            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.Connect("smtp.qq.com", 465, SecureSocketOptions.SslOnConnect);

                client.AuthenticationMechanisms.Remove("XOAUTH2");
                // Note: only needed if the SMTP server requires authentication

                client.Authenticate("452845625@qq.com", "djiuebmaculmbgha");

                await client.SendAsync(mailmessage);

                client.Disconnect(true);
            }
        }
    }
}
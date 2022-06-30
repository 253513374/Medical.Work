using MailKit.Net.Smtp;
using MailKit.Security;
using Medical.Areas.Identity.Data;
using MimeKit;
using MimeKit.Utils;

namespace Medical
{
    public class EmailSender
    {
        public IWebHostEnvironment Environment { get; }
        private ILogger<EmailSender> Logger { set; get; }

        public EmailSender(IWebHostEnvironment environment, ILogger<EmailSender> logger)
        {
            Environment = environment;
            Logger = logger;
        }

        /// <summary>
        /// 密码找回或密码重置
        /// </summary>
        /// <param name="user"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public async Task SendEmailAsync(AccountUser user, string url)
        {
            // 设置邮件内容
            var mailmessage = new MimeMessage();
            mailmessage.From.Add(new MailboxAddress("账号密码找回服务中心", "qxs@315net.com"));//添加发件人
            mailmessage.To.Add(new MailboxAddress(user.UserName, address: user.Email));//收件人
            mailmessage.Subject = "密码重置";

            var builder = new BodyBuilder();

            var path = $"{Environment.WebRootPath}/image/wtlog2.png";
            var image = builder.LinkedResources.Add(path);
            image.ContentId = MimeUtils.GenerateMessageId();

            builder.HtmlBody = string.Format(@"<p>你好,{0} </p>
            <p>请在24小时内点击右侧连接重置你得密码，逾期链接将失效。 <a href=""{1}"" target=""_blank"">重置密码 </a></p>
            <p>如无法打开连接,请复制以下连接到浏览器地址栏中打开</p>
             <p>""{1}""</p>
            <center><img src=""cid:{2}""></center>", user.UserName, url, image.ContentId);

            mailmessage.Body = builder.ToMessageBody();

            var emailclient = GetSmtpClient();
            var result = await emailclient.SendAsync(mailmessage);

            Logger.LogInformation("重置密码邮件发送成功" + result + url);
            if (result == "")
            {
                emailclient.Disconnect(true);
            }
        }


        /// <summary>
        /// 激活注册账号
        /// </summary>
        /// <param name="user"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public async Task SendRegisterConfirmationEmailAsync(AccountUser user, string url)
        {
            // 设置邮件内容
            var mailmessage = new MimeMessage();
            mailmessage.From.Add(new MailboxAddress("系统注册服务中心", "qxs@315net.com"));//添加发件人
            mailmessage.To.Add(new MailboxAddress(user.UserName, address: user.Email));//收件人
            mailmessage.Subject = "账号激活";

            var builder = new BodyBuilder();

            var path = $"{Environment.WebRootPath}/image/wtlog2.png";
            var image = builder.LinkedResources.Add(path);
            image.ContentId = MimeUtils.GenerateMessageId();

            builder.HtmlBody = string.Format(@"<p >你好，{0} </p>
            <p>请在点击右侧链接激活你的账号 <a href=""{1}"" target=""_blank"">激活账号 </a></p>
            <p>如无法打开链接，请复制以下链接到浏览器打开</p>
            <p>""{1}""</p>
            <center><img src=""cid:{2}""></center>", user.UserName, url, image.ContentId);

            mailmessage.Body = builder.ToMessageBody();

            var emailclient = GetSmtpClient();
            var result = await emailclient.SendAsync(mailmessage);

            Logger.LogInformation("激活注册账号邮件发送成功" + result + url);

            if (result == "")
            {
                emailclient.Disconnect(true);
            }
        }

        private SmtpClient GetSmtpClient()
        {
            var smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.exmail.qq.com", 465, SecureSocketOptions.SslOnConnect);
            smtpClient.AuthenticationMechanisms.Remove("XOAUTH2");
            smtpClient.Authenticate("qxs@315net.com", "Ppk365315");

            return smtpClient;
        }
    }
}
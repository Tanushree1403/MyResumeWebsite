using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Configuration;
using System.Web.Helpers;
using System.Web.Mvc;

namespace MyResumeWebsite.Controllers
{
    public class SuggestionController : Controller
    {
        // GET: Suggestion
        [HttpGet]
        public ActionResult SuggestionMessage()
        {

            return View();
        }

        [HttpPost]
        //[Route(Name ="content")]
        public ActionResult PostSuggestionMessage(string content)
        {
            try
            {
                var fromEmailAddress = WebConfigurationManager.AppSettings["FromEmailAddress"].ToString();
                var fromEmailDisplayName = WebConfigurationManager.AppSettings["FromEmailDisplayName"].ToString();
                var fromEmailPassword = WebConfigurationManager.AppSettings["FromEmailPassword"].ToString();
                var smtpHost = WebConfigurationManager.AppSettings["SMTPHost"].ToString();
                var smtpPort = WebConfigurationManager.AppSettings["SMTPPort"].ToString();
                #region commented code
                //WebMail.SmtpServer = "gmail-smtp-in.l.google.com";//"54.221.207.100";
                //WebMail.SmtpPort = 993;//Convert.ToInt32(smtpPort); //25 or 587 or 2525 993
                //WebMail.UserName = "shreetanu979@gmail.com";
                //WebMail.Password = "SP23anita";

                //WebMail.Send(to: fromEmailAddress, subject: content, body:
                //    "I have a suggestion for you!", from: "shreetanu979@gmail.com");


                #endregion
                var smptClient = new SmtpClient("smtp.gmail.com", 587) //25 or 587 or 2525 993
                {
                    Credentials = new NetworkCredential("shreetanu979@gmail.com", "SP23anita"),
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network
                };
                smptClient.Send("shreetanu979@gmail.com", "shreetanu979@gmail.com", 
                    "You have a suggestion", content);
                return View();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return View();
                //throw (new Exception("Mail send failed "));
            }
        }
    }
}
using System;
using System.Windows.Forms;
using System.Net.Mail;

namespace PHPSRePS 
{

    public  class sentmail
    {

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
                client.Host =("smtp.gmail.com");
                client.UseDefaultCredentials = true; 
                client.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network; 
                client.Credentials = new System.Net.NetworkCredential("Yoho2333", "yoho114477");
                System.Net.Mail.MailMessage Message = new System.Net.Mail.MailMessage();
                Message.From = new System.Net.Mail.MailAddress("yoho2333@gmail.com");
                
                Message.To.Add("ethenchenglong@gmail.com");
                
                Message.Subject = "Report";
                Message.Body = "Report" ;
              //  Message.Attachments.Add( = "C:\report.scv";
                Message.SubjectEncoding = System.Text.Encoding.UTF8;
                Message.BodyEncoding = System.Text.Encoding.UTF8;
                Message.Priority = System.Net.Mail.MailPriority.High;
                Message.IsBodyHtml = true;
                client.Send(Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Net.Security;
using System.IO;
using System.Net.Mime;

namespace SmtpTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                MailMessage mailmessage = new MailMessage("", "", "this is a test", "yes!test!");
                //from email，to email
                mailmessage.Priority = MailPriority.Normal; 
                SmtpClient smtpClient = new SmtpClient("xx", 25); //smtp address and port number
                smtpClient.Credentials = new NetworkCredential("xx", "xx");//smtp id and password
                smtpClient.EnableSsl = true; //use ssl
                //add attach
                Attachment attachment =null;

                if(listBox1.Items.Count>0)
                {
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        string pathFileName = listBox1.Items[i].ToString();
                        string extName = Path.GetExtension(pathFileName).ToLower(); //Get the extension
                        if(extName==".rar"||extName==".zip") //.ra.zip
                        {
                            attachment = new Attachment(pathFileName,MediaTypeNames.Application.Zip);
                        }else
                        {
                            attachment = new Attachment(pathFileName,MediaTypeNames.Application.Octet);
                        }
                        //set MIME detail
                        ContentDisposition cd = attachment.ContentDisposition;
                        cd.CreationDate = File.GetCreationTime(pathFileName);//set creat time
                        cd.ModificationDate = File.GetLastWriteTime(pathFileName);//set moditify time
                        cd.ReadDate = File.GetLastAccessTime(pathFileName);//set assess time
                        mailmessage.Attachments.Add(attachment);//add to msg
                    }
                }

            smtpClient.Send(mailmessage);
            MessageBox.Show("send successful");
            }

            catch (SmtpException se)
            {
                MessageBox.Show(se.StatusCode.ToString());
            }
        }
    //add attach to listbox
    private void button2_Click(object sender, EventArgs e)
    {
        OpenFileDialog opd = new OpenFileDialog();
        opd.Multiselect = true;
        opd.CheckFileExists = true;
        opd.ValidateNames = true;
        opd.ShowDialog();

        if(opd.FileNames.Length>0)//write the select file to the list
        {
            listBox1.Items.AddRange(opd.FileNames);
        }
    }
}
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace TICARIOTOMASYON
{
    public partial class FRMMAIL : Form
    {
        public string maill;
        public FRMMAIL()
        {
            InitializeComponent();
           
        }

        public void FRM()
        {
            mailtxt.Text = maill;
        }
        private void FRMMAIL_Load(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential("MAİL", "ŞİFRE");//kendi mail ve şifreinizi yazıcaksınız
            smtpClient.Port = 587;
            smtpClient.Host="smtp.live.com";
            smtpClient.EnableSsl = true;
            mail.To.Add(mailtxt.Text);
            mail.From=new MailAddress("ishaktr1905@gmail.com");//yukardaki mail kısmı ile aynı olması lazım
            mail.Subject = konutxt.Text;
            mail.Body = iceriktxt.Text;
            smtpClient.Send(mail);
        }
    }
}

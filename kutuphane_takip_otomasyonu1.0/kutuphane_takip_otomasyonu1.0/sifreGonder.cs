using System;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ini;
using DevComponents.DotNetBar;
using System.IO;

namespace kutuphane_takip_otomasyonu1._0
{
    public partial class sifreGonder : Office2007Form
    {
        public sifreGonder()
        {
            InitializeComponent();
        }

        string master_ini_path = "C:\\kutuphane_takip_otomasyonu\\settings.ini";

        void getir()
        {
            IniFile ini2 = new IniFile(master_ini_path);
            label1.Text = ini2.IniReadValue("kullanıcı", "sifre");
        }

        private void sifreGonder_Load(object sender, EventArgs e)
        {
            getir();
        }

        private void btn_gonder_Click(object sender, EventArgs e)
        {
            string metin = Convert.ToString(textBox1.Text);
            int i = metin.IndexOf("@");
            if (i == -1)
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show("Lütfen mail formatına uygun bir mail adresi giriniz!!!", "Hata!!!");
            }
            else
            {
                try
                {
                    SmtpClient sc = new SmtpClient();
                    sc.Port = 587;
                    sc.Host = "smtp.gmail.com";
                    sc.EnableSsl = true;
                    sc.Credentials = new NetworkCredential("alansoftyazilim@gmail.com", "Valan1262");
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("alansoftyazilim@gmail.com", "Kütüphane Takip Otomasyonu1.0");
                    mail.To.Add(textBox1.Text);
                    mail.Subject = "Kütüphane Takip Otomasyonu1.0 ŞİFRE DEĞİŞİKLİĞİ";
                    mail.IsBodyHtml = true;
                    mail.Body = "Eski Şifreniz: " + label1.Text;
                    sc.Send(mail);
                    MessageBoxEx.EnableGlass = false;
                    MessageBoxEx.Show("Şifreniz Göderildi Mailinizi Kontrol ediniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                catch (Exception ex)
                {
                    MessageBoxEx.EnableGlass = false;
                    MessageBoxEx.Show(ex.Message, "HATA");
                }
            }
        }
    }
}

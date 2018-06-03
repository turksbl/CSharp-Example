using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Ini;
using System.IO;

namespace kutuphane_takip_otomasyonu1._0
{
    public partial class login : Office2007Form
    {
        public login()
        {
            InitializeComponent();
        }

        string master_ini_path = "C:\\kutuphane_takip_otomasyonu\\settings.ini";

        void klasor_olustur()
        {
            string klasorYeri = "C:\\";
            string klasorAdi = "kutuphane_takip_otomasyonu";
            string klasorOlustur = klasorYeri + @"\" + klasorAdi;
            Directory.CreateDirectory(klasorOlustur);         
            IniFile ini5 = new IniFile(master_ini_path);
            ini5.IniWriteValue("Kullanıcı", "sifre", "admin");
        }

        private void login_Load(object sender, EventArgs e)
        {
            IniFile ini2 = new IniFile(master_ini_path);
            label4.Text = ini2.IniReadValue("kullanıcı", "sifre");
            if (label4.Text == "")
            {
                klasor_olustur();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBoxEx.EnableGlass = false;
            MessageBoxEx.Show("Şifreniz program ilk kurulduğunda varsayılan olarak 'admin' dir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sifreDegisiklik unuttum = new sifreDegisiklik();
            unuttum.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sifreGonder gonder = new sifreGonder();
            gonder.ShowDialog();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            IniFile ini2 = new IniFile(master_ini_path);
            label3.Text = ini2.IniReadValue("kullanıcı", "sifre");
            if (textBoxX2.Text.ToLower() == label3.Text)
            {
                anaForm yeniform = new anaForm();
                yeniform.Show();
                this.Hide();
            }
            else
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show("şifreniz yanlış", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxX2.Focus();
            }

           
        }
    }
}

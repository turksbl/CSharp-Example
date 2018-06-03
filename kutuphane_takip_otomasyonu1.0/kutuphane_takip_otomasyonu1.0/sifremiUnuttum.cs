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
    public partial class sifreDegisiklik : Office2007Form
    {
        public sifreDegisiklik()
        {
            InitializeComponent();
        }

        string master_ini_path = "C:\\kutuphane_takip_otomasyonu\\settings.ini";

        void getir()
        {
            IniFile ini2 = new IniFile(master_ini_path);
            label4.Text = ini2.IniReadValue("kullanıcı", "sifre");
        }

        private void sifremiUnuttum_Load(object sender, EventArgs e)
        {
            getir();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (textBoxX1.Text == label4.Text)
            {
                if (textBoxX2.Text == textBoxX3.Text)
                {
                    IniFile ini5 = new IniFile(master_ini_path);
                    ini5.IniWriteValue("Kullanıcı", "sifre", textBoxX3.Text);
                    MessageBoxEx.EnableGlass = false;
                    MessageBoxEx.Show("Şifreniz başarılı bir şekilde değiştirildi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                }
                else
                {
                    MessageBoxEx.EnableGlass = false;
                    MessageBoxEx.Show("Yeni şifreniz birbiri ile uyuşmuyor", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
            }
            else
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show("Eski şifreniz yanlış", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

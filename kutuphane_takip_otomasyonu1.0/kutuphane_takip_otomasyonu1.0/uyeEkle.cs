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
using System.Data.OleDb;
using System.Data.SqlClient;

namespace kutuphane_takip_otomasyonu1._0
{
    public partial class uyeEkle : Office2007Form 
    {
        public uyeEkle()
        {
            InitializeComponent();
        }

        string connected = @"Server=localhost;Database=veritabani;User Id=sa;password=123";
        SqlConnection connect;

        private void btn_uye_kaydet_Click(object sender, EventArgs e)
        {
            if (masktxt_tcno.Text != "")
            {
                string sorgu = "insert into uye(tcNo,adi,soyadi,eposta,tel,adres) values(@tcNo,@adi,@soyadi,@eposta,@tel,@adres)";
                SqlConnection connect = new SqlConnection(connected);
                SqlCommand cmd = new SqlCommand(sorgu, connect);

                cmd.Parameters.Add(new SqlParameter("@tcNo", SqlDbType.Int));
                cmd.Parameters["@tcNo"].Value = masktxt_tcno.Text;

                cmd.Parameters.Add(new SqlParameter("@adi", SqlDbType.NVarChar));
                cmd.Parameters["@adi"].Value = txt_adi.Text;

                cmd.Parameters.Add(new SqlParameter("@soyadi", SqlDbType.NVarChar));
                cmd.Parameters["@soyadi"].Value = txt_soyadi.Text;

                cmd.Parameters.Add(new SqlParameter("@eposta", SqlDbType.NVarChar));
                cmd.Parameters["@eposta"].Value = txt_eposta.Text;

                cmd.Parameters.Add(new SqlParameter("@tel", SqlDbType.NVarChar));
                cmd.Parameters["@tel"].Value = masktxt_tel.Text;

                cmd.Parameters.Add(new SqlParameter("@adres", SqlDbType.NVarChar));
                cmd.Parameters["@adres"].Value = txt_adres.Text;

                connect.Open();
                if (denetim(masktxt_tcno.Text))
                {
                    lbl_mesaj.Text = ("Bu üye daha önce kayıtlı");
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    lbl_mesaj.Text = (txt_adi.Text + " " + txt_soyadi.Text + " adlı üye başarıyla eklendi.");
                }
                connect.Close();
                masktxt_tcno.Text = ""; txt_adi.Text = ""; txt_soyadi.Text = ""; txt_eposta.Text = "";
                masktxt_tel.Text = ""; txt_adres.Text = "";
            }
            else
            {
                errorProvider1.SetError(masktxt_tcno, "T.C. numarası girilmesi zorunlu!");
                errorProvider1.SetError(masktxt_tel, "Telefon numarası girilmesi zorunlu");
            }
        }

        public bool denetim(string tcno)
        {
            bool durum;
            string sorgu = "select * from uye where LOWER(tcNo)='" + tcno.ToLower() + "' ";
            connect = new SqlConnection(connected);
            SqlDataReader data;
            SqlCommand cmd = new SqlCommand(sorgu, connect);
            connect.Open();
            data = cmd.ExecuteReader();
            if (data.Read()) { durum = true; } else { durum = false; }
            connect.Close();
            return durum;
        }

        private void btn_uye_geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uyeEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaForm f1 = (anaForm)Application.OpenForms["anaForm"];
            f1.Uye_Listesi();
            f1.kitap_Listesi();
            f1.odunc_Listesi();
            f1.yazar_listesi();
            f1.ceza_Listesi();
            f1.temizle();
        }
    }
}

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
    public partial class kitapEkle : Office2007Form
    {
        public kitapEkle()
        {
            InitializeComponent();
        }
        string strBaglanti = @"Server=localhost;Database=veritabani;User Id=sa;password=123";
        SqlConnection baglanti;
       
        int yazarnumarası = anaForm.yazarNo;
        public bool Kontrol(string ad)
        {

            bool durum;
            string SQL = "select * from kitap where LOWER(kitapAdi)='" + ad.ToLower()+  "'";
            baglanti = new SqlConnection(strBaglanti);
            SqlDataReader veri;
            SqlCommand komut = new SqlCommand(SQL, baglanti);
            baglanti.Open();
            veri = komut.ExecuteReader();
            if (veri.Read()) { durum = true; } else { durum = false; }
            baglanti.Close();
            return durum;
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (txt_kitapadi.Text != "")
            {
                string SQL = "insert into kitap(yazarNo,kitapAdi,turAdi,sayfaSayisi,kitapOzeti,kitapUcreti,oduncDurumu) values(" + yazarnumarası + ",'" + txt_kitapadi.Text + "','" +cmb_turadi.Text + "','" + txt_sayfasayisi.Text + "','" + txt_kitapozeti.Text + "','" + txt_kitapucreti.Text + "','rafta')";

                baglanti = new SqlConnection(strBaglanti);
                SqlCommand komut = new SqlCommand(SQL, baglanti);
                baglanti.Open();
                if (Kontrol(txt_kitapadi.Text))
                {
                    lblMesaj.Text = "Bu kitap daha önce kayıtlı!";
                    lblMesaj.ForeColor = Color.White;
                }
                else
                {

                    komut.ExecuteNonQuery();
                
                    lblMesaj.ForeColor = Color.White;
                    lblMesaj.Text = txt_kitapadi.Text  + " adlı kitap başarıyla eklendi!";
                    txt_kitapadi.Text = ""; txt_kitapozeti.Text = "";
                }
                baglanti.Close();
            }
            else
            {
                errorProvider1.SetError(txt_kitapadi, "Lütfen kitap adını giriniz!");            
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();        
        }

        private void kitapEkle_FormClosed(object sender, FormClosedEventArgs e)
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

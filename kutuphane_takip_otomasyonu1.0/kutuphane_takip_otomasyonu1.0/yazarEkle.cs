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
    public partial class yazarEkle : Office2007Form
    {
        public yazarEkle()
        {
            InitializeComponent();
        }
        string strBaglanti = @"Server=localhost;Database=veritabani;User Id=sa;password=123";
        SqlConnection baglanti;
      
        private void yazarEkle_Load(object sender, EventArgs e)
        {
            date_dogumtarihi.CustomFormat = "MM/dd/yyyy";         
        }
        public bool Kontrol(string ad, string soyad)
        {
            bool durum;
            string SQL = "select * from yazar where LOWER(adi)='" + ad.ToLower() + "' and LOWER(soyadi)='" + soyad.ToLower() + "'";
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
            if (txt_yazaradi.Text != "" && txt_yazarsoyadi.Text != "")
            {
                string SQL = "insert into yazar(adi,soyadi,dogumTarihi,hayatOzeti) values('" + txt_yazaradi.Text + "','" + txt_yazarsoyadi.Text + "','" + date_dogumtarihi.Value + "','" + txt_hayatozeti.Text + "')";
                baglanti = new SqlConnection(strBaglanti);
                SqlCommand komut = new SqlCommand(SQL, baglanti);
                baglanti.Open();
                if (Kontrol(txt_yazaradi.Text, txt_yazarsoyadi.Text))
                {
                    lblMesaj.Text = "Bu yazar daha önce kayıtlı";
                    lblMesaj.ForeColor = Color.White;
                }
                else
                {
                    komut.ExecuteNonQuery();
                    lblMesaj.ForeColor = Color.White;
                    lblMesaj.Text = txt_yazaradi.Text + " "+txt_yazarsoyadi.Text + " kaydı başarıyla eklendi!";
                    txt_yazaradi.Text = ""; txt_yazarsoyadi.Text = ""; txt_hayatozeti.Text = "";
                }
                baglanti.Close();
            }
            else
            {
                errorProvider1.SetError(txt_yazaradi, "Lütfen yazar adını giriniz!");
                errorProvider1.SetError(txt_yazarsoyadi, "Lütfen yazar soyadını giriniz!");
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();           
        }

        private void yazarEkle_FormClosed(object sender, FormClosedEventArgs e)
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

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
    public partial class uyeGuncelle : Office2007Form
    {
        public uyeGuncelle()
        {
            InitializeComponent();
        }

        string connected = @"Server=localhost;Database=veritabani;User Id=sa;password=123";
        SqlConnection connect;

        int secilen_tcNo = anaForm.TcNo;

        private void uyeGuncelle_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(connected);
            SqlDataAdapter datalist; DataSet datas = new DataSet();
            string sorgu = "select * from uye where tcNo= " + secilen_tcNo;
            datalist = new SqlDataAdapter(sorgu, connect);
            datalist.Fill(datas);
            int kayitsayisi = datas.Tables[0].Rows.Count;
            if (kayitsayisi != 0)
            {
                masktxt_tcno.Text= datas.Tables[0].Rows[0]["tcNo"].ToString();
                txt_adi.Text = datas.Tables[0].Rows[0]["adi"].ToString();
                txt_soyadi.Text = datas.Tables[0].Rows[0]["soyadi"].ToString();
                txt_eposta.Text = datas.Tables[0].Rows[0]["eposta"].ToString();
                masktxt_tel.Text = datas.Tables[0].Rows[0]["tel"].ToString();
                txt_adres.Text = datas.Tables[0].Rows[0]["adres"].ToString();
            }
            else
            {
                MessageBoxEx.Show("Hata oluştu, üye seçerek geliniz");
            }
        }

        private void uyeGuncelle_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaForm f1 = (anaForm)Application.OpenForms["anaForm"];
            f1.Uye_Listesi();
            f1.kitap_Listesi();
            f1.odunc_Listesi();
            f1.yazar_listesi();
            f1.ceza_Listesi();
            f1.temizle();
        }

        private void btn_uye_guncelle_Click(object sender, EventArgs e)
        {
            if (masktxt_tcno.Text != "" && masktxt_tel.Text != "")
            {
                string sorgu = "update uye set tcNo='" + masktxt_tcno.Text + "', adi='" + txt_adi.Text + "',soyadi= '" + txt_soyadi.Text + "',eposta= '" + txt_eposta.Text + "',tel= '" + masktxt_tel.Text + "',adres= '" + txt_adres.Text + "' where tcNo=" + secilen_tcNo;
                connect = new SqlConnection(connected);
                SqlCommand cmd = new SqlCommand(sorgu, connect);
                connect.Open();
                cmd.ExecuteNonQuery();
                lbl_mesaj.Text = (txt_adi.Text + " " + txt_soyadi.Text + " adlı üye kaydı başarıyla güncellendi");
                connect.Close();
                txt_adi.Text = ""; txt_soyadi.Text = ""; txt_eposta.Text = "";
                masktxt_tel.Text = ""; txt_adres.Text = "";
            }
            else
            {
                errorProvider1.SetError(masktxt_tcno, "T.C. Kimlik Numarası Girilmesi Zorunlu");
                errorProvider1.SetError(masktxt_tel, "Telefon Numarası Girilmesi Zorunlu");
            }
        }

        private void btn_uye_geri_Click(object sender, EventArgs e)
        {
            this.Close();          
        }
    }
}

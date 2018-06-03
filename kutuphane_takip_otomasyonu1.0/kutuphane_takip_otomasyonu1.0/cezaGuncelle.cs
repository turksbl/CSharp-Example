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
    public partial class cezaGuncelle : Office2007Form
    {
        public cezaGuncelle()
        {
            InitializeComponent();
        }

        string connected = @"Server=localhost;Database=veritabani;User Id=sa;password=123";
        SqlConnection connect;

        int secilen_cezano = anaForm.cezaNo;

        private void cezaGuncelle_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(connected);
            SqlDataAdapter datalist; DataSet datas = new DataSet();
            string sorgu = "SELECT ceza.cezaNo,kitap.kitapAdi,uye.tcNo,uye.adi,uye.soyadi,ceza.cezaUcreti,ceza.odemeDurumu FROM uye INNER JOIN ((ceza INNER JOIN kitap ON ceza.kitapNo = kitap.kitapNo) INNER JOIN odunc ON (kitap.kitapNo = odunc.kitapNo) AND (ceza.kitapNo = odunc.kitapNo)) ON uye.tcNo = odunc.tcNo where ceza.cezaNo =" + secilen_cezano + " ";
            datalist = new SqlDataAdapter(sorgu, connect);
            datalist.Fill(datas);
            int kayitsayisi = datas.Tables[0].Rows.Count;

            if (kayitsayisi != 0)
            {
                masktxt_tcno.Text = datas.Tables[0].Rows[0]["tcNo"].ToString();
                txt_adi.Text = datas.Tables[0].Rows[0]["adi"].ToString();
                txt_soyadi.Text = datas.Tables[0].Rows[0]["soyadi"].ToString();
                txt_kitapAdi.Text = datas.Tables[0].Rows[0]["kitapAdi"].ToString();
                txt_cezaUcreti.Text = datas.Tables[0].Rows[0]["cezaUcreti"].ToString();              
            }
            else
            {
                MessageBoxEx.Show("Hata oluştu!");
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (cmb_odemeDurumu.Text != "")
            {
                string sorgu = "update ceza set odemeDurumu='" + cmb_odemeDurumu.Text + "' where cezaNo=" + secilen_cezano;                            
                connect = new SqlConnection(connected);
                SqlCommand cmd = new SqlCommand(sorgu, connect);
                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();               
                lbl_mesaj.Text= (txt_adi.Text + " " + txt_soyadi.Text + " üyemize ait ödünç kaydı başarıyla güncellendi!");
                connect.Close();
            }
            else
            {
                errorProvider1.SetError(cmb_odemeDurumu, "Ödeme Durumu girilmesi zorunlu!");
            }
        }

        private void cezaGuncelle_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaForm f1 = (anaForm)Application.OpenForms["anaForm"];
            f1.Uye_Listesi();
            f1.kitap_Listesi();
            f1.odunc_Listesi();
            f1.yazar_listesi();
            f1.ceza_Listesi();
            f1.temizle();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

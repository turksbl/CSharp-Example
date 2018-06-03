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
    public partial class kitapGuncelle : Office2007Form
    {
        public kitapGuncelle()
        {
            InitializeComponent();
        }
        string connected = @"Server=localhost;Database=veritabani;User Id=sa;password=123";
        SqlConnection connect;

        int secilen_kitapno = anaForm.kitapno;

        private void kitapGuncelle_Load(object sender, EventArgs e)
        {

            connect = new SqlConnection(connected);
            SqlDataAdapter datalist; DataSet datas = new DataSet();
            string sorgu = "select kitap.kitapNo, yazar.adi,yazar.soyadi,kitap.kitapAdi,kitap.turAdi,kitap.sayfaSayisi,kitap.kitapOzeti,kitap.kitapUcreti,kitap.oduncDurumu from kitap inner join yazar on yazar.yazarNo=kitap.yazarNo where kitapNo =" + secilen_kitapno;
            datalist = new SqlDataAdapter(sorgu, connect);
            datalist.Fill(datas);
            int kayitsayisi = datas.Tables[0].Rows.Count;
            if (kayitsayisi != 0)
            {
                txt_kitapadi.Text = datas.Tables[0].Rows[0]["kitapAdi"].ToString();
                cmb_turadi.Text = datas.Tables[0].Rows[0]["turAdi"].ToString();
                txt_sayfasayisi.Text = datas.Tables[0].Rows[0]["sayfaSayisi"].ToString();
                txt_kitapucreti.Text = datas.Tables[0].Rows[0]["kitapUcreti"].ToString();
                txt_kitapozeti.Text = datas.Tables[0].Rows[0]["kitapOzeti"].ToString();
            }
            else
            {
                MessageBoxEx.Show("Hata oluştu!");
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (txt_kitapadi.Text != "")
            {
                string sorgu = "update kitap set kitapAdi='" + txt_kitapadi.Text + "', turAdi='" + cmb_turadi.Text + "',sayfaSayisi='" + txt_sayfasayisi.Text + "',kitapUcreti='" + txt_kitapucreti.Text + "',kitapOzeti='" + txt_kitapozeti.Text + "' where kitapNo=" + secilen_kitapno;

                connect = new SqlConnection(connected);
                SqlCommand cmd = new SqlCommand(sorgu, connect);
                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
                lblMesaj.Text= (txt_kitapadi.Text +  " adlı kitap  kaydı başarıyla güncellendi!");
                connect.Close();
            }
            else
            {
                errorProvider1.SetError(txt_kitapadi, "kitap adı girilmesi zorunlu!");
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();      
        }

        private void kitapGuncelle_FormClosed(object sender, FormClosedEventArgs e)
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

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
    public partial class yazarGuncelle : Office2007Form
    {
        public yazarGuncelle()
        {
            InitializeComponent();
        }
        string connected = @"Server=localhost;Database=veritabani;User Id=sa;password=123";
        SqlConnection connect;

        int yazarnumarasi = anaForm.yazarNo;

        private void yazarGuncelle_Load(object sender, EventArgs e)
        {                                
            connect = new SqlConnection(connected);
            SqlDataAdapter datalist; DataSet datas = new DataSet();
            string sorgu = "select * from yazar where yazarNo=" + yazarnumarasi + " ";
            datalist = new SqlDataAdapter(sorgu, connect);
            datalist.Fill(datas);
            int kayitsayisi = datas.Tables[0].Rows.Count;

            if (kayitsayisi != 0)
            {
                txt_yazaradi.Text = datas.Tables[0].Rows[0]["adi"].ToString();
                txt_yazarsoyadi.Text = datas.Tables[0].Rows[0]["soyadi"].ToString();
                date_dogumtarihi.Text = datas.Tables[0].Rows[0]["dogumTarihi"].ToString();
                txt_hayatozeti.Text = datas.Tables[0].Rows[0]["hayatOzeti"].ToString();              
            }
            else
            {
                lbl_mesaj.Text = ("Hata oluştu, yazar seçerek geliniz!");
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (txt_yazaradi.Text != "" && txt_yazarsoyadi.Text != "")
            {
                string sorgu = "update yazar set adi='" + txt_yazaradi.Text + "', soyadi='" + txt_yazarsoyadi.Text + "',dogumTarihi= '" + date_dogumtarihi.Text + "',hayatOzeti= '" + txt_hayatozeti.Text + "' where yazarNo=" + yazarnumarasi;
                connect = new SqlConnection(connected);
                SqlCommand cmd = new SqlCommand(sorgu, connect);
                connect.Open();
                cmd.ExecuteNonQuery();
                lbl_mesaj.Text = (txt_yazaradi.Text + " " + txt_yazarsoyadi.Text + " adlı yazar  başarıyla güncellendi");
                connect.Close();
                txt_yazaradi.Text = ""; txt_yazarsoyadi.Text = ""; date_dogumtarihi.Text = "";
                txt_hayatozeti.Text = "";
            }
            else
            {
                errorProvider1.SetError(txt_yazaradi, "Yazar Adı Girilmesi Zorunlu!");
                errorProvider1.SetError(txt_yazarsoyadi, "Yazar Soyadı Numarası Girilmesi Zorunlu!");
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();       
        }

        private void yazarGuncelle_FormClosed(object sender, FormClosedEventArgs e)
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

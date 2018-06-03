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
    public partial class oduncGuncelle : Office2007Form
    {
        public oduncGuncelle()
        {
            InitializeComponent();
        }    

        string connected = @"Server=localhost;Database=veritabani;User Id=sa;password=123";
        SqlConnection connect;

        public static int cezaucreti;
        string tc = anaForm.TcNo.ToString();
        string kitapadi = anaForm.kitapAdi.ToString();
        string uyead = anaForm.uyeadi.ToString();
        string uyesoyad = anaForm.uyesoyadi.ToString();
        string odunctarihi = anaForm.odunctarihi;
        int oduncnumarasi = anaForm.oduncNo;
        int kitapnumarasi = anaForm.kitapno;
        int kitapucret = anaForm.kitapucret;

        private void oduncGuncelle_Load(object sender, EventArgs e)
        {
            date_teslimtarihi.CustomFormat = "MM/dd/yyyy";
            date_odunctarihi.CustomFormat="MM/dd/yyyy";

            txt_tcno.Text = tc.ToString();
            txt_kitapAdi.Text = kitapadi.ToString();
            txt_ad.Text = uyead.ToString();
            txt_soyad.Text = uyesoyad.ToString();
            date_odunctarihi.Text = odunctarihi.ToString();
        }
     
        private void btn_oduncGuncelle_Click(object sender, EventArgs e)
        {        
            TimeSpan GunFarki = date_teslimtarihi.Value.Subtract(date_odunctarihi.Value);
            label7.Text = GunFarki.Days.ToString();
            int gun;
            gun = Convert.ToInt32(label7.Text.ToString());

            if (gun > 15 && cmb_hasardurumu.SelectedIndex == 0)
            {
                connect = new SqlConnection(connected);
                string sorgu = "update odunc set odunc.tcNo=@tcno, teslimTarihi=@teslim,hasarDurumu=@hasar  where oduncNo=@oduncnu";
                string sorgu2 = "update kitap set oduncDurumu='Rafta' where kitapNo=" + kitapnumarasi;
                SqlCommand cmd = new SqlCommand(sorgu, connect);
                cmd.Parameters.Add(new SqlParameter("@tcno", SqlDbType.BigInt));
                cmd.Parameters["@tcno"].Value = tc;
                cmd.Parameters.Add(new SqlParameter("@teslim", SqlDbType.Date));
                cmd.Parameters["@teslim"].Value = date_teslimtarihi.Text;
                cmd.Parameters.Add(new SqlParameter("@hasar", SqlDbType.NVarChar));
                cmd.Parameters["@hasar"].Value = cmb_hasardurumu.Text;
                cmd.Parameters.Add(new SqlParameter("@oduncnu", SqlDbType.Int));
                cmd.Parameters["@oduncnu"].Value = oduncnumarasi;
                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
                SqlCommand cmd2 = new SqlCommand(sorgu2, connect);
                connect.Open();
                cmd2.ExecuteNonQuery();
                MessageBoxEx.Show(txt_ad.Text + " " + txt_soyad.Text + " üyemize ait ödünç kaydı başarıyla güncellendi!");
                connect.Close();
                cezaucreti = kitapucret;
                string sorgu5 = "insert into ceza(tcNo,kitapNo,cezaUcreti) values(@tcno,@kitapNo,@cezaUcreti)";
                SqlCommand cmd3 = new SqlCommand(sorgu5, connect);
                cmd3.Parameters.Add(new SqlParameter("@tcno", SqlDbType.BigInt));
                cmd3.Parameters["@tcno"].Value = tc;
                cmd3.Parameters.Add(new SqlParameter("@kitapNo", SqlDbType.BigInt));
                cmd3.Parameters["@kitapNo"].Value = kitapnumarasi;
                cmd3.Parameters.Add(new SqlParameter("@cezaUcreti", SqlDbType.BigInt));
                cmd3.Parameters["@cezaUcreti"].Value = cezaucreti;
                connect.Open();
                MessageBoxEx.Show("Üyemiz Ceza almıştır ödünç tarihinden itibaren " + gun + " gün geçmiştir ve kitapta hasar meydana geldiği için üye ceza almıştır.");
                cmd3.ExecuteNonQuery();
                connect.Close();
            }
            else if (gun < 15 && cmb_hasardurumu.Text == "Yok")
            {
                connect = new SqlConnection(connected);
                string sorgu = "update odunc set odunc.tcNo=@tcno, teslimTarihi=@teslim,hasarDurumu=@hasar  where oduncNo=@oduncnu";
                string sorgu2 = "update kitap set oduncDurumu = 'Rafta' where kitapNo=" + kitapnumarasi;
                SqlCommand cmd = new SqlCommand(sorgu, connect);
                cmd.Parameters.Add(new SqlParameter("@tcno", SqlDbType.BigInt));
                cmd.Parameters["@tcno"].Value = tc;
                cmd.Parameters.Add(new SqlParameter("@teslim", SqlDbType.Date));
                cmd.Parameters["@teslim"].Value = date_teslimtarihi.Text;
                cmd.Parameters.Add(new SqlParameter("@hasar", SqlDbType.NVarChar));
                cmd.Parameters["@hasar"].Value = cmb_hasardurumu.Text;
                cmd.Parameters.Add(new SqlParameter("@oduncnu", SqlDbType.Int));
                cmd.Parameters["@oduncnu"].Value = oduncnumarasi;
                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
                SqlCommand cmd2 = new SqlCommand(sorgu2, connect);
                connect.Open();
                cmd2.ExecuteNonQuery();
                MessageBoxEx.Show(txt_ad.Text + " " + txt_soyad.Text + " üyemize ait ödünç kaydı başarıyla güncellendi!");
                connect.Close();
            }
            else if (gun > 15 && cmb_hasardurumu.Text == "Yok")
            {
                connect = new SqlConnection(connected);
                string sorgu = "update odunc set odunc.tcNo=@tcno, teslimTarihi=@teslim,hasarDurumu=@hasar  where oduncNo=@oduncnu";
                string sorgu2 = "update kitap set oduncDurumu='Rafta' where kitapNo=" + kitapnumarasi;
                SqlCommand cmd = new SqlCommand(sorgu, connect);
                cmd.Parameters.Add(new SqlParameter("@tcno", SqlDbType.BigInt));
                cmd.Parameters["@tcno"].Value = tc;
                cmd.Parameters.Add(new SqlParameter("@teslim", SqlDbType.Date));
                cmd.Parameters["@teslim"].Value = date_teslimtarihi.Text;
                cmd.Parameters.Add(new SqlParameter("@hasar", SqlDbType.NVarChar));
                cmd.Parameters["@hasar"].Value = cmb_hasardurumu.Text;
                cmd.Parameters.Add(new SqlParameter("@oduncnu", SqlDbType.Int));
                cmd.Parameters["@oduncnu"].Value = oduncnumarasi;
                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
                cezaucreti = (kitapucret * 10) / 100;
                string sorgu5 = "insert into ceza(tcNo,kitapNo,cezaUcreti) values(@tcno,@kitapNo,@cezaUcreti)";
                SqlCommand cmd3 = new SqlCommand(sorgu5, connect);
                cmd3.Parameters.Add(new SqlParameter("@tcno", SqlDbType.BigInt));
                cmd3.Parameters["@tcno"].Value = tc;
                cmd3.Parameters.Add(new SqlParameter("@kitapNo", SqlDbType.BigInt));
                cmd3.Parameters["@kitapNo"].Value = kitapnumarasi;
                cmd3.Parameters.Add(new SqlParameter("@cezaUcreti", SqlDbType.BigInt));
                cmd3.Parameters["@cezaUcreti"].Value = cezaucreti;
                connect.Open();
                MessageBoxEx.Show("Üyemiz Ceza almıştır ödünç tarihinden itibaren " + gun + " gün geçmiştir üye ceza almıştır.");
                cmd3.ExecuteNonQuery();
                connect.Close();
            }
            else if (gun < 15 && cmb_hasardurumu.SelectedIndex == 0) 
            {               
                connect = new SqlConnection(connected);
                string sorgu = "update odunc set odunc.tcNo=@tcno, teslimTarihi=@teslim,hasarDurumu=@hasar  where oduncNo=@oduncnu";
                string sorgu2 = "update kitap set oduncDurumu='Rafta' where kitapNo=" + kitapnumarasi;
                SqlCommand cmd6 = new SqlCommand(sorgu2, connect);
                SqlCommand cmd = new SqlCommand(sorgu, connect);
                cmd.Parameters.Add(new SqlParameter("@tcno", SqlDbType.BigInt));
                cmd.Parameters["@tcno"].Value = tc;
                cmd.Parameters.Add(new SqlParameter("@teslim", SqlDbType.Date));
                cmd.Parameters["@teslim"].Value = date_teslimtarihi.Text;
                cmd.Parameters.Add(new SqlParameter("@hasar", SqlDbType.NVarChar));
                cmd.Parameters["@hasar"].Value = cmb_hasardurumu.Text;
                cmd.Parameters.Add(new SqlParameter("@oduncnu", SqlDbType.Int));
                cmd.Parameters["@oduncnu"].Value = oduncnumarasi;
                connect.Open();
                cmd.ExecuteNonQuery();
                cmd6.ExecuteNonQuery();
                connect.Close();
                cezaucreti = (kitapucret * 50) / 100;
                string sorgu5 = "insert into ceza(tcNo,kitapNo,cezaUcreti) values(@tcno,@kitapNo,@cezaUcreti)";
                SqlCommand cmd3 = new SqlCommand(sorgu5, connect);
                cmd3.Parameters.Add(new SqlParameter("@tcno", SqlDbType.BigInt));
                cmd3.Parameters["@tcno"].Value = tc;
                cmd3.Parameters.Add(new SqlParameter("@kitapNo", SqlDbType.BigInt));
                cmd3.Parameters["@kitapNo"].Value = kitapnumarasi;
                cmd3.Parameters.Add(new SqlParameter("@cezaUcreti", SqlDbType.BigInt));
                cmd3.Parameters["@cezaUcreti"].Value = cezaucreti;
                connect.Open();
                MessageBoxEx.Show ("Kitapta hasar olduğundan dolayı üyemiz Ceza almıştır!");
                cmd3.ExecuteNonQuery();
                connect.Close();
            }           
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();          
        }

        private void oduncGuncelle_FormClosed(object sender, FormClosedEventArgs e)
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

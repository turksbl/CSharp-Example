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
    public partial class oduncEkle : Office2007Form
    {
        public oduncEkle()
        {
            InitializeComponent();
        }

        string connected = @"Server=localhost;Database=veritabani;User Id=sa;password=123";
        SqlConnection connect;

        public static int kitapno;
        string tc = anaForm.TcNo.ToString();

        public void odunc_Listesi()
        {
            connect = new SqlConnection(connected);
            string sorgu = "SELECT uye.adi,uye.soyadi,kitap.kitapNo,kitap.kitapAdi,kitap.turAdi,kitap.sayfaSayisi,kitap.kitapOzeti,kitap.kitapUcreti,kitap.oduncDurumu FROM(kitap INNER JOIN odunc ON kitap.kitapNo = odunc.kitapNo) INNER JOIN uye ON odunc.tcNo = uye.tcNo where kitap.oduncDurumu ='üyede' and uye.tcNo="+tc.ToString();
            SqlDataAdapter veriler = new SqlDataAdapter(sorgu, connect);
            DataSet datas = new DataSet();
            ListViewItem item = new ListViewItem();
            string[] str = new string[9];
            connect.Open();
            veriler.Fill(datas);

            if (datas.Tables[0].Rows.Count != 0)
            {
                list_oduncAlinanKitaplar.Clear();        
                list_oduncAlinanKitaplar.Columns.Add("Kitap No", 0, HorizontalAlignment.Center);
                list_oduncAlinanKitaplar.Columns.Add("Üye Adı", 50, HorizontalAlignment.Center);
                list_oduncAlinanKitaplar.Columns.Add("Üye Soyadı",50, HorizontalAlignment.Center);
                list_oduncAlinanKitaplar.Columns.Add("Kitap Adı", 100, HorizontalAlignment.Center);
                list_oduncAlinanKitaplar.Columns.Add("Tür Adı", 100, HorizontalAlignment.Center);
                list_oduncAlinanKitaplar.Columns.Add("Sayfa Sayısı", 50, HorizontalAlignment.Center);
                list_oduncAlinanKitaplar.Columns.Add("Kitap Özeti", 200, HorizontalAlignment.Center);
                list_oduncAlinanKitaplar.Columns.Add("Kitap Ücreti", 50, HorizontalAlignment.Center);
                list_oduncAlinanKitaplar.Columns.Add("Ödünç Durumu", 100, HorizontalAlignment.Center);

                for (int i = 0; i < datas.Tables[0].Rows.Count; i++)
                {
                    str[0] = datas.Tables[0].Rows[i]["kitapNo"].ToString();
                    str[1] = datas.Tables[0].Rows[i]["adi"].ToString();
                    str[2] = datas.Tables[0].Rows[i]["soyadi"].ToString();
                    str[3] = datas.Tables[0].Rows[i]["kitapAdi"].ToString();                 
                    str[4] = datas.Tables[0].Rows[i]["turAdi"].ToString();
                    str[5] = datas.Tables[0].Rows[i]["sayfaSayisi"].ToString();
                    str[6] = datas.Tables[0].Rows[i]["kitapOzeti"].ToString();
                    str[7] = datas.Tables[0].Rows[i]["kitapUcreti"].ToString();
                    str[8] = datas.Tables[0].Rows[i]["oduncDurumu"].ToString();
                    item = new ListViewItem(str);
                    list_oduncAlinanKitaplar.Items.Add(item);
                }
            }
            connect.Close();
        }

        public void kitap_Listesi()
        {
            connect = new SqlConnection(connected);
            string sorgu = "select kitap.kitapNo, yazar.adi,yazar.soyadi,kitap.kitapAdi,kitap.turAdi,kitap.sayfaSayisi,kitap.kitapOzeti,kitap.kitapUcreti,kitap.oduncDurumu from kitap inner join yazar on yazar.yazarNo=kitap.yazarNo where LoWER(kitap.oduncDurumu) ='rafta'";
            SqlDataAdapter veriler = new SqlDataAdapter(sorgu, connect);
            DataSet datas = new DataSet();
            ListViewItem item = new ListViewItem();
            string[] str = new string[9];
            connect.Open();
            veriler.Fill(datas);
            
            if (datas.Tables[0].Rows.Count != 0)
            {
              list_kitap_listesi.Clear();
              list_kitap_listesi.Columns.Add("Kitap No", 0, HorizontalAlignment.Center);
              list_kitap_listesi.Columns.Add("Yazar Adı", 100, HorizontalAlignment.Center);
              list_kitap_listesi.Columns.Add("Yazar Soyadı", 100, HorizontalAlignment.Center);
              list_kitap_listesi.Columns.Add("Kitap Adı", 120, HorizontalAlignment.Center);
              list_kitap_listesi.Columns.Add("Tür Adı", 100, HorizontalAlignment.Center);
              list_kitap_listesi.Columns.Add("Sayfa Sayısı", 50, HorizontalAlignment.Center);
              list_kitap_listesi.Columns.Add("Kitap Özeti", 200, HorizontalAlignment.Center);
              list_kitap_listesi.Columns.Add("Kitap Ücreti", 50, HorizontalAlignment.Center);
              list_kitap_listesi.Columns.Add("Ödünç Durumu", 50, HorizontalAlignment.Center);
               
                for (int i = 0; i < datas.Tables[0].Rows.Count; i++)
                {
                    str[0] = datas.Tables[0].Rows[i]["kitapNo"].ToString();
                    str[1] = datas.Tables[0].Rows[i]["adi"].ToString();
                    str[2] = datas.Tables[0].Rows[i]["soyadi"].ToString();
                    str[3] = datas.Tables[0].Rows[i]["kitapAdi"].ToString();
                    str[4] = datas.Tables[0].Rows[i]["turAdi"].ToString();
                    str[5] = datas.Tables[0].Rows[i]["sayfaSayisi"].ToString();
                    str[6] = datas.Tables[0].Rows[i]["kitapOzeti"].ToString();
                    str[7] = datas.Tables[0].Rows[i]["kitapUcreti"].ToString();
                    str[8] = datas.Tables[0].Rows[i]["oduncDurumu"].ToString();
                    item = new ListViewItem(str);
                    list_kitap_listesi.Items.Add(item);
                }
            }
            connect.Close();
        }

        private void oduncEkle_Load(object sender, EventArgs e)
        {
            date_odunctarihi.CustomFormat = "MM/dd/yyyy";
            date_sonteslim.CustomFormat = "MM/dd/yyyy";
            date_odunctarihi.Value = DateTime.Today;
            date_sonteslim.Value = DateTime.Now.AddDays(15);
            kitap_Listesi();
            odunc_Listesi();
            connect = new SqlConnection(connected);
            SqlDataAdapter verilistesi; DataSet veriler = new DataSet();
            string SQL = "select tcNo,adi,soyadi from uye where tcNo=" +tc+ "";
            verilistesi = new SqlDataAdapter(SQL, connect);
            verilistesi.Fill(veriler);
            int kayitsayisi = veriler.Tables[0].Rows.Count;
            if (kayitsayisi != 0)
            {
                txt_tcno.Text =veriler.Tables[0].Rows[0]["tcNo"].ToString();
                txt_ad.Text = veriler.Tables[0].Rows[0]["adi"].ToString();
                txt_soyad.Text = veriler.Tables[0].Rows[0]["soyadi"].ToString();
            }
            else
            {
               
            }
        }

        private void btn_oduncver_Click(object sender, EventArgs e)
        {
            kitapno = Convert.ToInt32(list_kitap_listesi.SelectedItems[0].SubItems[0].Text);
            string sorgu = "insert into odunc(kitapNo,tcNo,oduncTarihi,sonTeslimTarihi) values(@kitapno,@tcno,@odunctarihi,@sonteslim)";
            SqlConnection connect = new SqlConnection(connected);
            SqlCommand cmd = new SqlCommand(sorgu, connect);

            cmd.Parameters.Add(new SqlParameter("@kitapno", SqlDbType.BigInt));
            cmd.Parameters["@kitapno"].Value = kitapno.ToString();

            cmd.Parameters.Add(new SqlParameter("@tcno", SqlDbType.BigInt));
            cmd.Parameters["@tcno"].Value = txt_tcno.Text;

            cmd.Parameters.Add(new SqlParameter("@odunctarihi", SqlDbType.DateTime));
            cmd.Parameters["@odunctarihi"].Value = date_odunctarihi.Text;

            cmd.Parameters.Add(new SqlParameter("@sonteslim", SqlDbType.DateTime));
            cmd.Parameters["@sonteslim"].Value = date_sonteslim.Text;

            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
        }

        public static int odunc_kitapno;     
        private void list_oduncAlinanKitaplar_DoubleClick(object sender, EventArgs e)
        {
            MessageBoxEx.EnableGlass = false;
            DialogResult cev;
            cev = MessageBoxEx.Show("Bu Kitabı Üyeden Kaldırmak istediğinizden Emin Misiniz?", "Kitap Kaldırılıyor", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (cev == DialogResult.Yes)
            {
                string sorgu2 = "update kitap set oduncDurumu='rafta' where kitapNo=" + kitapno;
                SqlConnection connect2 = new SqlConnection(connected);
                SqlCommand cmd2 = new SqlCommand(sorgu2, connect2);

                odunc_kitapno = Convert.ToInt32(list_oduncAlinanKitaplar.SelectedItems[0].SubItems[0].Text);
                string sorgu = "delete from odunc where kitapNo=" + odunc_kitapno.ToString();
                connect = new SqlConnection(connected);
                SqlCommand cmd = new SqlCommand(sorgu, connect);

                connect.Open();
                connect2.Open();
                cmd2.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                connect.Close();
                connect2.Close();
                kitap_Listesi();
                odunc_Listesi();                     
            }
            else
            {

            }
        }

        private void txt_ara_TextChanged(object sender, EventArgs e)
        {
            if (txt_kitapara.Text.Trim() == "")
            {
                connect = new SqlConnection(connected);
                string sorgu = "select kitap.kitapNo, yazar.adi,yazar.soyadi,kitap.kitapAdi,kitap.turAdi,kitap.sayfaSayisi,kitap.kitapOzeti,kitap.kitapUcreti,kitap.oduncDurumu from kitap inner join yazar on yazar.yazarNo=kitap.yazarNo";
                SqlDataAdapter veriler = new SqlDataAdapter(sorgu, connect);
                DataSet datas = new DataSet();
                ListViewItem item = new ListViewItem();
                string[] str = new string[9];
                connect.Open();
                veriler.Fill(datas);

                if (datas.Tables[0].Rows.Count != 0)
                {
                    list_kitap_listesi.Clear();
                    list_kitap_listesi.Columns.Add("Kitap No", 0, HorizontalAlignment.Center);
                    list_kitap_listesi.Columns.Add("Yazar Adı", 200, HorizontalAlignment.Center);
                    list_kitap_listesi.Columns.Add("Yazar Soyadı", 200, HorizontalAlignment.Center);
                    list_kitap_listesi.Columns.Add("Kitap Adı", 200, HorizontalAlignment.Center);
                    list_kitap_listesi.Columns.Add("Tür Adı", 120, HorizontalAlignment.Center);
                    list_kitap_listesi.Columns.Add("Sayfa Sayısı", 120, HorizontalAlignment.Center);
                    list_kitap_listesi.Columns.Add("Kitap Özeti", 100, HorizontalAlignment.Center);
                    list_kitap_listesi.Columns.Add("Kitap Ücreti", 100, HorizontalAlignment.Center);
                    list_kitap_listesi.Columns.Add("Ödünç Durumu", 100, HorizontalAlignment.Center);

                    for (int i = 0; i < datas.Tables[0].Rows.Count; i++)
                    {
                        str[0] = datas.Tables[0].Rows[i]["kitapNo"].ToString();
                        str[1] = datas.Tables[0].Rows[i]["adi"].ToString();
                        str[2] = datas.Tables[0].Rows[i]["soyadi"].ToString();
                        str[3] = datas.Tables[0].Rows[i]["kitapAdi"].ToString();
                        str[4] = datas.Tables[0].Rows[i]["turAdi"].ToString();
                        str[5] = datas.Tables[0].Rows[i]["sayfaSayisi"].ToString();
                        str[6] = datas.Tables[0].Rows[i]["kitapOzeti"].ToString();
                        str[7] = datas.Tables[0].Rows[i]["kitapUcreti"].ToString();
                        str[8] = datas.Tables[0].Rows[i]["oduncDurumu"].ToString();
                        item = new ListViewItem(str);
                        list_kitap_listesi.Items.Add(item);
                    }
                }
                connect.Close();
            }
            else
            {
                if (cmb_kitapara.SelectedIndex == 1)
                {
                    connect = new SqlConnection(connected);
                    string sorgu = "select kitap.kitapNo, yazar.adi,yazar.soyadi,kitap.kitapAdi,kitap.turAdi,kitap.sayfaSayisi,kitap.kitapOzeti,kitap.kitapUcreti,kitap.oduncDurumu from kitap inner join yazar on yazar.yazarNo=kitap.yazarNo where kitap.kitapAdi like '%" + txt_kitapara.Text + "%'";
                    SqlDataAdapter veriler = new SqlDataAdapter(sorgu, connect);
                    DataSet datas = new DataSet();
                    ListViewItem item = new ListViewItem();
                    string[] str = new string[9];
                    connect.Open();
                    veriler.Fill(datas);

                    if (datas.Tables[0].Rows.Count != 0)
                    {
                        list_kitap_listesi.Clear();
                        list_kitap_listesi.Columns.Add("Kitap No", 0, HorizontalAlignment.Center);
                        list_kitap_listesi.Columns.Add("Yazar Adı", 200, HorizontalAlignment.Center);
                        list_kitap_listesi.Columns.Add("Yazar Soyadı", 200, HorizontalAlignment.Center);
                        list_kitap_listesi.Columns.Add("Kitap Adı", 200, HorizontalAlignment.Center);
                        list_kitap_listesi.Columns.Add("Tür Adı", 120, HorizontalAlignment.Center);
                        list_kitap_listesi.Columns.Add("Sayfa Sayısı", 120, HorizontalAlignment.Center);
                        list_kitap_listesi.Columns.Add("Kitap Özeti", 100, HorizontalAlignment.Center);
                        list_kitap_listesi.Columns.Add("Kitap Ücreti", 100, HorizontalAlignment.Center);
                        list_kitap_listesi.Columns.Add("Ödünç Durumu", 100, HorizontalAlignment.Center);

                        for (int i = 0; i < datas.Tables[0].Rows.Count; i++)
                        {
                            str[0] = datas.Tables[0].Rows[i]["kitapNo"].ToString();
                            str[1] = datas.Tables[0].Rows[i]["adi"].ToString();
                            str[2] = datas.Tables[0].Rows[i]["soyadi"].ToString();
                            str[3] = datas.Tables[0].Rows[i]["kitapAdi"].ToString();
                            str[4] = datas.Tables[0].Rows[i]["turAdi"].ToString();
                            str[5] = datas.Tables[0].Rows[i]["sayfaSayisi"].ToString();
                            str[6] = datas.Tables[0].Rows[i]["kitapOzeti"].ToString();
                            str[7] = datas.Tables[0].Rows[i]["kitapUcreti"].ToString();
                            str[8] = datas.Tables[0].Rows[i]["oduncDurumu"].ToString();
                            item = new ListViewItem(str);
                            list_kitap_listesi.Items.Add(item);
                        }
                    }
                    connect.Close();
                }
                else if (cmb_kitapara.SelectedIndex == 2)
                {
                    connect = new SqlConnection(connected);
                    string sorgu = "select kitap.kitapNo, yazar.adi,yazar.soyadi,kitap.kitapAdi,kitap.turAdi,kitap.sayfaSayisi,kitap.kitapOzeti,kitap.kitapUcreti,kitap.oduncDurumu from kitap inner join yazar on yazar.yazarNo=kitap.yazarNo where yazar.adi like '%" + txt_kitapara.Text + "%'";
                    SqlDataAdapter veriler = new SqlDataAdapter(sorgu, connect);
                    DataSet datas = new DataSet();
                    ListViewItem item = new ListViewItem();
                    string[] str = new string[9];
                    connect.Open();
                    veriler.Fill(datas);

                    if (datas.Tables[0].Rows.Count != 0)
                    {
                        list_kitap_listesi.Clear();
                        list_kitap_listesi.Columns.Add("Kitap No", 0, HorizontalAlignment.Center);
                        list_kitap_listesi.Columns.Add("Yazar Adı", 200, HorizontalAlignment.Center);
                        list_kitap_listesi.Columns.Add("Yazar Soyadı", 200, HorizontalAlignment.Center);
                        list_kitap_listesi.Columns.Add("Kitap Adı", 200, HorizontalAlignment.Center);
                        list_kitap_listesi.Columns.Add("Tür Adı", 120, HorizontalAlignment.Center);
                        list_kitap_listesi.Columns.Add("Sayfa Sayısı", 120, HorizontalAlignment.Center);
                        list_kitap_listesi.Columns.Add("Kitap Özeti", 100, HorizontalAlignment.Center);
                        list_kitap_listesi.Columns.Add("Kitap Ücreti", 100, HorizontalAlignment.Center);
                        list_kitap_listesi.Columns.Add("Ödünç Durumu", 100, HorizontalAlignment.Center);

                        for (int i = 0; i < datas.Tables[0].Rows.Count; i++)
                        {
                            str[0] = datas.Tables[0].Rows[i]["kitapNo"].ToString();
                            str[1] = datas.Tables[0].Rows[i]["adi"].ToString();
                            str[2] = datas.Tables[0].Rows[i]["soyadi"].ToString();
                            str[3] = datas.Tables[0].Rows[i]["kitapAdi"].ToString();
                            str[4] = datas.Tables[0].Rows[i]["turAdi"].ToString();
                            str[5] = datas.Tables[0].Rows[i]["sayfaSayisi"].ToString();
                            str[6] = datas.Tables[0].Rows[i]["kitapOzeti"].ToString();
                            str[7] = datas.Tables[0].Rows[i]["kitapUcreti"].ToString();
                            str[8] = datas.Tables[0].Rows[i]["oduncDurumu"].ToString();
                            item = new ListViewItem(str);
                            list_kitap_listesi.Items.Add(item);
                        }
                    }
                    connect.Close();
                }
                else
                {
                    MessageBoxEx.EnableGlass = false;
                    MessageBoxEx.Show("Lütfen arama yapılacak bir kriter seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void oduncEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaForm f1 = (anaForm)Application.OpenForms["anaForm"];
            f1.Uye_Listesi();
            f1.kitap_Listesi();
            f1.odunc_Listesi();
            f1.yazar_listesi();
            f1.ceza_Listesi();
            f1.temizle();
        }

        private void list_kitap_listesi_DoubleClick(object sender, EventArgs e)
        {
            string kitapadi, oduncdurumu;
            kitapadi = list_kitap_listesi.SelectedItems[0].SubItems[3].Text;
            oduncdurumu = list_kitap_listesi.SelectedItems[0].SubItems[8].Text;
            kitapno = Convert.ToInt32(list_kitap_listesi.SelectedItems[0].SubItems[0].Text);

            string sorgu2 = "update kitap set oduncDurumu='üyede' where kitapNo=" + kitapno;
            SqlConnection connect2 = new SqlConnection(connected);
            SqlCommand cmd2 = new SqlCommand(sorgu2, connect2);

            string sorgu = "insert into odunc(kitapNo,tcNo,oduncTarihi,sonTeslimTarihi) values(@kitapno,@tcno,@odunctarihi,@sonteslim)";
            SqlConnection connect = new SqlConnection(connected);
            SqlCommand cmd = new SqlCommand(sorgu, connect);

            cmd.Parameters.Add(new SqlParameter("@kitapno", SqlDbType.BigInt));
            cmd.Parameters["@kitapno"].Value = kitapno.ToString();

            cmd.Parameters.Add(new SqlParameter("@tcno", SqlDbType.BigInt));
            cmd.Parameters["@tcno"].Value = txt_tcno.Text;

            cmd.Parameters.Add(new SqlParameter("@odunctarihi", SqlDbType.DateTime));
            cmd.Parameters["@odunctarihi"].Value = date_odunctarihi.Text;

            cmd.Parameters.Add(new SqlParameter("@sonteslim", SqlDbType.DateTime));
            cmd.Parameters["@sonteslim"].Value = date_sonteslim.Text;

            connect2.Open();
            connect.Open();

            if ((oduncdurumu.ToString() == "üyede"))
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show("Bu kitap daha önce eklendi!", "DİKKAT", MessageBoxButtons.OK);
            }
            else
            {
                cmd2.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show(kitapadi + " kitabı " + txt_ad.Text + " " + txt_soyad.Text + " adlı üyemize başarıyla eklendi!", "ÖDÜNÇ", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            odunc_Listesi();
            kitap_Listesi();
            connect.Close();
        }
    }
}

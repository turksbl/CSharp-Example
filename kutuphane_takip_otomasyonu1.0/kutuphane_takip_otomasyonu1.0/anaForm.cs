using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using DevComponents.DotNetBar;
using System.Data.Sql;
using System.Data.SqlClient;



namespace kutuphane_takip_otomasyonu1._0
{
    public partial class anaForm : Office2007Form
    {
        public anaForm()
        {
            InitializeComponent();
        }
        string connected = @"Server=localhost;Database=veritabani;User Id=sa;password=123";
        SqlConnection connect;
       
        public static int TcNo, yazarNo, oduncNo,kitapno,kitapucret,cezaNo;
        public static string kitapAdi, uyeadi, uyesoyadi,odunctarihi;

       public void temizle()
        {
            list_cezaliste.Clear();
            list_kitapliste.Clear();
            list_oduncliste.Clear();
            list_yazarliste.Clear();
            listuyeler.Clear();
            ceza_Listesi();
            Uye_Listesi();
            odunc_Listesi();
            kitap_Listesi();
            yazar_listesi();
        }
        private void btn_uye_ekle_Click(object sender, EventArgs e)
        {
            uyeEkle uyeekle = new uyeEkle();
            uyeekle.Show();           
        }

        private void anaForm_Load(object sender, EventArgs e)
        {
            cmb_ara.SelectedIndex = 0;
            cmb_cezaara.SelectedIndex = 0;
            cmb_kitapara.SelectedIndex = 0;
            cmb_oduncara.SelectedIndex = 0;
            cmb_yazarara.SelectedIndex = 0;
            Uye_Listesi();
            yazar_listesi();
            kitap_Listesi();
            odunc_Listesi();
            ceza_Listesi();
        }

        public void odunc_Listesi()
        {
            connect = new SqlConnection(connected);
            string sorgu = "SELECT kitap.kitapUcreti,odunc.hasarDurumu,uye.tcNo,odunc.oduncNo,odunc.oduncTarihi,odunc.sonTeslimTarihi,odunc.teslimtarihi,uye.adi,uye.soyadi,kitap.kitapNo,kitap.kitapAdi,kitap.turAdi,kitap.sayfaSayisi,kitap.kitapOzeti,kitap.kitapUcreti,kitap.oduncDurumu FROM(kitap INNER JOIN odunc ON kitap.kitapNo = odunc.kitapNo) INNER JOIN uye ON odunc.tcNo = uye.tcNo where kitap.oduncDurumu='üyede' and odunc.hasarDurumu IS NULL";
            SqlDataAdapter veriler = new SqlDataAdapter(sorgu, connect);
            DataSet datas = new DataSet();
            ListViewItem item = new ListViewItem();
            string[] str = new string[12];
            connect.Open();
            veriler.Fill(datas);

            if (datas.Tables[0].Rows.Count != 0)
            {
                list_oduncliste.Clear();       
                list_oduncliste.Columns.Add("Ödünç No", 0, HorizontalAlignment.Center);
                list_oduncliste.Columns.Add("Kitap No", 0, HorizontalAlignment.Center);               
                list_oduncliste.Columns.Add("Üye Adı", 50, HorizontalAlignment.Center);
                list_oduncliste.Columns.Add("Üye Soyadı", 50, HorizontalAlignment.Center);
                list_oduncliste.Columns.Add("Kitap Adı", 100, HorizontalAlignment.Center);
                list_oduncliste.Columns.Add("T.C No", 100, HorizontalAlignment.Center);           
                list_oduncliste.Columns.Add("Ödünç Tarihi", 100, HorizontalAlignment.Center);
                list_oduncliste.Columns.Add("Son Teslim Tarihi", 120, HorizontalAlignment.Center);
                list_oduncliste.Columns.Add("Teslim Tarihi", 120, HorizontalAlignment.Center);              
                list_oduncliste.Columns.Add("Ödünç Durumu", 100, HorizontalAlignment.Center);
                list_oduncliste.Columns.Add("Hasar Durumu", 100, HorizontalAlignment.Center);
                list_oduncliste.Columns.Add("Kitap Ücreti", 100, HorizontalAlignment.Center);

                for (int i = 0; i < datas.Tables[0].Rows.Count; i++)
                {
                    str[0] = datas.Tables[0].Rows[i]["oduncNo"].ToString();
                    str[1] = datas.Tables[0].Rows[i]["kitapNo"].ToString();                  
                    str[2] = datas.Tables[0].Rows[i]["adi"].ToString();
                    str[3] = datas.Tables[0].Rows[i]["soyadi"].ToString();
                    str[4] = datas.Tables[0].Rows[i]["kitapAdi"].ToString();
                    str[5] = datas.Tables[0].Rows[i]["tcNo"].ToString();
                    str[6] = datas.Tables[0].Rows[i]["oduncTarihi"].ToString();
                    str[7] = datas.Tables[0].Rows[i]["sonTeslimTarihi"].ToString();
                    str[8] = datas.Tables[0].Rows[i]["teslimtarihi"].ToString();                    
                    str[9] = datas.Tables[0].Rows[i]["oduncDurumu"].ToString();
                    str[10] = datas.Tables[0].Rows[i]["hasarDurumu"].ToString();
                    str[11] = datas.Tables[0].Rows[i]["kitapUcreti"].ToString();
                    item = new ListViewItem(str);
                    list_oduncliste.Items.Add(item);
                }
            }
            connect.Close();
        }

        public void Uye_Listesi()
        {
            connect = new SqlConnection(connected);
            string sorgu = "select * from uye";
            SqlDataAdapter veriler = new SqlDataAdapter(sorgu, connect);
            DataSet datas = new DataSet();
            ListViewItem item = new ListViewItem();
            string[] str = new string[6];
            connect.Open();
            veriler.Fill(datas);

            if (datas.Tables[0].Rows.Count != 0)
            {             
                  listuyeler.Clear();             
                  listuyeler.Columns.Add("T.C. No", 50, HorizontalAlignment.Center);
                  listuyeler.Columns.Add("Adı", 100, HorizontalAlignment.Center);
                  listuyeler.Columns.Add("Soyadı", 100, HorizontalAlignment.Center);
                  listuyeler.Columns.Add("E-posta", 120, HorizontalAlignment.Center);
                  listuyeler.Columns.Add("Telefon", 120, HorizontalAlignment.Center);
                  listuyeler.Columns.Add("Adres", 250, HorizontalAlignment.Center);

                for (int i = 0; i < datas.Tables[0].Rows.Count; i++)
                {
                    str[0] = datas.Tables[0].Rows[i]["tcNo"].ToString();
                    str[1] = datas.Tables[0].Rows[i]["adi"].ToString();
                    str[2] = datas.Tables[0].Rows[i]["soyadi"].ToString();
                    str[3] = datas.Tables[0].Rows[i]["eposta"].ToString();
                    str[4] = datas.Tables[0].Rows[i]["tel"].ToString();
                    str[5] = datas.Tables[0].Rows[i]["adres"].ToString();
                    item = new ListViewItem(str);
                      listuyeler.Items.Add(item);
                }
            }
            connect.Close();
        }

        public void kitap_Listesi()
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
                list_kitapliste.Clear();             
                list_kitapliste.Columns.Add("Kitap No", 0, HorizontalAlignment.Center);
                list_kitapliste.Columns.Add("Yazar Adı", 200, HorizontalAlignment.Center);
                list_kitapliste.Columns.Add("Yazar Soyadı", 200, HorizontalAlignment.Center);
                list_kitapliste.Columns.Add("Kitap Adı", 200, HorizontalAlignment.Center);
                list_kitapliste.Columns.Add("Tür Adı", 120, HorizontalAlignment.Center);
                list_kitapliste.Columns.Add("Sayfa Sayısı", 120, HorizontalAlignment.Center);
                list_kitapliste.Columns.Add("Kitap Özeti", 100, HorizontalAlignment.Center);
                list_kitapliste.Columns.Add("Kitap Ücreti", 100, HorizontalAlignment.Center);
                list_kitapliste.Columns.Add("Ödünç Durumu", 100, HorizontalAlignment.Center);

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
                    list_kitapliste.Items.Add(item);
                }
            }
            connect.Close();
        }

        public void yazar_listesi()
        {
            connect = new SqlConnection(connected);
            string sorgu = "select * from yazar";
            SqlDataAdapter veriler = new SqlDataAdapter(sorgu, connect);
            DataSet datas = new DataSet();
            ListViewItem item = new ListViewItem();
            string[] str = new string[5];
            connect.Open();
            veriler.Fill(datas);
            if (datas.Tables[0].Rows.Count != 0)
            {
                list_yazarliste.Clear();            
                list_yazarliste.Columns.Add("Yazar No", 0, HorizontalAlignment.Center);
                list_yazarliste.Columns.Add("Adı", 200, HorizontalAlignment.Center);
                list_yazarliste.Columns.Add("Soyadı", 200, HorizontalAlignment.Center);
                list_yazarliste.Columns.Add("Doğum Tarihi", 120, HorizontalAlignment.Center);
                list_yazarliste.Columns.Add("Hayat Özeti", 300, HorizontalAlignment.Center);
             
                for (int i = 0; i < datas.Tables[0].Rows.Count; i++)
                {
                    str[0] = datas.Tables[0].Rows[i]["yazarNo"].ToString();
                    str[1] = datas.Tables[0].Rows[i]["adi"].ToString();
                    str[2] = datas.Tables[0].Rows[i]["soyadi"].ToString();
                    str[3] = datas.Tables[0].Rows[i]["dogumTarihi"].ToString();
                    str[4] = datas.Tables[0].Rows[i]["hayatOzeti"].ToString();
                   
                    item = new ListViewItem(str);
                    list_yazarliste.Items.Add(item);
                }
            }
            connect.Close();
        }

        int oduncsayisi=0, ceza=0;
        private void btn_uye_sil_Click(object sender, EventArgs e)
        {
            oduncsayisi = 0;
            ceza = 0;
            txt_oduncara.Text = "";
            txt_cezaara.Text = "";
            connect = new SqlConnection(connected);
            string sorgu3 = "SELECT ceza.cezaNo,kitap.kitapAdi,uye.tcNo,uye.adi,uye.soyadi,ceza.cezaUcreti,ceza.odemeDurumu FROM (ceza INNER JOIN kitap ON ceza.kitapNo = kitap.kitapNo) INNER JOIN uye ON ceza.tcNo = uye.tcNo where ceza.odemeDurumu  IS NULL and  uye.tcNo = " + TcNo + "";
            SqlDataAdapter veriler3 = new SqlDataAdapter(sorgu3, connect);
            DataSet datas3 = new DataSet();
            ListViewItem item3 = new ListViewItem();
            connect.Open();
            veriler3.Fill(datas3);
            ceza = Convert.ToInt32(datas3.Tables[0].Rows.Count.ToString());

            try
            {
                uyeadi = listuyeler.SelectedItems[0].SubItems[1].Text;
                TcNo = Convert.ToInt32(listuyeler.SelectedItems[0].SubItems[0].Text);

                connect = new SqlConnection(connected);
                string sorgu2 = "SELECT kitap.kitapUcreti,odunc.hasarDurumu,uye.tcNo,odunc.oduncNo,odunc.oduncTarihi,odunc.sonTeslimTarihi,odunc.teslimtarihi,uye.adi,uye.soyadi,kitap.kitapNo,kitap.kitapAdi,kitap.turAdi,kitap.sayfaSayisi,kitap.kitapOzeti,kitap.kitapUcreti,kitap.oduncDurumu FROM(kitap INNER JOIN odunc ON kitap.kitapNo = odunc.kitapNo) INNER JOIN uye ON odunc.tcNo = uye.tcNo where uye.tcNo = " + TcNo + " and odunc.teslimTarihi IS NULL";
                SqlDataAdapter veriler = new SqlDataAdapter(sorgu2, connect);
                DataSet datas = new DataSet();
                ListViewItem item = new ListViewItem();
                connect.Open();
                veriler.Fill(datas);
                oduncsayisi = Convert.ToInt32(datas.Tables[0].Rows.Count.ToString());

                if (oduncsayisi > 0 && ceza > 0)
                {
                    MessageBoxEx.EnableGlass = false;
                    MessageBoxEx.Show("Üyemize ait " + oduncsayisi + " adet ödünç kaydı ve cezası bulunmaktadır! Üyemiz bu kitapları getirmesi durumunda silme işlemi yapılabilir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmb_oduncara.SelectedIndex = 2;
                    txt_oduncara.Text = uyeadi;
                    ribbonControl1.SelectedRibbonTabItem = oduncler;
                }
                else if (oduncsayisi > 0)
                {
                    MessageBoxEx.EnableGlass = false;
                    MessageBoxEx.Show("Üyemize ait " + oduncsayisi + " adet ödünç kaydı  bulunmaktadır! Üyemiz bu kitapları getirmesi durumunda silme işlemi yapılabilir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmb_oduncara.SelectedIndex = 2;
                    txt_oduncara.Text = uyeadi;
                    ribbonControl1.SelectedRibbonTabItem = oduncler;
                }
                else if (ceza > 0)
                {
                    MessageBoxEx.EnableGlass = false;
                    MessageBoxEx.Show("Üyenin cezası bulunmaktadır! Ceza ücretini ödemesi durumunda silme işlemi yapılabilir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmb_cezaara.SelectedIndex = 2;
                    txt_oduncara.Text = uyeadi;
                    ribbonControl1.SelectedRibbonTabItem = cezalar;
                }
                else
                {
                    MessageBoxEx.EnableGlass = false;
                    DialogResult cev;
                    cev = MessageBoxEx.Show("Bu Üyeyi Silmek istediğinizden Emin Misiniz?", "Üye Siliniyor", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (cev == DialogResult.Yes)
                    {
                        TcNo = Convert.ToInt32(listuyeler.SelectedItems[0].SubItems[0].Text);
                        string sorgu = "delete from uye where tcNo=" + TcNo;
                        connect = new SqlConnection(connected);
                        SqlCommand cmd = new SqlCommand(sorgu, connect);
                        connect.Open();
                        cmd.ExecuteNonQuery();
                        connect.Close();
                        Uye_Listesi();
                    }
                    else
                    {

                    }
                }
            }
            catch
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show("Lütfen tablodan bir kayıt seçiniz!");
            }
            temizle();
        }

        private void oduncMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {           
            TcNo = Convert.ToInt32(listuyeler.SelectedItems[0].SubItems[0].Text);
            oduncEkle oduncEkle = new oduncEkle();
            oduncEkle.ShowDialog();
            }
            catch
            {                
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show("Lütfen tablodan bir kayıt seçiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                yazarNo = Convert.ToInt32(list_yazarliste.SelectedItems[0].SubItems[0].Text);
                kitapEkle ktpekle = new kitapEkle();
                ktpekle.ShowDialog();
            }
            catch
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show("Lütfen tablodan bir kayıt seçiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }           
        }

        private void anaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_yazarsil_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBoxEx.EnableGlass = false;
                DialogResult cev;
                cev = MessageBoxEx.Show("Bu Yazarı Silmek istediğinizden Emin Misiniz?", "Yazar Siliniyor", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (cev == DialogResult.Yes)
                {
                    if (yazarNo.ToString() != "")
                    {
                        yazarNo = Convert.ToInt32(list_yazarliste.SelectedItems[0].SubItems[0].Text);

                        string sorgu = "delete from yazar where yazarNo=" + yazarNo;
                        string sorgu2 = "delete from kitap where yazarNo=" + yazarNo;
                        connect = new SqlConnection(connected);
                        SqlCommand cmd = new SqlCommand(sorgu, connect);
                        SqlCommand cmd2 = new SqlCommand(sorgu2, connect);
                        connect.Open();
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        connect.Close();
                        yazar_listesi();
                    }
                    else
                    {
                        MessageBoxEx.EnableGlass = false;
                        MessageBoxEx.Show("Lütfen tablodan bir kayıt seçiniz!");
                    }
                }
                else
                {

                }
            }
            catch
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show("Lütfen tablodan bir kayıt seçiniz!");
            }
        }

        private void btn_yazarguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                yazarNo = Convert.ToInt32(list_yazarliste.SelectedItems[0].SubItems[0].Text);
                yazarGuncelle yazargun = new yazarGuncelle();
                yazargun.ShowDialog();
            }
            catch (Exception)
            {
                MessageBoxEx.Show("Lütfen tablodan bir kayıt seçiniz!");
            }
        }

        private void guncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TcNo = Convert.ToInt32(listuyeler.SelectedItems[0].SubItems[0].Text);
                uyeGuncelle uyegun = new uyeGuncelle();
                uyegun.Show();
               
            }
            catch (Exception)
            {
                MessageBoxEx.Show("Lütfen tablodan bir kayıt seçiniz!");
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oduncsayisi = 0;
            ceza = 0;
            txt_oduncara.Text = "";
            txt_cezaara.Text = "";
            connect = new SqlConnection(connected);
            string sorgu3 = "SELECT ceza.cezaNo,kitap.kitapAdi,uye.tcNo,uye.adi,uye.soyadi,ceza.cezaUcreti,ceza.odemeDurumu FROM (ceza INNER JOIN kitap ON ceza.kitapNo = kitap.kitapNo) INNER JOIN uye ON ceza.tcNo = uye.tcNo where ceza.odemeDurumu  IS NULL and  uye.tcNo = " + TcNo + "";
            SqlDataAdapter veriler3 = new SqlDataAdapter(sorgu3, connect);
            DataSet datas3 = new DataSet();
            ListViewItem item3 = new ListViewItem();
            connect.Open();
            veriler3.Fill(datas3);
            ceza = Convert.ToInt32(datas3.Tables[0].Rows.Count.ToString());

            try
            {
                uyeadi = listuyeler.SelectedItems[0].SubItems[1].Text;
                TcNo = Convert.ToInt32(listuyeler.SelectedItems[0].SubItems[0].Text);
                connect = new SqlConnection(connected);
                string sorgu2 = "SELECT kitap.kitapUcreti,odunc.hasarDurumu,uye.tcNo,odunc.oduncNo,odunc.oduncTarihi,odunc.sonTeslimTarihi,odunc.teslimtarihi,uye.adi,uye.soyadi,kitap.kitapNo,kitap.kitapAdi,kitap.turAdi,kitap.sayfaSayisi,kitap.kitapOzeti,kitap.kitapUcreti,kitap.oduncDurumu FROM(kitap INNER JOIN odunc ON kitap.kitapNo = odunc.kitapNo) INNER JOIN uye ON odunc.tcNo = uye.tcNo where uye.tcNo = " + TcNo + " and odunc.teslimTarihi IS NULL";
                SqlDataAdapter veriler = new SqlDataAdapter(sorgu2, connect);
                DataSet datas = new DataSet();
                ListViewItem item = new ListViewItem();
                connect.Open();
                veriler.Fill(datas);
                oduncsayisi = Convert.ToInt32(datas.Tables[0].Rows.Count.ToString());

                if (oduncsayisi > 0 && ceza > 0)
                {
                    MessageBoxEx.EnableGlass = false;
                    MessageBoxEx.Show("Üyemize ait " + oduncsayisi + " adet ödünç kaydı ve cezası bulunmaktadır! Üyemiz bu kitapları getirmesi durumunda silme işlemi yapılabilir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmb_oduncara.SelectedIndex = 2;
                    txt_oduncara.Text = uyeadi;
                    ribbonControl1.SelectedRibbonTabItem = oduncler;
                }
                else if (oduncsayisi > 0)
                {
                    MessageBoxEx.EnableGlass = false;
                    MessageBoxEx.Show("Üyemize ait " + oduncsayisi + " adet ödünç kaydı  bulunmaktadır! Üyemiz bu kitapları getirmesi durumunda silme işlemi yapılabilir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmb_oduncara.SelectedIndex = 2;
                    txt_oduncara.Text = uyeadi;
                    ribbonControl1.SelectedRibbonTabItem = oduncler;
                }
                else if (ceza > 0)
                {
                    MessageBoxEx.EnableGlass = false;
                    MessageBoxEx.Show("Üyenin cezası bulunmaktadır! Ceza ücretini ödemesi durumunda silme işlemi yapılabilir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmb_cezaara.SelectedIndex = 2;
                    txt_cezaara.Text = uyeadi;
                    ribbonControl1.SelectedRibbonTabItem = cezalar;
                }
                else
                {
                    MessageBoxEx.EnableGlass = false;
                    DialogResult cev;
                    cev = MessageBoxEx.Show("Bu Üyeyi Silmek istediğinizden Emin Misiniz?", "Üye Siliniyor", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (cev == DialogResult.Yes)
                    {
                        TcNo = Convert.ToInt32(listuyeler.SelectedItems[0].SubItems[0].Text);
                        string sorgu = "delete from uye where tcNo=" + TcNo;
                        connect = new SqlConnection(connected);
                        SqlCommand cmd = new SqlCommand(sorgu, connect);
                        connect.Open();
                        cmd.ExecuteNonQuery();
                        connect.Close();
                        Uye_Listesi();
                    }
                    else
                    {

                    }
                }
            }
            catch
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show("Lütfen tablodan bir kayıt seçiniz!");
            }
        }

        private void yazarGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                yazarNo = Convert.ToInt32(list_yazarliste.SelectedItems[0].SubItems[0].Text);
                yazarGuncelle yazargun = new yazarGuncelle();
                yazargun.ShowDialog();
            }
            catch (Exception)
            {
                MessageBoxEx.Show("Lütfen tablodan bir kayıt seçiniz!");
            }
        }

        private void txt_yazarara_TextChanged(object sender, EventArgs e)
        {
            if (cmb_yazarara.SelectedIndex == 1)
            {
                connect = new SqlConnection(connected);
                string sorgu = "select * from yazar where adi like '%" + txt_yazarara.Text + "%'";
                SqlDataAdapter veriler = new SqlDataAdapter(sorgu, connect);
                DataSet datas = new DataSet();
                ListViewItem item = new ListViewItem();
                string[] str = new string[5];
                connect.Open();
                veriler.Fill(datas);

                if (datas.Tables[0].Rows.Count != 0)
                {
                    list_yazarliste.Clear();
                    list_yazarliste.Columns.Add("Yazar No", 0, HorizontalAlignment.Center);
                    list_yazarliste.Columns.Add("Adı", 200, HorizontalAlignment.Center);
                    list_yazarliste.Columns.Add("Soyadı", 200, HorizontalAlignment.Center);
                    list_yazarliste.Columns.Add("Doğum Tarihi", 120, HorizontalAlignment.Center);
                    list_yazarliste.Columns.Add("Hayat Özeti", 300, HorizontalAlignment.Center);

                    for (int i = 0; i < datas.Tables[0].Rows.Count; i++)
                    {
                        str[0] = datas.Tables[0].Rows[i]["yazarNo"].ToString();
                        str[1] = datas.Tables[0].Rows[i]["adi"].ToString();
                        str[2] = datas.Tables[0].Rows[i]["soyadi"].ToString();
                        str[3] = datas.Tables[0].Rows[i]["dogumTarihi"].ToString();
                        str[4] = datas.Tables[0].Rows[i]["hayatOzeti"].ToString();
                        item = new ListViewItem(str);
                        list_yazarliste.Items.Add(item);
                    }
                }
                connect.Close();
            }
            else if (cmb_yazarara.SelectedIndex == 2)
            {
                connect = new SqlConnection(connected);
                string sorgu = "select * from yazar where soyadi like '%" + txt_yazarara.Text + "%'";
                SqlDataAdapter veriler = new SqlDataAdapter(sorgu, connect);
                DataSet datas = new DataSet();
                ListViewItem item = new ListViewItem();
                string[] str = new string[5];
                connect.Open();
                veriler.Fill(datas);
                if (datas.Tables[0].Rows.Count != 0)
                {
                    list_yazarliste.Clear();
                    list_yazarliste.Columns.Add("Yazar No", 0, HorizontalAlignment.Center);
                    list_yazarliste.Columns.Add("Adı", 200, HorizontalAlignment.Center);
                    list_yazarliste.Columns.Add("Soyadı", 200, HorizontalAlignment.Center);
                    list_yazarliste.Columns.Add("Doğum Tarihi", 120, HorizontalAlignment.Center);
                    list_yazarliste.Columns.Add("Hayat Özeti", 300, HorizontalAlignment.Center);

                    for (int i = 0; i < datas.Tables[0].Rows.Count; i++)
                    {
                        str[0] = datas.Tables[0].Rows[i]["yazarNo"].ToString();
                        str[1] = datas.Tables[0].Rows[i]["adi"].ToString();
                        str[2] = datas.Tables[0].Rows[i]["soyadi"].ToString();
                        str[3] = datas.Tables[0].Rows[i]["dogumTarihi"].ToString();
                        str[4] = datas.Tables[0].Rows[i]["hayatOzeti"].ToString();
                        item = new ListViewItem(str);
                        list_yazarliste.Items.Add(item);
                    }
                }
                connect.Close();
            }
            else
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show("Lütfen arama yapılacak bir kriter seçiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }       
        }

        private void txt_ara_TextChanged(object sender, EventArgs e)
        {
            if (cmb_ara.SelectedIndex == 1)
            {
                connect = new SqlConnection(connected);
                string sorgu = "select * from uye where tcNo = '" + txt_ara.Text + "'";
                SqlDataAdapter veriler = new SqlDataAdapter(sorgu, connect);
                DataSet datas = new DataSet();
                ListViewItem item = new ListViewItem();
                string[] str = new string[6];
                connect.Open();
                veriler.Fill(datas);

                if (datas.Tables[0].Rows.Count != 0)
                {
                    listuyeler.Clear();
                    listuyeler.Columns.Add("T.C. No", 300, HorizontalAlignment.Center);
                    listuyeler.Columns.Add("Adı", 200, HorizontalAlignment.Center);
                    listuyeler.Columns.Add("Soyadı", 200, HorizontalAlignment.Center);
                    listuyeler.Columns.Add("E-posta", 120, HorizontalAlignment.Center);
                    listuyeler.Columns.Add("Telefon", 120, HorizontalAlignment.Center);
                    listuyeler.Columns.Add("Adres", 500, HorizontalAlignment.Center);

                    for (int i = 0; i < datas.Tables[0].Rows.Count; i++)
                    {
                        str[0] = datas.Tables[0].Rows[i]["tcNo"].ToString();
                        str[1] = datas.Tables[0].Rows[i]["adi"].ToString();
                        str[2] = datas.Tables[0].Rows[i]["soyadi"].ToString();
                        str[3] = datas.Tables[0].Rows[i]["eposta"].ToString();
                        str[4] = datas.Tables[0].Rows[i]["tel"].ToString();
                        str[5] = datas.Tables[0].Rows[i]["adres"].ToString();
                        item = new ListViewItem(str);
                        listuyeler.Items.Add(item);
                    }
                }
                connect.Close();
            }
            else if (cmb_ara.SelectedIndex == 2)
            {
                connect = new SqlConnection(connected);
                string sorgu = "select * from uye where adi like '%" + txt_ara.Text + "%'";
                SqlDataAdapter veriler = new SqlDataAdapter(sorgu, connect);
                DataSet datas = new DataSet();
                ListViewItem item = new ListViewItem();
                string[] str = new string[6];
                connect.Open();
                veriler.Fill(datas);
                if (datas.Tables[0].Rows.Count != 0)
                {
                    listuyeler.Clear();
                    listuyeler.Columns.Add("T.C. No", 300, HorizontalAlignment.Center);
                    listuyeler.Columns.Add("Adı", 200, HorizontalAlignment.Center);
                    listuyeler.Columns.Add("Soyadı", 200, HorizontalAlignment.Center);
                    listuyeler.Columns.Add("E-posta", 120, HorizontalAlignment.Center);
                    listuyeler.Columns.Add("Telefon", 120, HorizontalAlignment.Center);
                    listuyeler.Columns.Add("Adres", 500, HorizontalAlignment.Center);

                    for (int i = 0; i < datas.Tables[0].Rows.Count; i++)
                    {
                        str[0] = datas.Tables[0].Rows[i]["tcNo"].ToString();
                        str[1] = datas.Tables[0].Rows[i]["adi"].ToString();
                        str[2] = datas.Tables[0].Rows[i]["soyadi"].ToString();
                        str[3] = datas.Tables[0].Rows[i]["eposta"].ToString();
                        str[4] = datas.Tables[0].Rows[i]["tel"].ToString();
                        str[5] = datas.Tables[0].Rows[i]["adres"].ToString();
                        item = new ListViewItem(str);
                        listuyeler.Items.Add(item);
                    }
                }
                connect.Close();
            }
            else if (cmb_ara.SelectedIndex == 3) 
            {
                connect = new SqlConnection(connected);
                string sorgu = "select * from uye where soyadi like '%" + txt_ara.Text + "%'";
                SqlDataAdapter veriler = new SqlDataAdapter(sorgu, connect);
                DataSet datas = new DataSet();
                ListViewItem item = new ListViewItem();
                string[] str = new string[6];
                connect.Open();
                veriler.Fill(datas);
                if (datas.Tables[0].Rows.Count != 0)
                {
                    listuyeler.Clear();
                    listuyeler.Columns.Add("T.C. No", 300, HorizontalAlignment.Center);
                    listuyeler.Columns.Add("Adı", 200, HorizontalAlignment.Center);
                    listuyeler.Columns.Add("Soyadı", 200, HorizontalAlignment.Center);
                    listuyeler.Columns.Add("E-posta", 120, HorizontalAlignment.Center);
                    listuyeler.Columns.Add("Telefon", 120, HorizontalAlignment.Center);
                    listuyeler.Columns.Add("Adres", 500, HorizontalAlignment.Center);

                    for (int i = 0; i < datas.Tables[0].Rows.Count; i++)
                    {
                        str[0] = datas.Tables[0].Rows[i]["tcNo"].ToString();
                        str[1] = datas.Tables[0].Rows[i]["adi"].ToString();
                        str[2] = datas.Tables[0].Rows[i]["soyadi"].ToString();
                        str[3] = datas.Tables[0].Rows[i]["eposta"].ToString();
                        str[4] = datas.Tables[0].Rows[i]["tel"].ToString();
                        str[5] = datas.Tables[0].Rows[i]["adres"].ToString();
                        item = new ListViewItem(str);
                        listuyeler.Items.Add(item);
                    }
                }
                connect.Close();
            }
            else
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show("Lütfen arama yapılacak bir kriter seçiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_kitapara_TextChanged(object sender, EventArgs e)
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
                    list_kitapliste.Clear();
                    list_kitapliste.Columns.Add("Kitap No", 0, HorizontalAlignment.Center);
                    list_kitapliste.Columns.Add("Yazar Adı", 200, HorizontalAlignment.Center);
                    list_kitapliste.Columns.Add("Yazar Soyadı", 200, HorizontalAlignment.Center);
                    list_kitapliste.Columns.Add("Kitap Adı", 200, HorizontalAlignment.Center);
                    list_kitapliste.Columns.Add("Tür Adı", 120, HorizontalAlignment.Center);
                    list_kitapliste.Columns.Add("Sayfa Sayısı", 120, HorizontalAlignment.Center);
                    list_kitapliste.Columns.Add("Kitap Özeti", 100, HorizontalAlignment.Center);
                    list_kitapliste.Columns.Add("Kitap Ücreti", 100, HorizontalAlignment.Center);
                    list_kitapliste.Columns.Add("Ödünç Durumu", 100, HorizontalAlignment.Center);

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
                        list_kitapliste.Items.Add(item);
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
                        list_kitapliste.Clear();
                        list_kitapliste.Columns.Add("Kitap No", 0, HorizontalAlignment.Center);
                        list_kitapliste.Columns.Add("Yazar Adı", 200, HorizontalAlignment.Center);
                        list_kitapliste.Columns.Add("Yazar Soyadı", 200, HorizontalAlignment.Center);
                        list_kitapliste.Columns.Add("Kitap Adı", 200, HorizontalAlignment.Center);
                        list_kitapliste.Columns.Add("Tür Adı", 120, HorizontalAlignment.Center);
                        list_kitapliste.Columns.Add("Sayfa Sayısı", 120, HorizontalAlignment.Center);
                        list_kitapliste.Columns.Add("Kitap Özeti", 100, HorizontalAlignment.Center);
                        list_kitapliste.Columns.Add("Kitap Ücreti", 100, HorizontalAlignment.Center);
                        list_kitapliste.Columns.Add("Ödünç Durumu", 100, HorizontalAlignment.Center);

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
                            list_kitapliste.Items.Add(item);
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
                        list_kitapliste.Clear();
                        list_kitapliste.Columns.Add("Kitap No", 0, HorizontalAlignment.Center);
                        list_kitapliste.Columns.Add("Yazar Adı", 200, HorizontalAlignment.Center);
                        list_kitapliste.Columns.Add("Yazar Soyadı", 200, HorizontalAlignment.Center);
                        list_kitapliste.Columns.Add("Kitap Adı", 200, HorizontalAlignment.Center);
                        list_kitapliste.Columns.Add("Tür Adı", 120, HorizontalAlignment.Center);
                        list_kitapliste.Columns.Add("Sayfa Sayısı", 120, HorizontalAlignment.Center);
                        list_kitapliste.Columns.Add("Kitap Özeti", 100, HorizontalAlignment.Center);
                        list_kitapliste.Columns.Add("Kitap Ücreti", 100, HorizontalAlignment.Center);
                        list_kitapliste.Columns.Add("Ödünç Durumu", 100, HorizontalAlignment.Center);

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
                            list_kitapliste.Items.Add(item);
                        }
                    }
                    connect.Close();
                }
                else
                {
                    MessageBoxEx.EnableGlass = false;
                    MessageBoxEx.Show("Lütfen arama yapılacak bir kriter seçiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txt_oduncara_TextChanged(object sender, EventArgs e)
        {
            if (txt_oduncara.Text.Trim() == "")
            {
                connect = new SqlConnection(connected);
                string sorgu = "SELECT kitap.kitapUcreti,odunc.hasarDurumu,uye.tcNo,odunc.oduncNo,odunc.oduncTarihi,odunc.sonTeslimTarihi,odunc.teslimtarihi,uye.adi,uye.soyadi,kitap.kitapNo,kitap.kitapAdi,kitap.turAdi,kitap.sayfaSayisi,kitap.kitapOzeti,kitap.kitapUcreti,kitap.oduncDurumu FROM(kitap INNER JOIN odunc ON kitap.kitapNo = odunc.kitapNo) INNER JOIN uye ON odunc.tcNo = uye.tcNo";
                SqlDataAdapter veriler = new SqlDataAdapter(sorgu, connect);
                DataSet datas = new DataSet();
                ListViewItem item = new ListViewItem();
                string[] str = new string[12];
                connect.Open();
                veriler.Fill(datas);

                if (datas.Tables[0].Rows.Count != 0)
                {
                    list_oduncliste.Clear();
                    list_oduncliste.Columns.Add("Ödünç No", 0, HorizontalAlignment.Center);
                    list_oduncliste.Columns.Add("Kitap No", 0, HorizontalAlignment.Center);
                    list_oduncliste.Columns.Add("Üye Adı", 50, HorizontalAlignment.Center);
                    list_oduncliste.Columns.Add("Üye Soyadı", 50, HorizontalAlignment.Center);
                    list_oduncliste.Columns.Add("Kitap Adı", 100, HorizontalAlignment.Center);
                    list_oduncliste.Columns.Add("T.C No", 100, HorizontalAlignment.Center);
                    list_oduncliste.Columns.Add("Ödünç Tarihi", 100, HorizontalAlignment.Center);
                    list_oduncliste.Columns.Add("Son Teslim Tarihi", 120, HorizontalAlignment.Center);
                    list_oduncliste.Columns.Add("Teslim Tarihi", 120, HorizontalAlignment.Center);
                    list_oduncliste.Columns.Add("Ödünç Durumu", 100, HorizontalAlignment.Center);
                    list_oduncliste.Columns.Add("Hasar Durumu", 100, HorizontalAlignment.Center);
                    list_oduncliste.Columns.Add("Kitap Ücreti", 100, HorizontalAlignment.Center);

                    for (int i = 0; i < datas.Tables[0].Rows.Count; i++)
                    {
                        str[0] = datas.Tables[0].Rows[i]["oduncNo"].ToString();
                        str[1] = datas.Tables[0].Rows[i]["kitapNo"].ToString();
                        str[2] = datas.Tables[0].Rows[i]["adi"].ToString();
                        str[3] = datas.Tables[0].Rows[i]["soyadi"].ToString();
                        str[4] = datas.Tables[0].Rows[i]["kitapAdi"].ToString();
                        str[5] = datas.Tables[0].Rows[i]["tcNo"].ToString();
                        str[6] = datas.Tables[0].Rows[i]["oduncTarihi"].ToString();
                        str[7] = datas.Tables[0].Rows[i]["sonTeslimTarihi"].ToString();
                        str[8] = datas.Tables[0].Rows[i]["teslimtarihi"].ToString();
                        str[9] = datas.Tables[0].Rows[i]["oduncDurumu"].ToString();
                        str[10] = datas.Tables[0].Rows[i]["hasarDurumu"].ToString();
                        str[11] = datas.Tables[0].Rows[i]["kitapUcreti"].ToString();
                        item = new ListViewItem(str);
                        list_oduncliste.Items.Add(item);
                    }
                }
                connect.Close();
            }
            else
            {
                if (cmb_oduncara.SelectedIndex == 1)
                {
                    connect = new SqlConnection(connected);
                    string sorgu = "SELECT kitap.kitapUcreti,odunc.hasarDurumu,uye.tcNo,odunc.oduncNo,odunc.oduncTarihi,odunc.sonTeslimTarihi,odunc.teslimtarihi,uye.adi,uye.soyadi,kitap.kitapNo,kitap.kitapAdi,kitap.turAdi,kitap.sayfaSayisi,kitap.kitapOzeti,kitap.kitapUcreti,kitap.oduncDurumu FROM(kitap INNER JOIN odunc ON kitap.kitapNo = odunc.kitapNo) INNER JOIN uye ON odunc.tcNo = uye.tcNo where uye.tcNo= " + txt_oduncara.Text + "";
                    SqlDataAdapter veriler = new SqlDataAdapter(sorgu, connect);
                    DataSet datas = new DataSet();
                    ListViewItem item = new ListViewItem();
                    string[] str = new string[12];
                    connect.Open();
                    veriler.Fill(datas);

                    if (datas.Tables[0].Rows.Count != 0)
                    {
                        list_oduncliste.Clear();
                        list_oduncliste.Columns.Add("Ödünç No", 0, HorizontalAlignment.Center);
                        list_oduncliste.Columns.Add("Kitap No", 0, HorizontalAlignment.Center);
                        list_oduncliste.Columns.Add("Üye Adı", 50, HorizontalAlignment.Center);
                        list_oduncliste.Columns.Add("Üye Soyadı", 50, HorizontalAlignment.Center);
                        list_oduncliste.Columns.Add("Kitap Adı", 100, HorizontalAlignment.Center);
                        list_oduncliste.Columns.Add("T.C No", 100, HorizontalAlignment.Center);
                        list_oduncliste.Columns.Add("Ödünç Tarihi", 100, HorizontalAlignment.Center);
                        list_oduncliste.Columns.Add("Son Teslim Tarihi", 120, HorizontalAlignment.Center);
                        list_oduncliste.Columns.Add("Teslim Tarihi", 120, HorizontalAlignment.Center);
                        list_oduncliste.Columns.Add("Ödünç Durumu", 100, HorizontalAlignment.Center);
                        list_oduncliste.Columns.Add("Hasar Durumu", 100, HorizontalAlignment.Center);
                        list_oduncliste.Columns.Add("Kitap Ücreti", 100, HorizontalAlignment.Center);

                        for (int i = 0; i < datas.Tables[0].Rows.Count; i++)
                        {
                            str[0] = datas.Tables[0].Rows[i]["oduncNo"].ToString();
                            str[1] = datas.Tables[0].Rows[i]["kitapNo"].ToString();
                            str[2] = datas.Tables[0].Rows[i]["adi"].ToString();
                            str[3] = datas.Tables[0].Rows[i]["soyadi"].ToString();
                            str[4] = datas.Tables[0].Rows[i]["kitapAdi"].ToString();
                            str[5] = datas.Tables[0].Rows[i]["tcNo"].ToString();
                            str[6] = datas.Tables[0].Rows[i]["oduncTarihi"].ToString();
                            str[7] = datas.Tables[0].Rows[i]["sonTeslimTarihi"].ToString();
                            str[8] = datas.Tables[0].Rows[i]["teslimtarihi"].ToString();
                            str[9] = datas.Tables[0].Rows[i]["oduncDurumu"].ToString();
                            str[10] = datas.Tables[0].Rows[i]["hasarDurumu"].ToString();
                            str[11] = datas.Tables[0].Rows[i]["kitapUcreti"].ToString();
                            item = new ListViewItem(str);
                            list_oduncliste.Items.Add(item);
                        }
                    }
                    connect.Close();
                }
                else if (cmb_oduncara.SelectedIndex == 2)
                {
                    connect = new SqlConnection(connected);
                    string sorgu = "SELECT kitap.kitapUcreti,odunc.hasarDurumu,uye.tcNo,odunc.oduncNo,odunc.oduncTarihi,odunc.sonTeslimTarihi,odunc.teslimtarihi,uye.adi,uye.soyadi,kitap.kitapNo,kitap.kitapAdi,kitap.turAdi,kitap.sayfaSayisi,kitap.kitapOzeti,kitap.kitapUcreti,kitap.oduncDurumu FROM(kitap INNER JOIN odunc ON kitap.kitapNo = odunc.kitapNo) INNER JOIN uye ON odunc.tcNo = uye.tcNo where uye.adi like '%" + txt_oduncara.Text + "%'";
                    SqlDataAdapter veriler = new SqlDataAdapter(sorgu, connect);
                    DataSet datas = new DataSet();
                    ListViewItem item = new ListViewItem();
                    string[] str = new string[12];
                    connect.Open();
                    veriler.Fill(datas);

                    if (datas.Tables[0].Rows.Count != 0)
                    {
                        list_oduncliste.Clear();
                        list_oduncliste.Columns.Add("Ödünç No", 0, HorizontalAlignment.Center);
                        list_oduncliste.Columns.Add("Kitap No", 0, HorizontalAlignment.Center);
                        list_oduncliste.Columns.Add("Üye Adı", 50, HorizontalAlignment.Center);
                        list_oduncliste.Columns.Add("Üye Soyadı", 50, HorizontalAlignment.Center);
                        list_oduncliste.Columns.Add("Kitap Adı", 100, HorizontalAlignment.Center);
                        list_oduncliste.Columns.Add("T.C No", 100, HorizontalAlignment.Center);
                        list_oduncliste.Columns.Add("Ödünç Tarihi", 100, HorizontalAlignment.Center);
                        list_oduncliste.Columns.Add("Son Teslim Tarihi", 120, HorizontalAlignment.Center);
                        list_oduncliste.Columns.Add("Teslim Tarihi", 120, HorizontalAlignment.Center);
                        list_oduncliste.Columns.Add("Ödünç Durumu", 100, HorizontalAlignment.Center);
                        list_oduncliste.Columns.Add("Hasar Durumu", 100, HorizontalAlignment.Center);
                        list_oduncliste.Columns.Add("Kitap Ücreti", 100, HorizontalAlignment.Center);

                        for (int i = 0; i < datas.Tables[0].Rows.Count; i++)
                        {
                            str[0] = datas.Tables[0].Rows[i]["oduncNo"].ToString();
                            str[1] = datas.Tables[0].Rows[i]["kitapNo"].ToString();
                            str[2] = datas.Tables[0].Rows[i]["adi"].ToString();
                            str[3] = datas.Tables[0].Rows[i]["soyadi"].ToString();
                            str[4] = datas.Tables[0].Rows[i]["kitapAdi"].ToString();
                            str[5] = datas.Tables[0].Rows[i]["tcNo"].ToString();
                            str[6] = datas.Tables[0].Rows[i]["oduncTarihi"].ToString();
                            str[7] = datas.Tables[0].Rows[i]["sonTeslimTarihi"].ToString();
                            str[8] = datas.Tables[0].Rows[i]["teslimtarihi"].ToString();
                            str[9] = datas.Tables[0].Rows[i]["oduncDurumu"].ToString();
                            str[10] = datas.Tables[0].Rows[i]["hasarDurumu"].ToString();
                            str[11] = datas.Tables[0].Rows[i]["kitapUcreti"].ToString();
                            item = new ListViewItem(str);
                            list_oduncliste.Items.Add(item);
                        }
                    }
                    connect.Close();
                }
                else if (cmb_oduncara.SelectedIndex == 3)
                {
                    connect = new SqlConnection(connected);
                    string sorgu = "SELECT kitap.kitapUcreti,odunc.hasarDurumu,uye.tcNo,odunc.oduncNo,odunc.oduncTarihi,odunc.sonTeslimTarihi,odunc.teslimtarihi,uye.adi,uye.soyadi,kitap.kitapNo,kitap.kitapAdi,kitap.turAdi,kitap.sayfaSayisi,kitap.kitapOzeti,kitap.kitapUcreti,kitap.oduncDurumu FROM(kitap INNER JOIN odunc ON kitap.kitapNo = odunc.kitapNo) INNER JOIN uye ON odunc.tcNo = uye.tcNo where uye.soyadi like '%" + txt_oduncara.Text + "%'";
                    SqlDataAdapter veriler = new SqlDataAdapter(sorgu, connect);
                    DataSet datas = new DataSet();
                    ListViewItem item = new ListViewItem();
                    string[] str = new string[12];
                    connect.Open();
                    veriler.Fill(datas);

                    if (datas.Tables[0].Rows.Count != 0)
                    {
                        list_oduncliste.Clear();
                 
                        list_oduncliste.Columns.Add("Ödünç No", 0, HorizontalAlignment.Center);
                        list_oduncliste.Columns.Add("Kitap No", 0, HorizontalAlignment.Center);
                        list_oduncliste.Columns.Add("Üye Adı", 50, HorizontalAlignment.Center);
                        list_oduncliste.Columns.Add("Üye Soyadı", 50, HorizontalAlignment.Center);
                        list_oduncliste.Columns.Add("Kitap Adı", 100, HorizontalAlignment.Center);
                        list_oduncliste.Columns.Add("T.C No", 100, HorizontalAlignment.Center);
                        list_oduncliste.Columns.Add("Ödünç Tarihi", 100, HorizontalAlignment.Center);
                        list_oduncliste.Columns.Add("Son Teslim Tarihi", 120, HorizontalAlignment.Center);
                        list_oduncliste.Columns.Add("Teslim Tarihi", 120, HorizontalAlignment.Center);
                        list_oduncliste.Columns.Add("Ödünç Durumu", 100, HorizontalAlignment.Center);
                        list_oduncliste.Columns.Add("Hasar Durumu", 100, HorizontalAlignment.Center);
                        list_oduncliste.Columns.Add("Kitap Ücreti", 100, HorizontalAlignment.Center);

                        for (int i = 0; i < datas.Tables[0].Rows.Count; i++)
                        {
                            str[0] = datas.Tables[0].Rows[i]["oduncNo"].ToString();
                            str[1] = datas.Tables[0].Rows[i]["kitapNo"].ToString();
                            str[2] = datas.Tables[0].Rows[i]["adi"].ToString();
                            str[3] = datas.Tables[0].Rows[i]["soyadi"].ToString();
                            str[4] = datas.Tables[0].Rows[i]["kitapAdi"].ToString();
                            str[5] = datas.Tables[0].Rows[i]["tcNo"].ToString();
                            str[6] = datas.Tables[0].Rows[i]["oduncTarihi"].ToString();
                            str[7] = datas.Tables[0].Rows[i]["sonTeslimTarihi"].ToString();
                            str[8] = datas.Tables[0].Rows[i]["teslimtarihi"].ToString();
                            str[9] = datas.Tables[0].Rows[i]["oduncDurumu"].ToString();
                            str[10] = datas.Tables[0].Rows[i]["hasarDurumu"].ToString();
                            str[11] = datas.Tables[0].Rows[i]["kitapUcreti"].ToString();
                            item = new ListViewItem(str);
                            list_oduncliste.Items.Add(item);
                        }
                    }
                    connect.Close();
                }
                else
                {
                    MessageBoxEx.EnableGlass = false;
                    MessageBoxEx.Show("Lütfen arama yapılacak bir kriter seçiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txt_cezaara_TextChanged(object sender, EventArgs e)
        {
            if(txt_cezaara.Text.Trim()=="")
            {
                connect = new SqlConnection(connected);
                string sorgu = "SELECT kitap.kitapAdi,uye.tcNo,uye.adi,uye.soyadi,ceza.cezaUcreti,ceza.odemeDurumu FROM uye INNER JOIN ((ceza INNER JOIN kitap ON ceza.kitapNo = kitap.kitapNo) INNER JOIN odunc ON (kitap.kitapNo = odunc.kitapNo) AND (ceza.kitapNo = odunc.kitapNo)) ON uye.tcNo = odunc.tcNo";
                SqlDataAdapter veriler = new SqlDataAdapter(sorgu, connect);
                DataSet datas = new DataSet();
                ListViewItem item = new ListViewItem();
                string[] str = new string[6];
                connect.Open();
                veriler.Fill(datas);

                if (datas.Tables[0].Rows.Count != 0)
                {
                    list_cezaliste.Clear();
                    list_cezaliste.Columns.Add("T.C No", 100, HorizontalAlignment.Center);
                    list_cezaliste.Columns.Add("Kitap Adı", 100, HorizontalAlignment.Center);
                    list_cezaliste.Columns.Add("Üye Adı", 100, HorizontalAlignment.Center);
                    list_cezaliste.Columns.Add("Üye Soyadı", 100, HorizontalAlignment.Center);
                    list_cezaliste.Columns.Add("Ceza Ücreti", 100, HorizontalAlignment.Center);
                    list_cezaliste.Columns.Add("Ödeme Durumu", 120, HorizontalAlignment.Center);

                    for (int i = 0; i < datas.Tables[0].Rows.Count; i++)
                    {
                        str[0] = datas.Tables[0].Rows[i]["tcNo"].ToString();
                        str[1] = datas.Tables[0].Rows[i]["kitapAdi"].ToString();
                        str[2] = datas.Tables[0].Rows[i]["adi"].ToString();
                        str[3] = datas.Tables[0].Rows[i]["soyadi"].ToString();
                        str[4] = datas.Tables[0].Rows[i]["cezaUcreti"].ToString();
                        str[5] = datas.Tables[0].Rows[i]["odemeDurumu"].ToString();
                        item = new ListViewItem(str);
                        list_cezaliste.Items.Add(item);
                    }
                }
                connect.Close();
            }
            else
            {
                if(cmb_cezaara.SelectedIndex==1)
                {
                    connect = new SqlConnection(connected);
                    string sorgu = "SELECT kitap.kitapAdi,uye.tcNo,uye.adi,uye.soyadi,ceza.cezaUcreti,ceza.odemeDurumu FROM uye INNER JOIN ((ceza INNER JOIN kitap ON ceza.kitapNo = kitap.kitapNo) INNER JOIN odunc ON (kitap.kitapNo = odunc.kitapNo) AND (ceza.kitapNo = odunc.kitapNo)) ON uye.tcNo = odunc.tcNo where uye.tcNo like '%" + txt_cezaara.Text + "%'";
                    SqlDataAdapter veriler = new SqlDataAdapter(sorgu, connect);
                    DataSet datas = new DataSet();
                    ListViewItem item = new ListViewItem();
                    string[] str = new string[6];
                    connect.Open();
                    veriler.Fill(datas);

                    if (datas.Tables[0].Rows.Count != 0)
                    {
                        list_cezaliste.Clear();
                        list_cezaliste.Columns.Add("T.C No", 100, HorizontalAlignment.Center);
                        list_cezaliste.Columns.Add("Kitap Adı", 100, HorizontalAlignment.Center);
                        list_cezaliste.Columns.Add("Üye Adı", 100, HorizontalAlignment.Center);
                        list_cezaliste.Columns.Add("Üye Soyadı", 100, HorizontalAlignment.Center);
                        list_cezaliste.Columns.Add("Ceza Ücreti", 100, HorizontalAlignment.Center);
                        list_cezaliste.Columns.Add("Ödeme Durumu", 120, HorizontalAlignment.Center);

                        for (int i = 0; i < datas.Tables[0].Rows.Count; i++)
                        {
                            str[0] = datas.Tables[0].Rows[i]["tcNo"].ToString();
                            str[1] = datas.Tables[0].Rows[i]["kitapAdi"].ToString();
                            str[2] = datas.Tables[0].Rows[i]["adi"].ToString();
                            str[3] = datas.Tables[0].Rows[i]["soyadi"].ToString();
                            str[4] = datas.Tables[0].Rows[i]["cezaUcreti"].ToString();
                            str[5] = datas.Tables[0].Rows[i]["odemeDurumu"].ToString();
                            item = new ListViewItem(str);
                            list_cezaliste.Items.Add(item);
                        }
                    }
                    connect.Close();
                }
                else if (cmb_cezaara.SelectedIndex == 2)
                {
                    connect = new SqlConnection(connected);
                    string sorgu = "SELECT kitap.kitapAdi,uye.tcNo,uye.adi,uye.soyadi,ceza.cezaUcreti,ceza.odemeDurumu FROM uye INNER JOIN ((ceza INNER JOIN kitap ON ceza.kitapNo = kitap.kitapNo) INNER JOIN odunc ON (kitap.kitapNo = odunc.kitapNo) AND (ceza.kitapNo = odunc.kitapNo)) ON uye.tcNo = odunc.tcNo where uye.adi like '%" + txt_cezaara.Text + "%'";
                    SqlDataAdapter veriler = new SqlDataAdapter(sorgu, connect);
                    DataSet datas = new DataSet();
                    ListViewItem item = new ListViewItem();
                    string[] str = new string[6];
                    connect.Open();
                    veriler.Fill(datas);

                    if (datas.Tables[0].Rows.Count != 0)
                    {
                        list_cezaliste.Clear();
                        list_cezaliste.Columns.Add("T.C No", 100, HorizontalAlignment.Center);
                        list_cezaliste.Columns.Add("Kitap Adı", 100, HorizontalAlignment.Center);
                        list_cezaliste.Columns.Add("Üye Adı", 100, HorizontalAlignment.Center);
                        list_cezaliste.Columns.Add("Üye Soyadı", 100, HorizontalAlignment.Center);
                        list_cezaliste.Columns.Add("Ceza Ücreti", 100, HorizontalAlignment.Center);
                        list_cezaliste.Columns.Add("Ödeme Durumu", 120, HorizontalAlignment.Center);

                        for (int i = 0; i < datas.Tables[0].Rows.Count; i++)
                        {
                            str[0] = datas.Tables[0].Rows[i]["tcNo"].ToString();
                            str[1] = datas.Tables[0].Rows[i]["kitapAdi"].ToString();
                            str[2] = datas.Tables[0].Rows[i]["adi"].ToString();
                            str[3] = datas.Tables[0].Rows[i]["soyadi"].ToString();
                            str[4] = datas.Tables[0].Rows[i]["cezaUcreti"].ToString();
                            str[5] = datas.Tables[0].Rows[i]["odemeDurumu"].ToString();
                            item = new ListViewItem(str);
                            list_cezaliste.Items.Add(item);
                        }
                    }
                    connect.Close();
                }
                else if (cmb_cezaara.SelectedIndex == 3)
                {
                    connect = new SqlConnection(connected);
                    string sorgu = "SELECT kitap.kitapAdi,uye.tcNo,uye.adi,uye.soyadi,ceza.cezaUcreti,ceza.odemeDurumu FROM uye INNER JOIN ((ceza INNER JOIN kitap ON ceza.kitapNo = kitap.kitapNo) INNER JOIN odunc ON (kitap.kitapNo = odunc.kitapNo) AND (ceza.kitapNo = odunc.kitapNo)) ON uye.tcNo = odunc.tcNo where uye.soyadi like '%" + txt_cezaara.Text + "%'";
                    SqlDataAdapter veriler = new SqlDataAdapter(sorgu, connect);
                    DataSet datas = new DataSet();
                    ListViewItem item = new ListViewItem();
                    string[] str = new string[6];
                    connect.Open();
                    veriler.Fill(datas);

                    if (datas.Tables[0].Rows.Count != 0)
                    {
                        list_cezaliste.Clear();
                        list_cezaliste.Columns.Add("T.C No", 100, HorizontalAlignment.Center);
                        list_cezaliste.Columns.Add("Kitap Adı", 100, HorizontalAlignment.Center);
                        list_cezaliste.Columns.Add("Üye Adı", 100, HorizontalAlignment.Center);
                        list_cezaliste.Columns.Add("Üye Soyadı", 100, HorizontalAlignment.Center);
                        list_cezaliste.Columns.Add("Ceza Ücreti", 100, HorizontalAlignment.Center);
                        list_cezaliste.Columns.Add("Ödeme Durumu", 120, HorizontalAlignment.Center);

                        for (int i = 0; i < datas.Tables[0].Rows.Count; i++)
                        {
                            str[0] = datas.Tables[0].Rows[i]["tcNo"].ToString();
                            str[1] = datas.Tables[0].Rows[i]["kitapAdi"].ToString();
                            str[2] = datas.Tables[0].Rows[i]["adi"].ToString();
                            str[3] = datas.Tables[0].Rows[i]["soyadi"].ToString();
                            str[4] = datas.Tables[0].Rows[i]["cezaUcreti"].ToString();
                            str[5] = datas.Tables[0].Rows[i]["odemeDurumu"].ToString();
                            item = new ListViewItem(str);
                            list_cezaliste.Items.Add(item);
                        }
                    }
                    connect.Close();
                }
                else if (cmb_cezaara.SelectedIndex == 4)
                {
                    connect = new SqlConnection(connected);
                    string sorgu = "SELECT kitap.kitapAdi,uye.tcNo,uye.adi,uye.soyadi,ceza.cezaUcreti,ceza.odemeDurumu FROM uye INNER JOIN ((ceza INNER JOIN kitap ON ceza.kitapNo = kitap.kitapNo) INNER JOIN odunc ON (kitap.kitapNo = odunc.kitapNo) AND (ceza.kitapNo = odunc.kitapNo)) ON uye.tcNo = odunc.tcNo where kitap.kitapAdi like '%" + txt_cezaara.Text + "%'";
                    SqlDataAdapter veriler = new SqlDataAdapter(sorgu, connect);
                    DataSet datas = new DataSet();
                    ListViewItem item = new ListViewItem();
                    string[] str = new string[6];
                    connect.Open();
                    veriler.Fill(datas);

                    if (datas.Tables[0].Rows.Count != 0)
                    {
                        list_cezaliste.Clear();
                       list_cezaliste.Columns.Add("T.C No", 100, HorizontalAlignment.Center);
                        list_cezaliste.Columns.Add("Kitap Adı", 100, HorizontalAlignment.Center);
                        list_cezaliste.Columns.Add("Üye Adı", 100, HorizontalAlignment.Center);
                        list_cezaliste.Columns.Add("Üye Soyadı", 100, HorizontalAlignment.Center);
                        list_cezaliste.Columns.Add("Ceza Ücreti", 100, HorizontalAlignment.Center);
                        list_cezaliste.Columns.Add("Ödeme Durumu", 120, HorizontalAlignment.Center);

                        for (int i = 0; i < datas.Tables[0].Rows.Count; i++)
                        {
                            str[0] = datas.Tables[0].Rows[i]["tcNo"].ToString();
                            str[1] = datas.Tables[0].Rows[i]["kitapAdi"].ToString();
                            str[2] = datas.Tables[0].Rows[i]["adi"].ToString();
                            str[3] = datas.Tables[0].Rows[i]["soyadi"].ToString();
                            str[4] = datas.Tables[0].Rows[i]["cezaUcreti"].ToString();
                            str[5] = datas.Tables[0].Rows[i]["odemeDurumu"].ToString();
                            item = new ListViewItem(str);
                            list_cezaliste.Items.Add(item);
                        }
                    }
                    connect.Close();
                }
                else
                {
                    MessageBoxEx.EnableGlass = false;
                    MessageBoxEx.Show("Lütfen arama yapılacak bir kriter seçiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_kitapguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                kitapno = Convert.ToInt32(list_kitapliste.SelectedItems[0].SubItems[0].Text);
                kitapGuncelle kitapgun = new kitapGuncelle();
                kitapgun.ShowDialog();
            }
            catch (Exception)
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show("Lütfen tablodan bir kayıt seçiniz!");
            }
        }

        int kitapNo;
        private void btn_kitapsil_Click(object sender, EventArgs e)
        {
            try
            {              
                kitapNo = Convert.ToInt32(list_kitapliste.SelectedItems[0].SubItems[0].Text);
                if (kitapNo.ToString() != "")
                {
                    MessageBoxEx.EnableGlass = false;
                    DialogResult cev;
                    cev = MessageBoxEx.Show("Bu kitabı Silmek istediğinizden Emin Misiniz?", "Kitap Siliniyor", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (cev == DialogResult.Yes)
                    {
                        string sorgu = "delete from kitap where kitapNo=" + kitapNo;
                        connect = new SqlConnection(connected);
                        SqlCommand cmd = new SqlCommand(sorgu, connect);
                        connect.Open();
                        cmd.ExecuteNonQuery();
                        connect.Close();
                        anaForm f1 = (anaForm)Application.OpenForms["anaForm"];
                        f1.Uye_Listesi();
                        f1.kitap_Listesi();
                        f1.odunc_Listesi();
                        f1.yazar_listesi();
                        f1.ceza_Listesi();
                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBoxEx.EnableGlass = false;
                    MessageBoxEx.Show("Lütfen tablodan bir kayıt seçiniz!");
                }
            }
            catch
            {               
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show("Lütfen tablodan bir kayıt seçiniz!");
            }
        }

        private void yazarSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBoxEx.EnableGlass = false;
                DialogResult cev;
                cev = MessageBoxEx.Show("Bu Yazarı Silmek istediğinizden Emin Misiniz?", "Yazar Siliniyor", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (cev == DialogResult.Yes)
                {
                    if (yazarNo.ToString() != "")
                    {
                        yazarNo = Convert.ToInt32(list_yazarliste.SelectedItems[0].SubItems[0].Text);
                        string sorgu = "delete from yazar where yazarNo=" + yazarNo;
                        string sorgu2 = "delete from kitap where yazarNo=" + yazarNo;
                        connect = new SqlConnection(connected);
                        SqlCommand cmd = new SqlCommand(sorgu, connect);
                        SqlCommand cmd2 = new SqlCommand(sorgu2, connect);
                        connect.Open();
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        connect.Close();
                        yazar_listesi();
                    }
                    else
                    {
                        MessageBoxEx.EnableGlass = false;
                        MessageBoxEx.Show("Lütfen tablodan bir kayıt seçiniz!");
                    }
                }
                else
                {

                }
            }
            catch
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show("Lütfen tablodan bir kayıt seçiniz!");
            }
        }

        private void cıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cezaGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                cezaNo = Convert.ToInt32(list_cezaliste.SelectedItems[0].SubItems[6].Text);
                cezaGuncelle cezagun = new cezaGuncelle();
                cezagun.ShowDialog();
            }
            catch
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show("Lütfen tablodan bir kayıt seçiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                kitapno = Convert.ToInt32(list_kitapliste.SelectedItems[0].SubItems[0].Text);
                kitapGuncelle kitapgun = new kitapGuncelle();
                kitapgun.ShowDialog();
            }
            catch (Exception)
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show("Lütfen tablodan bir kayıt seçiniz!");
            }
        }

        private void silToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                kitapNo = Convert.ToInt32(list_kitapliste.SelectedItems[0].SubItems[0].Text);
                if (kitapNo.ToString() != "")
                {
                    MessageBoxEx.EnableGlass = false;
                    DialogResult cev;
                    cev = MessageBoxEx.Show("Bu kitabı Silmek istediğinizden Emin Misiniz?", "kitap Siliniyor", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (cev == DialogResult.Yes)
                    {
                        string sorgu = "delete from kitap where kitapNo=" + kitapNo;
                        connect = new SqlConnection(connected);
                        SqlCommand cmd = new SqlCommand(sorgu, connect);
                        connect.Open();
                        cmd.ExecuteNonQuery();
                        connect.Close();
                        kitap_Listesi();
                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBoxEx.EnableGlass = false;
                    MessageBoxEx.Show("Lütfen tablodan bir kayıt seçiniz!");
                }
            }
            catch
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show("Lütfen tablodan bir kayıt seçiniz!");
            }
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            bizeUlasin ulasin = new bizeUlasin();
            ulasin.Show();
        }

        private void uyeler_Click(object sender, EventArgs e)
        {
            txt_oduncara.Text = "";
        }

        private void buttonItem6_Click(object sender, EventArgs e)
        {
            MessageBoxEx.EnableGlass = false;
            MessageBoxEx.Show("YAZILIM BİLGİLERİ ® \n Yazılım: Kütüphane Takip Otomasyonu \n Sürüm: 1.0 \n Platform: Windows 7 ve üzeri \n 2017 ©", "YAZILIM BİLGİLERİ ®",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void btn_cezaguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                cezaNo = Convert.ToInt32(list_cezaliste.SelectedItems[0].SubItems[6].Text);           
                cezaGuncelle cezagun = new cezaGuncelle();
                cezagun.ShowDialog();
            }
            catch
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show("Lütfen tablodan bir kayıt seçiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_uye_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                TcNo = Convert.ToInt32(listuyeler.SelectedItems[0].SubItems[0].Text);
                uyeGuncelle uyegun = new uyeGuncelle();
                uyegun.Show();
            }
            catch (Exception)
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show("Lütfen tablodan bir kayıt seçiniz!");
            }
        }

        private void btn_oduncguncelle_Click(object sender, EventArgs e)
        {
            oduncGuncelle oduncgun = new oduncGuncelle();
            oduncgun.Show();
        }

        private void oduncguncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                kitapucret = Convert.ToInt32(list_oduncliste.SelectedItems[0].SubItems[11].Text);
                TcNo = Convert.ToInt32(list_oduncliste.SelectedItems[0].SubItems[5].Text);
                uyeadi = list_oduncliste.SelectedItems[0].SubItems[2].Text;
                uyesoyadi = list_oduncliste.SelectedItems[0].SubItems[3].Text;
                kitapAdi = list_oduncliste.SelectedItems[0].SubItems[4].Text;
                oduncNo = Convert.ToInt32(list_oduncliste.SelectedItems[0].SubItems[0].Text);
                kitapno = Convert.ToInt32(list_oduncliste.SelectedItems[0].SubItems[1].Text);
                odunctarihi = list_oduncliste.SelectedItems[0].SubItems[6].Text;
                oduncGuncelle oduncgun = new oduncGuncelle();
                oduncgun.Show();
            }
            catch
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show("Lütfen tablodan bir kayıt seçiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_yazarekle_Click(object sender, EventArgs e)
        {
            yazarEkle yzrekle = new yazarEkle();
            yzrekle.Show();
        }

        public  void ceza_Listesi()
        {
            connect = new SqlConnection(connected);
            string sorgu = "SELECT ceza.cezaNo,kitap.kitapAdi,uye.tcNo,uye.adi,uye.soyadi,ceza.cezaUcreti,ceza.odemeDurumu FROM (ceza INNER JOIN kitap ON ceza.kitapNo = kitap.kitapNo) INNER JOIN uye ON ceza.tcNo = uye.tcNo where ceza.odemeDurumu  IS NULL";
            SqlDataAdapter veriler = new SqlDataAdapter(sorgu, connect);
            DataSet datas = new DataSet();
            ListViewItem item = new ListViewItem();
            string[] str = new string[7];
            connect.Open();
            veriler.Fill(datas);

            if (datas.Tables[0].Rows.Count != 0)
            {
                list_cezaliste.Clear();        
                list_cezaliste.Columns.Add("T.C No", 100, HorizontalAlignment.Center);
                list_cezaliste.Columns.Add("Kitap Adı",100,HorizontalAlignment.Center);                
                list_cezaliste.Columns.Add("Üye Adı", 100, HorizontalAlignment.Center);
                list_cezaliste.Columns.Add("Üye Soyadı", 100, HorizontalAlignment.Center);
                list_cezaliste.Columns.Add("Ceza Ücreti", 100, HorizontalAlignment.Center);
                list_cezaliste.Columns.Add("Ödeme Durumu", 120, HorizontalAlignment.Center);
                list_cezaliste.Columns.Add("Ceza No", 0, HorizontalAlignment.Center);

                for (int i = 0; i < datas.Tables[0].Rows.Count; i++)
                {                 
                    str[0] = datas.Tables[0].Rows[i]["tcNo"].ToString();
                    str[1] = datas.Tables[0].Rows[i]["kitapAdi"].ToString();
                    str[2] = datas.Tables[0].Rows[i]["adi"].ToString();
                    str[3] = datas.Tables[0].Rows[i]["soyadi"].ToString();
                    str[4] = datas.Tables[0].Rows[i]["cezaUcreti"].ToString();
                    str[5] = datas.Tables[0].Rows[i]["odemeDurumu"].ToString();
                    str[6] = datas.Tables[0].Rows[i]["cezaNo"].ToString();
                    item = new ListViewItem(str);
                    list_cezaliste.Items.Add(item);
                }
            }
            connect.Close();
        }
    }
}

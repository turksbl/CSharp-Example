namespace kutuphane_takip_otomasyonu1._0
{
    partial class cezaGuncelle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cezaGuncelle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.masktxt_tcno = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.txt_soyadi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_adi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_kitapAdi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_cezaUcreti = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmb_odemeDurumu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.btn_guncelle = new DevComponents.DotNetBar.ButtonX();
            this.btn_geri = new DevComponents.DotNetBar.ButtonX();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_mesaj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "T.C. No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kitap Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ceza Ücreti:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ödeme Durumu:";
            // 
            // masktxt_tcno
            // 
            // 
            // 
            // 
            this.masktxt_tcno.BackgroundStyle.Class = "TextBoxBorder";
            this.masktxt_tcno.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.masktxt_tcno.ButtonClear.Visible = true;
            this.masktxt_tcno.Enabled = false;
            this.masktxt_tcno.FocusHighlightColor = System.Drawing.Color.LightCyan;
            this.masktxt_tcno.FocusHighlightEnabled = true;
            this.masktxt_tcno.Location = new System.Drawing.Point(129, 29);
            this.masktxt_tcno.Mask = "000";
            this.masktxt_tcno.Name = "masktxt_tcno";
            this.masktxt_tcno.ReadOnly = true;
            this.masktxt_tcno.Size = new System.Drawing.Size(120, 20);
            this.masktxt_tcno.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.masktxt_tcno.TabIndex = 0;
            this.masktxt_tcno.Text = "";
            // 
            // txt_soyadi
            // 
            // 
            // 
            // 
            this.txt_soyadi.Border.Class = "TextBoxBorder";
            this.txt_soyadi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_soyadi.Enabled = false;
            this.txt_soyadi.FocusHighlightColor = System.Drawing.Color.LightCyan;
            this.txt_soyadi.FocusHighlightEnabled = true;
            this.txt_soyadi.Location = new System.Drawing.Point(129, 97);
            this.txt_soyadi.Name = "txt_soyadi";
            this.txt_soyadi.ReadOnly = true;
            this.txt_soyadi.Size = new System.Drawing.Size(120, 20);
            this.txt_soyadi.TabIndex = 2;
            // 
            // txt_adi
            // 
            // 
            // 
            // 
            this.txt_adi.Border.Class = "TextBoxBorder";
            this.txt_adi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_adi.Enabled = false;
            this.txt_adi.FocusHighlightColor = System.Drawing.Color.LightCyan;
            this.txt_adi.FocusHighlightEnabled = true;
            this.txt_adi.Location = new System.Drawing.Point(129, 63);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.ReadOnly = true;
            this.txt_adi.Size = new System.Drawing.Size(120, 20);
            this.txt_adi.TabIndex = 1;
            // 
            // txt_kitapAdi
            // 
            // 
            // 
            // 
            this.txt_kitapAdi.Border.Class = "TextBoxBorder";
            this.txt_kitapAdi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_kitapAdi.Enabled = false;
            this.txt_kitapAdi.FocusHighlightColor = System.Drawing.Color.LightCyan;
            this.txt_kitapAdi.FocusHighlightEnabled = true;
            this.txt_kitapAdi.Location = new System.Drawing.Point(129, 131);
            this.txt_kitapAdi.Name = "txt_kitapAdi";
            this.txt_kitapAdi.ReadOnly = true;
            this.txt_kitapAdi.Size = new System.Drawing.Size(120, 20);
            this.txt_kitapAdi.TabIndex = 3;
            // 
            // txt_cezaUcreti
            // 
            // 
            // 
            // 
            this.txt_cezaUcreti.Border.Class = "TextBoxBorder";
            this.txt_cezaUcreti.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_cezaUcreti.FocusHighlightColor = System.Drawing.Color.LightCyan;
            this.txt_cezaUcreti.FocusHighlightEnabled = true;
            this.txt_cezaUcreti.Location = new System.Drawing.Point(129, 165);
            this.txt_cezaUcreti.Name = "txt_cezaUcreti";
            this.txt_cezaUcreti.Size = new System.Drawing.Size(120, 20);
            this.txt_cezaUcreti.TabIndex = 4;
            // 
            // cmb_odemeDurumu
            // 
            this.cmb_odemeDurumu.DisplayMember = "Text";
            this.cmb_odemeDurumu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_odemeDurumu.FocusHighlightColor = System.Drawing.Color.LightCyan;
            this.cmb_odemeDurumu.FocusHighlightEnabled = true;
            this.cmb_odemeDurumu.FormattingEnabled = true;
            this.cmb_odemeDurumu.ItemHeight = 14;
            this.cmb_odemeDurumu.Items.AddRange(new object[] {
            this.comboItem1});
            this.cmb_odemeDurumu.Location = new System.Drawing.Point(129, 199);
            this.cmb_odemeDurumu.Name = "cmb_odemeDurumu";
            this.cmb_odemeDurumu.Size = new System.Drawing.Size(121, 20);
            this.cmb_odemeDurumu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_odemeDurumu.TabIndex = 5;
            // 
            // comboItem1
            // 
            this.comboItem1.FontName = "Yapıldı";
            this.comboItem1.Text = "Yapıldı";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_guncelle.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_guncelle.Location = new System.Drawing.Point(192, 238);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(87, 36);
            this.btn_guncelle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_guncelle.TabIndex = 6;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_geri.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_geri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_geri.Location = new System.Drawing.Point(12, 238);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(87, 36);
            this.btn_geri.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_geri.TabIndex = 7;
            this.btn_geri.Text = "Geri";
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbl_mesaj
            // 
            this.lbl_mesaj.AutoSize = true;
            this.lbl_mesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_mesaj.ForeColor = System.Drawing.Color.White;
            this.lbl_mesaj.Location = new System.Drawing.Point(12, 9);
            this.lbl_mesaj.Name = "lbl_mesaj";
            this.lbl_mesaj.Size = new System.Drawing.Size(0, 16);
            this.lbl_mesaj.TabIndex = 13;
            // 
            // cezaGuncelle
            // 
            this.AcceptButton = this.btn_guncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_geri;
            this.ClientSize = new System.Drawing.Size(291, 286);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.cmb_odemeDurumu);
            this.Controls.Add(this.masktxt_tcno);
            this.Controls.Add(this.txt_cezaUcreti);
            this.Controls.Add(this.txt_kitapAdi);
            this.Controls.Add(this.txt_soyadi);
            this.Controls.Add(this.txt_adi);
            this.Controls.Add(this.lbl_mesaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "cezaGuncelle";
            this.Text = "Ceza Güncelle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cezaGuncelle_FormClosed);
            this.Load += new System.EventHandler(this.cezaGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv masktxt_tcno;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_soyadi;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_adi;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_kitapAdi;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_cezaUcreti;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_odemeDurumu;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.DotNetBar.ButtonX btn_guncelle;
        private DevComponents.DotNetBar.ButtonX btn_geri;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbl_mesaj;
    }
}
namespace kutuphane_takip_otomasyonu1._0
{
    partial class uyeGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uyeGuncelle));
            this.btn_uye_geri = new DevComponents.DotNetBar.ButtonX();
            this.btn_uye_guncelle = new DevComponents.DotNetBar.ButtonX();
            this.txt_adres = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.masktxt_tcno = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.masktxt_tel = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.txt_eposta = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_soyadi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_adi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_mesaj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_uye_geri
            // 
            this.btn_uye_geri.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_uye_geri.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_uye_geri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_uye_geri.Location = new System.Drawing.Point(10, 337);
            this.btn_uye_geri.Name = "btn_uye_geri";
            this.btn_uye_geri.Size = new System.Drawing.Size(87, 36);
            this.btn_uye_geri.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_uye_geri.TabIndex = 7;
            this.btn_uye_geri.Text = "Geri";
            this.btn_uye_geri.Click += new System.EventHandler(this.btn_uye_geri_Click);
            // 
            // btn_uye_guncelle
            // 
            this.btn_uye_guncelle.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_uye_guncelle.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_uye_guncelle.Location = new System.Drawing.Point(264, 337);
            this.btn_uye_guncelle.Name = "btn_uye_guncelle";
            this.btn_uye_guncelle.Size = new System.Drawing.Size(87, 36);
            this.btn_uye_guncelle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_uye_guncelle.TabIndex = 6;
            this.btn_uye_guncelle.Text = "Güncelle";
            this.btn_uye_guncelle.Click += new System.EventHandler(this.btn_uye_guncelle_Click);
            // 
            // txt_adres
            // 
            // 
            // 
            // 
            this.txt_adres.Border.Class = "TextBoxBorder";
            this.txt_adres.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_adres.FocusHighlightColor = System.Drawing.Color.LightCyan;
            this.txt_adres.FocusHighlightEnabled = true;
            this.txt_adres.Location = new System.Drawing.Point(145, 235);
            this.txt_adres.Multiline = true;
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(160, 80);
            this.txt_adres.TabIndex = 5;
            // 
            // masktxt_tcno
            // 
            // 
            // 
            // 
            this.masktxt_tcno.BackgroundStyle.Class = "TextBoxBorder";
            this.masktxt_tcno.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.masktxt_tcno.ButtonClear.Visible = true;
            this.masktxt_tcno.FocusHighlightColor = System.Drawing.Color.LightCyan;
            this.masktxt_tcno.FocusHighlightEnabled = true;
            this.masktxt_tcno.Location = new System.Drawing.Point(145, 43);
            this.masktxt_tcno.Mask = "000";
            this.masktxt_tcno.Name = "masktxt_tcno";
            this.masktxt_tcno.Size = new System.Drawing.Size(100, 20);
            this.masktxt_tcno.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.masktxt_tcno.TabIndex = 0;
            this.masktxt_tcno.Text = "";
            // 
            // masktxt_tel
            // 
            // 
            // 
            // 
            this.masktxt_tel.BackgroundStyle.Class = "TextBoxBorder";
            this.masktxt_tel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.masktxt_tel.ButtonClear.Visible = true;
            this.masktxt_tel.FocusHighlightColor = System.Drawing.Color.LightCyan;
            this.masktxt_tel.FocusHighlightEnabled = true;
            this.masktxt_tel.Location = new System.Drawing.Point(145, 197);
            this.masktxt_tel.Mask = "(999) 000-0000";
            this.masktxt_tel.Name = "masktxt_tel";
            this.masktxt_tel.Size = new System.Drawing.Size(100, 20);
            this.masktxt_tel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.masktxt_tel.TabIndex = 4;
            this.masktxt_tel.Text = "";
            // 
            // txt_eposta
            // 
            // 
            // 
            // 
            this.txt_eposta.Border.Class = "TextBoxBorder";
            this.txt_eposta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_eposta.FocusHighlightColor = System.Drawing.Color.LightCyan;
            this.txt_eposta.FocusHighlightEnabled = true;
            this.txt_eposta.Location = new System.Drawing.Point(145, 160);
            this.txt_eposta.Name = "txt_eposta";
            this.txt_eposta.Size = new System.Drawing.Size(100, 20);
            this.txt_eposta.TabIndex = 3;
            // 
            // txt_soyadi
            // 
            // 
            // 
            // 
            this.txt_soyadi.Border.Class = "TextBoxBorder";
            this.txt_soyadi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_soyadi.FocusHighlightColor = System.Drawing.Color.LightCyan;
            this.txt_soyadi.FocusHighlightEnabled = true;
            this.txt_soyadi.Location = new System.Drawing.Point(145, 122);
            this.txt_soyadi.Name = "txt_soyadi";
            this.txt_soyadi.Size = new System.Drawing.Size(100, 20);
            this.txt_soyadi.TabIndex = 2;
            // 
            // txt_adi
            // 
            // 
            // 
            // 
            this.txt_adi.Border.Class = "TextBoxBorder";
            this.txt_adi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_adi.FocusHighlightColor = System.Drawing.Color.LightCyan;
            this.txt_adi.FocusHighlightEnabled = true;
            this.txt_adi.Location = new System.Drawing.Point(145, 85);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(100, 20);
            this.txt_adi.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Adres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "E-Posta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "T.C No:";
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
            this.lbl_mesaj.TabIndex = 12;
            // 
            // uyeGuncelle
            // 
            this.AcceptButton = this.btn_uye_guncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_uye_geri;
            this.ClientSize = new System.Drawing.Size(363, 385);
            this.Controls.Add(this.btn_uye_geri);
            this.Controls.Add(this.btn_uye_guncelle);
            this.Controls.Add(this.txt_adres);
            this.Controls.Add(this.masktxt_tcno);
            this.Controls.Add(this.masktxt_tel);
            this.Controls.Add(this.txt_eposta);
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
            this.Name = "uyeGuncelle";
            this.Text = "Üye Güncelle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.uyeGuncelle_FormClosed);
            this.Load += new System.EventHandler(this.uyeGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btn_uye_geri;
        private DevComponents.DotNetBar.ButtonX btn_uye_guncelle;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_adres;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv masktxt_tcno;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv masktxt_tel;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_eposta;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_soyadi;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_adi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbl_mesaj;
    }
}
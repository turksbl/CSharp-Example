namespace kutuphane_takip_otomasyonu1._0
{
    partial class kitapGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitapGuncelle));
            this.btn_geri = new DevComponents.DotNetBar.ButtonX();
            this.btn_guncelle = new DevComponents.DotNetBar.ButtonX();
            this.txt_kitapozeti = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_kitapucreti = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_sayfasayisi = new DevComponents.Editors.IntegerInput();
            this.cmb_turadi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txt_kitapadi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMesaj = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sayfasayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_geri
            // 
            this.btn_geri.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_geri.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_geri.Location = new System.Drawing.Point(12, 337);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(87, 36);
            this.btn_geri.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_geri.TabIndex = 6;
            this.btn_geri.Text = "Geri";
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_guncelle.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_guncelle.Location = new System.Drawing.Point(278, 337);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(87, 36);
            this.btn_guncelle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_guncelle.TabIndex = 5;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // txt_kitapozeti
            // 
            // 
            // 
            // 
            this.txt_kitapozeti.Border.Class = "TextBoxBorder";
            this.txt_kitapozeti.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_kitapozeti.FocusHighlightColor = System.Drawing.Color.LightCyan;
            this.txt_kitapozeti.FocusHighlightEnabled = true;
            this.txt_kitapozeti.Location = new System.Drawing.Point(133, 221);
            this.txt_kitapozeti.Multiline = true;
            this.txt_kitapozeti.Name = "txt_kitapozeti";
            this.txt_kitapozeti.Size = new System.Drawing.Size(160, 80);
            this.txt_kitapozeti.TabIndex = 4;
            // 
            // txt_kitapucreti
            // 
            // 
            // 
            // 
            this.txt_kitapucreti.Border.Class = "TextBoxBorder";
            this.txt_kitapucreti.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_kitapucreti.FocusHighlightColor = System.Drawing.Color.LightCyan;
            this.txt_kitapucreti.FocusHighlightEnabled = true;
            this.txt_kitapucreti.Location = new System.Drawing.Point(133, 178);
            this.txt_kitapucreti.Name = "txt_kitapucreti";
            this.txt_kitapucreti.Size = new System.Drawing.Size(120, 20);
            this.txt_kitapucreti.TabIndex = 3;
            // 
            // txt_sayfasayisi
            // 
            // 
            // 
            // 
            this.txt_sayfasayisi.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txt_sayfasayisi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_sayfasayisi.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txt_sayfasayisi.FocusHighlightColor = System.Drawing.Color.LightCyan;
            this.txt_sayfasayisi.FocusHighlightEnabled = true;
            this.txt_sayfasayisi.Location = new System.Drawing.Point(133, 135);
            this.txt_sayfasayisi.Name = "txt_sayfasayisi";
            this.txt_sayfasayisi.ShowUpDown = true;
            this.txt_sayfasayisi.Size = new System.Drawing.Size(120, 20);
            this.txt_sayfasayisi.TabIndex = 2;
            // 
            // cmb_turadi
            // 
            this.cmb_turadi.DisplayMember = "Text";
            this.cmb_turadi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_turadi.FocusHighlightColor = System.Drawing.Color.LightCyan;
            this.cmb_turadi.FocusHighlightEnabled = true;
            this.cmb_turadi.FormattingEnabled = true;
            this.cmb_turadi.ItemHeight = 14;
            this.cmb_turadi.Location = new System.Drawing.Point(133, 92);
            this.cmb_turadi.Name = "cmb_turadi";
            this.cmb_turadi.Size = new System.Drawing.Size(121, 20);
            this.cmb_turadi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_turadi.TabIndex = 1;
            // 
            // txt_kitapadi
            // 
            // 
            // 
            // 
            this.txt_kitapadi.Border.Class = "TextBoxBorder";
            this.txt_kitapadi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_kitapadi.FocusHighlightColor = System.Drawing.Color.LightCyan;
            this.txt_kitapadi.FocusHighlightEnabled = true;
            this.txt_kitapadi.Location = new System.Drawing.Point(133, 49);
            this.txt_kitapadi.Name = "txt_kitapadi";
            this.txt_kitapadi.Size = new System.Drawing.Size(121, 20);
            this.txt_kitapadi.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kitap Ücreti:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sayfa Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tür Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kitap Adı:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.ForeColor = System.Drawing.Color.White;
            this.lblMesaj.Location = new System.Drawing.Point(12, 9);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 16);
            this.lblMesaj.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Kitap Özeti:";
            // 
            // kitapGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 384);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.txt_kitapozeti);
            this.Controls.Add(this.txt_kitapucreti);
            this.Controls.Add(this.txt_sayfasayisi);
            this.Controls.Add(this.cmb_turadi);
            this.Controls.Add(this.txt_kitapadi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMesaj);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "kitapGuncelle";
            this.Text = "Kitap Güncelle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.kitapGuncelle_FormClosed);
            this.Load += new System.EventHandler(this.kitapGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_sayfasayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btn_geri;
        private DevComponents.DotNetBar.ButtonX btn_guncelle;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_kitapozeti;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_kitapucreti;
        private DevComponents.Editors.IntegerInput txt_sayfasayisi;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_turadi;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_kitapadi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Label label4;
    }
}
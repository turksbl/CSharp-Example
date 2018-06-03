namespace kutuphane_takip_otomasyonu1._0
{
    partial class kitapEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitapEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_kitapadi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmb_turadi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txt_sayfasayisi = new DevComponents.Editors.IntegerInput();
            this.txt_kitapucreti = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_kitapozeti = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_kaydet = new DevComponents.DotNetBar.ButtonX();
            this.btn_geri = new DevComponents.DotNetBar.ButtonX();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMesaj = new System.Windows.Forms.Label();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.comboItem7 = new DevComponents.Editors.ComboItem();
            this.comboItem8 = new DevComponents.Editors.ComboItem();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sayfasayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Kitap Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Tür Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Sayfa Sayısı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Kitap Özeti:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Kitap Ücreti:";
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
            this.txt_kitapadi.Location = new System.Drawing.Point(139, 62);
            this.txt_kitapadi.Name = "txt_kitapadi";
            this.txt_kitapadi.Size = new System.Drawing.Size(121, 20);
            this.txt_kitapadi.TabIndex = 0;
            // 
            // cmb_turadi
            // 
            this.cmb_turadi.DisplayMember = "Text";
            this.cmb_turadi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_turadi.FocusHighlightColor = System.Drawing.Color.LightCyan;
            this.cmb_turadi.FocusHighlightEnabled = true;
            this.cmb_turadi.FormattingEnabled = true;
            this.cmb_turadi.ItemHeight = 14;
            this.cmb_turadi.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3,
            this.comboItem4,
            this.comboItem5,
            this.comboItem6,
            this.comboItem7,
            this.comboItem8});
            this.cmb_turadi.Location = new System.Drawing.Point(139, 104);
            this.cmb_turadi.Name = "cmb_turadi";
            this.cmb_turadi.Size = new System.Drawing.Size(121, 20);
            this.cmb_turadi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_turadi.TabIndex = 2;
            this.cmb_turadi.Text = "--Seçiniz--";
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
            this.txt_sayfasayisi.Location = new System.Drawing.Point(139, 146);
            this.txt_sayfasayisi.Name = "txt_sayfasayisi";
            this.txt_sayfasayisi.ShowUpDown = true;
            this.txt_sayfasayisi.Size = new System.Drawing.Size(120, 20);
            this.txt_sayfasayisi.TabIndex = 3;
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
            this.txt_kitapucreti.Location = new System.Drawing.Point(139, 188);
            this.txt_kitapucreti.Name = "txt_kitapucreti";
            this.txt_kitapucreti.Size = new System.Drawing.Size(120, 20);
            this.txt_kitapucreti.TabIndex = 4;
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
            this.txt_kitapozeti.Location = new System.Drawing.Point(139, 230);
            this.txt_kitapozeti.Multiline = true;
            this.txt_kitapozeti.Name = "txt_kitapozeti";
            this.txt_kitapozeti.Size = new System.Drawing.Size(160, 80);
            this.txt_kitapozeti.TabIndex = 5;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_kaydet.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_kaydet.Location = new System.Drawing.Point(287, 356);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(87, 36);
            this.btn_kaydet.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_kaydet.TabIndex = 6;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_geri.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_geri.Location = new System.Drawing.Point(12, 356);
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
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.ForeColor = System.Drawing.Color.White;
            this.lblMesaj.Location = new System.Drawing.Point(12, 9);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 16);
            this.lblMesaj.TabIndex = 7;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Hikâye";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Roman";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "Anı";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "Gezi";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "Masal";
            // 
            // comboItem6
            // 
            this.comboItem6.Text = "Dram";
            // 
            // comboItem7
            // 
            this.comboItem7.Text = "Mektup";
            // 
            // comboItem8
            // 
            this.comboItem8.Text = "Günlük";
            // 
            // kitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 407);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.txt_kitapozeti);
            this.Controls.Add(this.txt_kitapucreti);
            this.Controls.Add(this.txt_sayfasayisi);
            this.Controls.Add(this.cmb_turadi);
            this.Controls.Add(this.txt_kitapadi);
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
            this.Name = "kitapEkle";
            this.Text = "Kitap Ekle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.kitapEkle_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.txt_sayfasayisi)).EndInit();
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
        private DevComponents.DotNetBar.Controls.TextBoxX txt_kitapadi;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_turadi;
        private DevComponents.Editors.IntegerInput txt_sayfasayisi;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_kitapucreti;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_kitapozeti;
        private DevComponents.DotNetBar.ButtonX btn_kaydet;
        private DevComponents.DotNetBar.ButtonX btn_geri;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblMesaj;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.Editors.ComboItem comboItem6;
        private DevComponents.Editors.ComboItem comboItem7;
        private DevComponents.Editors.ComboItem comboItem8;
    }
}
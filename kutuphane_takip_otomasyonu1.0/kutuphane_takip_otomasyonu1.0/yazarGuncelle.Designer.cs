namespace kutuphane_takip_otomasyonu1._0
{
    partial class yazarGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yazarGuncelle));
            this.lbl_mesaj = new System.Windows.Forms.Label();
            this.btn_geri = new DevComponents.DotNetBar.ButtonX();
            this.btn_guncelle = new DevComponents.DotNetBar.ButtonX();
            this.txt_hayatozeti = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.date_dogumtarihi = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txt_yazarsoyadi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_yazaradi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.date_dogumtarihi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_mesaj
            // 
            this.lbl_mesaj.AutoSize = true;
            this.lbl_mesaj.Location = new System.Drawing.Point(12, 9);
            this.lbl_mesaj.Name = "lbl_mesaj";
            this.lbl_mesaj.Size = new System.Drawing.Size(0, 13);
            this.lbl_mesaj.TabIndex = 19;
            // 
            // btn_geri
            // 
            this.btn_geri.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_geri.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_geri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_geri.Location = new System.Drawing.Point(12, 260);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(87, 36);
            this.btn_geri.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_geri.TabIndex = 5;
            this.btn_geri.Text = "Geri";
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_guncelle.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_guncelle.Location = new System.Drawing.Point(279, 260);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(87, 36);
            this.btn_guncelle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_guncelle.TabIndex = 4;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // txt_hayatozeti
            // 
            // 
            // 
            // 
            this.txt_hayatozeti.Border.Class = "TextBoxBorder";
            this.txt_hayatozeti.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_hayatozeti.FocusHighlightColor = System.Drawing.Color.LightCyan;
            this.txt_hayatozeti.FocusHighlightEnabled = true;
            this.txt_hayatozeti.Location = new System.Drawing.Point(166, 166);
            this.txt_hayatozeti.Multiline = true;
            this.txt_hayatozeti.Name = "txt_hayatozeti";
            this.txt_hayatozeti.Size = new System.Drawing.Size(160, 80);
            this.txt_hayatozeti.TabIndex = 3;
            // 
            // date_dogumtarihi
            // 
            // 
            // 
            // 
            this.date_dogumtarihi.BackgroundStyle.Class = "DateTimeInputBackground";
            this.date_dogumtarihi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_dogumtarihi.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.date_dogumtarihi.ButtonDropDown.Visible = true;
            this.date_dogumtarihi.FocusHighlightColor = System.Drawing.Color.LightCyan;
            this.date_dogumtarihi.FocusHighlightEnabled = true;
            this.date_dogumtarihi.Location = new System.Drawing.Point(166, 120);
            // 
            // 
            // 
            this.date_dogumtarihi.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.date_dogumtarihi.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.date_dogumtarihi.MonthCalendar.BackgroundStyle.Class = "";
            this.date_dogumtarihi.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_dogumtarihi.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.date_dogumtarihi.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.date_dogumtarihi.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.date_dogumtarihi.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.date_dogumtarihi.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.date_dogumtarihi.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.date_dogumtarihi.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.date_dogumtarihi.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.date_dogumtarihi.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_dogumtarihi.MonthCalendar.DisplayMonth = new System.DateTime(2017, 5, 1, 0, 0, 0, 0);
            this.date_dogumtarihi.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.date_dogumtarihi.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.date_dogumtarihi.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.date_dogumtarihi.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.date_dogumtarihi.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.date_dogumtarihi.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.date_dogumtarihi.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.date_dogumtarihi.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_dogumtarihi.MonthCalendar.TodayButtonVisible = true;
            this.date_dogumtarihi.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.date_dogumtarihi.Name = "date_dogumtarihi";
            this.date_dogumtarihi.Size = new System.Drawing.Size(100, 20);
            this.date_dogumtarihi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.date_dogumtarihi.TabIndex = 2;
            // 
            // txt_yazarsoyadi
            // 
            // 
            // 
            // 
            this.txt_yazarsoyadi.Border.Class = "TextBoxBorder";
            this.txt_yazarsoyadi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_yazarsoyadi.FocusHighlightColor = System.Drawing.Color.LightCyan;
            this.txt_yazarsoyadi.FocusHighlightEnabled = true;
            this.txt_yazarsoyadi.Location = new System.Drawing.Point(166, 81);
            this.txt_yazarsoyadi.Name = "txt_yazarsoyadi";
            this.txt_yazarsoyadi.Size = new System.Drawing.Size(100, 20);
            this.txt_yazarsoyadi.TabIndex = 1;
            // 
            // txt_yazaradi
            // 
            // 
            // 
            // 
            this.txt_yazaradi.Border.Class = "TextBoxBorder";
            this.txt_yazaradi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_yazaradi.FocusHighlightColor = System.Drawing.Color.LightCyan;
            this.txt_yazaradi.FocusHighlightEnabled = true;
            this.txt_yazaradi.Location = new System.Drawing.Point(166, 42);
            this.txt_yazaradi.Name = "txt_yazaradi";
            this.txt_yazaradi.Size = new System.Drawing.Size(100, 20);
            this.txt_yazaradi.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hayat Özeti:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Doğum Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Yazar Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Yazar Adı:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // yazarGuncelle
            // 
            this.AcceptButton = this.btn_guncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_geri;
            this.ClientSize = new System.Drawing.Size(378, 305);
            this.Controls.Add(this.lbl_mesaj);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.txt_hayatozeti);
            this.Controls.Add(this.date_dogumtarihi);
            this.Controls.Add(this.txt_yazarsoyadi);
            this.Controls.Add(this.txt_yazaradi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "yazarGuncelle";
            this.Text = "Yazar Güncelle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.yazarGuncelle_FormClosed);
            this.Load += new System.EventHandler(this.yazarGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.date_dogumtarihi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_mesaj;
        private DevComponents.DotNetBar.ButtonX btn_geri;
        private DevComponents.DotNetBar.ButtonX btn_guncelle;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_hayatozeti;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput date_dogumtarihi;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_yazarsoyadi;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_yazaradi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}
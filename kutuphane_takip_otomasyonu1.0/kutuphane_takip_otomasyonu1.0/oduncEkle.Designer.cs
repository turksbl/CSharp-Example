namespace kutuphane_takip_otomasyonu1._0
{
    partial class oduncEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oduncEkle));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.list_kitap_listesi = new System.Windows.Forms.ListView();
            this.date_sonteslim = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.date_odunctarihi = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txt_soyad = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_ad = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_tcno = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.list_oduncAlinanKitaplar = new System.Windows.Forms.ListView();
            this.groupPanel15 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_kitapara = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem15 = new DevComponents.Editors.ComboItem();
            this.txt_kitapara = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_sonteslim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_odunctarihi)).BeginInit();
            this.groupPanel2.SuspendLayout();
            this.groupPanel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.list_kitap_listesi);
            this.groupPanel1.Location = new System.Drawing.Point(3, 162);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(828, 220);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.Class = "";
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.Class = "";
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.Class = "";
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 2;
            this.groupPanel1.Text = "Kitap Listesi";
            // 
            // list_kitap_listesi
            // 
            this.list_kitap_listesi.BackColor = System.Drawing.Color.White;
            this.list_kitap_listesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_kitap_listesi.FullRowSelect = true;
            this.list_kitap_listesi.Location = new System.Drawing.Point(0, 0);
            this.list_kitap_listesi.Name = "list_kitap_listesi";
            this.list_kitap_listesi.Size = new System.Drawing.Size(822, 199);
            this.list_kitap_listesi.TabIndex = 0;
            this.list_kitap_listesi.UseCompatibleStateImageBehavior = false;
            this.list_kitap_listesi.View = System.Windows.Forms.View.Details;
            this.list_kitap_listesi.DoubleClick += new System.EventHandler(this.list_kitap_listesi_DoubleClick);
            // 
            // date_sonteslim
            // 
            // 
            // 
            // 
            this.date_sonteslim.BackgroundStyle.Class = "DateTimeInputBackground";
            this.date_sonteslim.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_sonteslim.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.date_sonteslim.ButtonDropDown.Visible = true;
            this.date_sonteslim.Enabled = false;
            this.date_sonteslim.FocusHighlightColor = System.Drawing.Color.LightCyan;
            this.date_sonteslim.FocusHighlightEnabled = true;
            this.date_sonteslim.Location = new System.Drawing.Point(411, 55);
            // 
            // 
            // 
            this.date_sonteslim.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.date_sonteslim.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.date_sonteslim.MonthCalendar.BackgroundStyle.Class = "";
            this.date_sonteslim.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_sonteslim.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.date_sonteslim.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.date_sonteslim.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.date_sonteslim.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.date_sonteslim.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.date_sonteslim.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.date_sonteslim.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.date_sonteslim.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.date_sonteslim.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_sonteslim.MonthCalendar.DisplayMonth = new System.DateTime(2017, 5, 1, 0, 0, 0, 0);
            this.date_sonteslim.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.date_sonteslim.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.date_sonteslim.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.date_sonteslim.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.date_sonteslim.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.date_sonteslim.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.date_sonteslim.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.date_sonteslim.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_sonteslim.MonthCalendar.TodayButtonVisible = true;
            this.date_sonteslim.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.date_sonteslim.Name = "date_sonteslim";
            this.date_sonteslim.Size = new System.Drawing.Size(100, 20);
            this.date_sonteslim.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.date_sonteslim.TabIndex = 1;
            // 
            // date_odunctarihi
            // 
            // 
            // 
            // 
            this.date_odunctarihi.BackgroundStyle.Class = "DateTimeInputBackground";
            this.date_odunctarihi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_odunctarihi.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.date_odunctarihi.ButtonDropDown.Visible = true;
            this.date_odunctarihi.Enabled = false;
            this.date_odunctarihi.FocusHighlightColor = System.Drawing.Color.LightCyan;
            this.date_odunctarihi.FocusHighlightEnabled = true;
            this.date_odunctarihi.Location = new System.Drawing.Point(411, 23);
            // 
            // 
            // 
            this.date_odunctarihi.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.date_odunctarihi.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.date_odunctarihi.MonthCalendar.BackgroundStyle.Class = "";
            this.date_odunctarihi.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_odunctarihi.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.date_odunctarihi.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.date_odunctarihi.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.date_odunctarihi.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.date_odunctarihi.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.date_odunctarihi.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.date_odunctarihi.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.date_odunctarihi.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.date_odunctarihi.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_odunctarihi.MonthCalendar.DisplayMonth = new System.DateTime(2017, 5, 1, 0, 0, 0, 0);
            this.date_odunctarihi.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.date_odunctarihi.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.date_odunctarihi.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.date_odunctarihi.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.date_odunctarihi.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.date_odunctarihi.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.date_odunctarihi.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.date_odunctarihi.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date_odunctarihi.MonthCalendar.TodayButtonVisible = true;
            this.date_odunctarihi.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.date_odunctarihi.Name = "date_odunctarihi";
            this.date_odunctarihi.Size = new System.Drawing.Size(100, 20);
            this.date_odunctarihi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.date_odunctarihi.TabIndex = 0;
            // 
            // txt_soyad
            // 
            // 
            // 
            // 
            this.txt_soyad.Border.Class = "TextBoxBorder";
            this.txt_soyad.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_soyad.Location = new System.Drawing.Point(134, 81);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.ReadOnly = true;
            this.txt_soyad.Size = new System.Drawing.Size(100, 20);
            this.txt_soyad.TabIndex = 13;
            // 
            // txt_ad
            // 
            // 
            // 
            // 
            this.txt_ad.Border.Class = "TextBoxBorder";
            this.txt_ad.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_ad.Location = new System.Drawing.Point(134, 52);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.ReadOnly = true;
            this.txt_ad.Size = new System.Drawing.Size(100, 20);
            this.txt_ad.TabIndex = 14;
            // 
            // txt_tcno
            // 
            // 
            // 
            // 
            this.txt_tcno.BackgroundStyle.Class = "TextBoxBorder";
            this.txt_tcno.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_tcno.ButtonClear.Visible = true;
            this.txt_tcno.Enabled = false;
            this.txt_tcno.Location = new System.Drawing.Point(134, 23);
            this.txt_tcno.Mask = "000";
            this.txt_tcno.Name = "txt_tcno";
            this.txt_tcno.ReadOnly = true;
            this.txt_tcno.Size = new System.Drawing.Size(100, 20);
            this.txt_tcno.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txt_tcno.TabIndex = 12;
            this.txt_tcno.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Son Teslim Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ödünç Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "T.C No:";
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.list_oduncAlinanKitaplar);
            this.groupPanel2.Location = new System.Drawing.Point(3, 380);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(828, 226);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.Class = "";
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.Class = "";
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.Class = "";
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 19;
            this.groupPanel2.Text = "Ödünç Alınan Kitaplar ";
            // 
            // list_oduncAlinanKitaplar
            // 
            this.list_oduncAlinanKitaplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_oduncAlinanKitaplar.FullRowSelect = true;
            this.list_oduncAlinanKitaplar.Location = new System.Drawing.Point(0, 0);
            this.list_oduncAlinanKitaplar.Name = "list_oduncAlinanKitaplar";
            this.list_oduncAlinanKitaplar.Size = new System.Drawing.Size(822, 205);
            this.list_oduncAlinanKitaplar.TabIndex = 0;
            this.list_oduncAlinanKitaplar.UseCompatibleStateImageBehavior = false;
            this.list_oduncAlinanKitaplar.View = System.Windows.Forms.View.Details;
            this.list_oduncAlinanKitaplar.DoubleClick += new System.EventHandler(this.list_oduncAlinanKitaplar_DoubleClick);
            // 
            // groupPanel15
            // 
            this.groupPanel15.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel15.CanvasColor = System.Drawing.Color.Transparent;
            this.groupPanel15.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel15.Controls.Add(this.label6);
            this.groupPanel15.Controls.Add(this.cmb_kitapara);
            this.groupPanel15.Controls.Add(this.txt_kitapara);
            this.groupPanel15.Location = new System.Drawing.Point(3, 107);
            this.groupPanel15.Name = "groupPanel15";
            this.groupPanel15.Size = new System.Drawing.Size(828, 50);
            // 
            // 
            // 
            this.groupPanel15.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel15.Style.BackColorGradientAngle = 90;
            this.groupPanel15.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel15.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel15.Style.BorderBottomWidth = 1;
            this.groupPanel15.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel15.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel15.Style.BorderLeftWidth = 1;
            this.groupPanel15.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel15.Style.BorderRightWidth = 1;
            this.groupPanel15.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel15.Style.BorderTopWidth = 1;
            this.groupPanel15.Style.Class = "";
            this.groupPanel15.Style.CornerDiameter = 4;
            this.groupPanel15.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel15.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel15.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel15.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel15.StyleMouseDown.Class = "";
            this.groupPanel15.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel15.StyleMouseOver.Class = "";
            this.groupPanel15.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel15.TabIndex = 20;
            this.groupPanel15.Text = "Kitap Ara";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(273, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ara";
            // 
            // cmb_kitapara
            // 
            this.cmb_kitapara.DisplayMember = "Text";
            this.cmb_kitapara.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_kitapara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_kitapara.FocusHighlightEnabled = true;
            this.cmb_kitapara.FormattingEnabled = true;
            this.cmb_kitapara.ItemHeight = 14;
            this.cmb_kitapara.Items.AddRange(new object[] {
            this.comboItem3,
            this.comboItem4,
            this.comboItem15});
            this.cmb_kitapara.Location = new System.Drawing.Point(302, 6);
            this.cmb_kitapara.Name = "cmb_kitapara";
            this.cmb_kitapara.Size = new System.Drawing.Size(121, 20);
            this.cmb_kitapara.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_kitapara.TabIndex = 3;
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "arama yapınız!";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "Kitap Adına Göre";
            // 
            // comboItem15
            // 
            this.comboItem15.Text = "Yazar Adına Göre";
            // 
            // txt_kitapara
            // 
            // 
            // 
            // 
            this.txt_kitapara.Border.Class = "TextBoxBorder";
            this.txt_kitapara.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_kitapara.FocusHighlightColor = System.Drawing.Color.LightCyan;
            this.txt_kitapara.FocusHighlightEnabled = true;
            this.txt_kitapara.Location = new System.Drawing.Point(429, 6);
            this.txt_kitapara.Name = "txt_kitapara";
            this.txt_kitapara.Size = new System.Drawing.Size(100, 20);
            this.txt_kitapara.TabIndex = 2;
            this.txt_kitapara.TextChanged += new System.EventHandler(this.txt_ara_TextChanged);
            // 
            // oduncEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 613);
            this.Controls.Add(this.groupPanel15);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.date_sonteslim);
            this.Controls.Add(this.date_odunctarihi);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_tcno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "oduncEkle";
            this.Text = "Ödünç Ekle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.oduncEkle_FormClosed);
            this.Load += new System.EventHandler(this.oduncEkle_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.date_sonteslim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_odunctarihi)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel15.ResumeLayout(false);
            this.groupPanel15.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.ListView list_kitap_listesi;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput date_sonteslim;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput date_odunctarihi;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_soyad;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_ad;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv txt_tcno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private System.Windows.Forms.ListView list_oduncAlinanKitaplar;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel15;
        private System.Windows.Forms.Label label6;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_kitapara;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem15;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_kitapara;
    }
}
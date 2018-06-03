namespace kutuphane_takip_otomasyonu1._0
{
    partial class sifreGonder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sifreGonder));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_gonder = new DevComponents.DotNetBar.ButtonX();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email Adresinizi giriniz:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // btn_gonder
            // 
            this.btn_gonder.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_gonder.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_gonder.Location = new System.Drawing.Point(125, 38);
            this.btn_gonder.Name = "btn_gonder";
            this.btn_gonder.Size = new System.Drawing.Size(192, 23);
            this.btn_gonder.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_gonder.TabIndex = 5;
            this.btn_gonder.Text = "Gönder";
            this.btn_gonder.Click += new System.EventHandler(this.btn_gonder_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 4;
            // 
            // sifreGonder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 71);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_gonder);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "sifreGonder";
            this.Text = "Şifremi Unuttum";
            this.Load += new System.EventHandler(this.sifreGonder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX btn_gonder;
        private System.Windows.Forms.TextBox textBox1;
    }
}
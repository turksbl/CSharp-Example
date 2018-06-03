namespace kutuphane_takip_otomasyonu1._0
{
    partial class bizeUlasin
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
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Image = global::kutuphane_takip_otomasyonu1._0.Properties.Resources.Active_Instagram_3_icon;
            this.buttonX3.Location = new System.Drawing.Point(121, 13);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12);
            this.buttonX3.Size = new System.Drawing.Size(49, 47);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.buttonX3.TabIndex = 0;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Image = global::kutuphane_takip_otomasyonu1._0.Properties.Resources.twitter_icon;
            this.buttonX2.Location = new System.Drawing.Point(69, 13);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12);
            this.buttonX2.Size = new System.Drawing.Size(46, 47);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.buttonX2.TabIndex = 0;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::kutuphane_takip_otomasyonu1._0.Properties.Resources.social_facebook_box_blue_icon;
            this.buttonX1.Location = new System.Drawing.Point(17, 13);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12);
            this.buttonX1.Size = new System.Drawing.Size(46, 47);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.buttonX1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(69, 67);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(35, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Kapat";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // bizeUlasin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 133);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.buttonX3);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.buttonX1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "bizeUlasin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bizeUlasin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.bizeUlasin_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
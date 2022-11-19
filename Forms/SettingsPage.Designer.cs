namespace WebenionBrowser.Forms
{
    partial class SettingsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsPage));
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbTarayiciMotoru = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbEmail = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbAramaMotoru = new System.Windows.Forms.PictureBox();
            this.pbMail = new System.Windows.Forms.PictureBox();
            this.formBorder = new Bunifu.UI.WinForms.BunifuPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFormClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuShadowPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAramaMotoru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMail)).BeginInit();
            this.formBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.BorderRadius = 1;
            this.bunifuShadowPanel1.BorderThickness = 1;
            this.bunifuShadowPanel1.Controls.Add(this.groupBox2);
            this.bunifuShadowPanel1.Controls.Add(this.groupBox1);
            this.bunifuShadowPanel1.Controls.Add(this.formBorder);
            this.bunifuShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowDepth = 5;
            this.bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(630, 261);
            this.bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbTarayiciMotoru);
            this.groupBox2.Controls.Add(this.pbAramaMotoru);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(327, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 100);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // cmbTarayiciMotoru
            // 
            this.cmbTarayiciMotoru.FormattingEnabled = true;
            this.cmbTarayiciMotoru.Items.AddRange(new object[] {
            "Google",
            "DuckDuckGo",
            "Bing",
            "Yandex"});
            this.cmbTarayiciMotoru.Location = new System.Drawing.Point(44, 60);
            this.cmbTarayiciMotoru.Name = "cmbTarayiciMotoru";
            this.cmbTarayiciMotoru.Size = new System.Drawing.Size(171, 24);
            this.cmbTarayiciMotoru.TabIndex = 9;
            this.cmbTarayiciMotoru.SelectedIndexChanged += new System.EventHandler(this.cmbTarayiciMotoru_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 33);
            this.label5.TabIndex = 18;
            this.label5.Text = "Varsayılan Tarayıcı Motoru";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbEmail);
            this.groupBox1.Controls.Add(this.pbMail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(44, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 100);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // cmbEmail
            // 
            this.cmbEmail.FormattingEnabled = true;
            this.cmbEmail.Items.AddRange(new object[] {
            "Gmail",
            "Outlook"});
            this.cmbEmail.Location = new System.Drawing.Point(42, 56);
            this.cmbEmail.Name = "cmbEmail";
            this.cmbEmail.Size = new System.Drawing.Size(171, 24);
            this.cmbEmail.TabIndex = 8;
            this.cmbEmail.SelectedIndexChanged += new System.EventHandler(this.cmbEmail_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 33);
            this.label4.TabIndex = 18;
            this.label4.Text = "Varsayılan Email";
            // 
            // pbAramaMotoru
            // 
            this.pbAramaMotoru.Location = new System.Drawing.Point(12, 60);
            this.pbAramaMotoru.Name = "pbAramaMotoru";
            this.pbAramaMotoru.Size = new System.Drawing.Size(26, 24);
            this.pbAramaMotoru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAramaMotoru.TabIndex = 17;
            this.pbAramaMotoru.TabStop = false;
            // 
            // pbMail
            // 
            this.pbMail.Location = new System.Drawing.Point(10, 56);
            this.pbMail.Name = "pbMail";
            this.pbMail.Size = new System.Drawing.Size(26, 24);
            this.pbMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMail.TabIndex = 17;
            this.pbMail.TabStop = false;
            // 
            // formBorder
            // 
            this.formBorder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.formBorder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(136)))), ((int)(((byte)(150)))));
            this.formBorder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("formBorder.BackgroundImage")));
            this.formBorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.formBorder.BorderColor = System.Drawing.Color.Transparent;
            this.formBorder.BorderRadius = 3;
            this.formBorder.BorderThickness = 1;
            this.formBorder.Controls.Add(this.pictureBox1);
            this.formBorder.Controls.Add(this.panel1);
            this.formBorder.Controls.Add(this.label1);
            this.formBorder.Location = new System.Drawing.Point(4, 7);
            this.formBorder.Name = "formBorder";
            this.formBorder.ShowBorders = true;
            this.formBorder.Size = new System.Drawing.Size(621, 58);
            this.formBorder.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WebenionBrowser.Properties.Resources.yedekLogo;
            this.pictureBox1.Location = new System.Drawing.Point(16, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnFormClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(406, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 58);
            this.panel1.TabIndex = 2;
            // 
            // btnFormClose
            // 
            this.btnFormClose.ActiveImage = null;
            this.btnFormClose.AllowAnimations = true;
            this.btnFormClose.AllowBuffering = false;
            this.btnFormClose.AllowToggling = false;
            this.btnFormClose.AllowZooming = true;
            this.btnFormClose.AllowZoomingOnFocus = false;
            this.btnFormClose.BackColor = System.Drawing.Color.Transparent;
            this.btnFormClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFormClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnFormClose.ErrorImage")));
            this.btnFormClose.FadeWhenInactive = false;
            this.btnFormClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnFormClose.Image = global::WebenionBrowser.Properties.Resources.stopIco;
            this.btnFormClose.ImageActive = null;
            this.btnFormClose.ImageLocation = null;
            this.btnFormClose.ImageMargin = 20;
            this.btnFormClose.ImageSize = new System.Drawing.Size(51, 46);
            this.btnFormClose.ImageZoomSize = new System.Drawing.Size(71, 66);
            this.btnFormClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnFormClose.InitialImage")));
            this.btnFormClose.Location = new System.Drawing.Point(133, 12);
            this.btnFormClose.Name = "btnFormClose";
            this.btnFormClose.Rotation = 0;
            this.btnFormClose.ShowActiveImage = true;
            this.btnFormClose.ShowCursorChanges = true;
            this.btnFormClose.ShowImageBorders = true;
            this.btnFormClose.ShowSizeMarkers = false;
            this.btnFormClose.Size = new System.Drawing.Size(71, 66);
            this.btnFormClose.TabIndex = 1;
            this.btnFormClose.ToolTipText = "";
            this.btnFormClose.WaitOnLoad = false;
            this.btnFormClose.Zoom = 20;
            this.btnFormClose.ZoomSpeed = 10;
            this.btnFormClose.Click += new System.EventHandler(this.btnFormClose_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(136)))), ((int)(((byte)(150)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(68, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ayarlar";
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 261);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsPage";
            this.Load += new System.EventHandler(this.SettingsPage_Load);
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAramaMotoru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMail)).EndInit();
            this.formBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private Bunifu.UI.WinForms.BunifuPanel formBorder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuImageButton btnFormClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTarayiciMotoru;
        private System.Windows.Forms.ComboBox cmbEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbAramaMotoru;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbMail;
        private System.Windows.Forms.Label label4;
    }
}
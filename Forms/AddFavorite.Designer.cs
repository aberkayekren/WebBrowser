namespace WebenionBrowser.Forms
{
    partial class AddFavorite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFavorite));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFormKapat = new System.Windows.Forms.Label();
            this.txtSiteUrl = new System.Windows.Forms.TextBox();
            this.txtSiteAdi = new System.Windows.Forms.TextBox();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.btnEkle = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(43, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Site Adı";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(43, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Site Url";
            // 
            // btnFormKapat
            // 
            this.btnFormKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFormKapat.Location = new System.Drawing.Point(640, 10);
            this.btnFormKapat.Name = "btnFormKapat";
            this.btnFormKapat.Size = new System.Drawing.Size(119, 76);
            this.btnFormKapat.TabIndex = 5;
            this.btnFormKapat.Text = "X";
            this.btnFormKapat.Click += new System.EventHandler(this.btnFormKapat_Click);
            // 
            // txtSiteUrl
            // 
            this.txtSiteUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.txtSiteUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSiteUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSiteUrl.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSiteUrl.Location = new System.Drawing.Point(45, 205);
            this.txtSiteUrl.Multiline = true;
            this.txtSiteUrl.Name = "txtSiteUrl";
            this.txtSiteUrl.Size = new System.Drawing.Size(541, 33);
            this.txtSiteUrl.TabIndex = 6;
            this.txtSiteUrl.WordWrap = false;
            // 
            // txtSiteAdi
            // 
            this.txtSiteAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.txtSiteAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSiteAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSiteAdi.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSiteAdi.Location = new System.Drawing.Point(46, 99);
            this.txtSiteAdi.Multiline = true;
            this.txtSiteAdi.Name = "txtSiteAdi";
            this.txtSiteAdi.Size = new System.Drawing.Size(541, 33);
            this.txtSiteAdi.TabIndex = 7;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator2.BackgroundImage")));
            this.bunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(45, 139);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator2.Size = new System.Drawing.Size(544, 10);
            this.bunifuSeparator2.TabIndex = 4;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(46, 245);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(544, 10);
            this.bunifuSeparator1.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.AllowAnimations = true;
            this.btnEkle.AllowMouseEffects = true;
            this.btnEkle.AllowToggling = false;
            this.btnEkle.AnimationSpeed = 200;
            this.btnEkle.AutoGenerateColors = false;
            this.btnEkle.AutoRoundBorders = false;
            this.btnEkle.AutoSizeLeftIcon = true;
            this.btnEkle.AutoSizeRightIcon = true;
            this.btnEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnEkle.BackColor1 = System.Drawing.Color.Silver;
            this.btnEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEkle.BackgroundImage")));
            this.btnEkle.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnEkle.ButtonText = "Ekle";
            this.btnEkle.ButtonTextMarginLeft = 0;
            this.btnEkle.ColorContrastOnClick = 45;
            this.btnEkle.ColorContrastOnHover = 45;
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnEkle.CustomizableEdges = borderEdges1;
            this.btnEkle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEkle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEkle.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEkle.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEkle.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnEkle.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnEkle.IconMarginLeft = 11;
            this.btnEkle.IconPadding = 10;
            this.btnEkle.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnEkle.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnEkle.IconSize = 25;
            this.btnEkle.IdleBorderColor = System.Drawing.Color.Silver;
            this.btnEkle.IdleBorderRadius = 1;
            this.btnEkle.IdleBorderThickness = 1;
            this.btnEkle.IdleFillColor = System.Drawing.Color.Silver;
            this.btnEkle.IdleIconLeftImage = null;
            this.btnEkle.IdleIconRightImage = null;
            this.btnEkle.IndicateFocus = false;
            this.btnEkle.Location = new System.Drawing.Point(413, 275);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEkle.OnDisabledState.BorderRadius = 1;
            this.btnEkle.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnEkle.OnDisabledState.BorderThickness = 1;
            this.btnEkle.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEkle.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEkle.OnDisabledState.IconLeftImage = null;
            this.btnEkle.OnDisabledState.IconRightImage = null;
            this.btnEkle.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnEkle.onHoverState.BorderRadius = 1;
            this.btnEkle.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnEkle.onHoverState.BorderThickness = 1;
            this.btnEkle.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnEkle.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnEkle.onHoverState.IconLeftImage = null;
            this.btnEkle.onHoverState.IconRightImage = null;
            this.btnEkle.OnIdleState.BorderColor = System.Drawing.Color.Silver;
            this.btnEkle.OnIdleState.BorderRadius = 1;
            this.btnEkle.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnEkle.OnIdleState.BorderThickness = 1;
            this.btnEkle.OnIdleState.FillColor = System.Drawing.Color.Silver;
            this.btnEkle.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnEkle.OnIdleState.IconLeftImage = null;
            this.btnEkle.OnIdleState.IconRightImage = null;
            this.btnEkle.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnEkle.OnPressedState.BorderRadius = 1;
            this.btnEkle.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnEkle.OnPressedState.BorderThickness = 1;
            this.btnEkle.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnEkle.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnEkle.OnPressedState.IconLeftImage = null;
            this.btnEkle.OnPressedState.IconRightImage = null;
            this.btnEkle.Size = new System.Drawing.Size(176, 57);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEkle.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEkle.TextMarginLeft = 0;
            this.btnEkle.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnEkle.UseDefaultRadiusAndThickness = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // AddFavorite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(701, 385);
            this.Controls.Add(this.txtSiteAdi);
            this.Controls.Add(this.txtSiteUrl);
            this.Controls.Add(this.btnFormKapat);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddFavorite";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddFavorite";
            this.Load += new System.EventHandler(this.AddFavorite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label btnFormKapat;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSiteAdi;
        private System.Windows.Forms.TextBox txtSiteUrl;
    }
}
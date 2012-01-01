namespace What_The_Hex
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblHex = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.grpHtml = new System.Windows.Forms.GroupBox();
            this.grpRgb = new System.Windows.Forms.GroupBox();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.picScreenshot = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpPreview = new System.Windows.Forms.GroupBox();
            this.pnlColourPreview = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpHtml.SuspendLayout();
            this.grpRgb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picScreenshot)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHex
            // 
            this.lblHex.AutoSize = true;
            this.lblHex.Location = new System.Drawing.Point(6, 16);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(26, 13);
            this.lblHex.TabIndex = 0;
            this.lblHex.Text = "Hex";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(6, 19);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(27, 13);
            this.lblRed.TabIndex = 1;
            this.lblRed.Text = "Red";
            // 
            // txtHex
            // 
            this.txtHex.Location = new System.Drawing.Point(62, 13);
            this.txtHex.Name = "txtHex";
            this.txtHex.Size = new System.Drawing.Size(100, 20);
            this.txtHex.TabIndex = 3;
            // 
            // txtRed
            // 
            this.txtRed.Location = new System.Drawing.Point(62, 16);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(100, 20);
            this.txtRed.TabIndex = 4;
            // 
            // txtGreen
            // 
            this.txtGreen.Location = new System.Drawing.Point(62, 42);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(100, 20);
            this.txtGreen.TabIndex = 5;
            // 
            // txtBlue
            // 
            this.txtBlue.Location = new System.Drawing.Point(62, 68);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(100, 20);
            this.txtBlue.TabIndex = 6;
            // 
            // grpHtml
            // 
            this.grpHtml.Controls.Add(this.lblHex);
            this.grpHtml.Controls.Add(this.txtHex);
            this.grpHtml.Location = new System.Drawing.Point(12, 135);
            this.grpHtml.Name = "grpHtml";
            this.grpHtml.Size = new System.Drawing.Size(175, 42);
            this.grpHtml.TabIndex = 5;
            this.grpHtml.TabStop = false;
            this.grpHtml.Text = "HTML";
            // 
            // grpRgb
            // 
            this.grpRgb.Controls.Add(this.lblBlue);
            this.grpRgb.Controls.Add(this.lblGreen);
            this.grpRgb.Controls.Add(this.lblRed);
            this.grpRgb.Controls.Add(this.txtRed);
            this.grpRgb.Controls.Add(this.txtBlue);
            this.grpRgb.Controls.Add(this.txtGreen);
            this.grpRgb.Location = new System.Drawing.Point(12, 183);
            this.grpRgb.Name = "grpRgb";
            this.grpRgb.Size = new System.Drawing.Size(175, 100);
            this.grpRgb.TabIndex = 6;
            this.grpRgb.TabStop = false;
            this.grpRgb.Text = "RGB";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(5, 71);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(28, 13);
            this.lblBlue.TabIndex = 1;
            this.lblBlue.Text = "Blue";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(6, 45);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(36, 13);
            this.lblGreen.TabIndex = 1;
            this.lblGreen.Text = "Green";
            // 
            // picScreenshot
            // 
            this.picScreenshot.Location = new System.Drawing.Point(0, 0);
            this.picScreenshot.Name = "picScreenshot";
            this.picScreenshot.Size = new System.Drawing.Size(394, 386);
            this.picScreenshot.TabIndex = 7;
            this.picScreenshot.TabStop = false;
            this.picScreenshot.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.picScreenshot);
            this.panel1.Location = new System.Drawing.Point(193, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 418);
            this.panel1.TabIndex = 8;
            // 
            // grpPreview
            // 
            this.grpPreview.Controls.Add(this.pnlColourPreview);
            this.grpPreview.Location = new System.Drawing.Point(13, 12);
            this.grpPreview.Name = "grpPreview";
            this.grpPreview.Size = new System.Drawing.Size(174, 117);
            this.grpPreview.TabIndex = 9;
            this.grpPreview.TabStop = false;
            this.grpPreview.Text = "Preview";
            // 
            // pnlColourPreview
            // 
            this.pnlColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlColourPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlColourPreview.Location = new System.Drawing.Point(3, 16);
            this.pnlColourPreview.Name = "pnlColourPreview";
            this.pnlColourPreview.Size = new System.Drawing.Size(168, 98);
            this.pnlColourPreview.TabIndex = 0;
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbout.Location = new System.Drawing.Point(12, 407);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 7;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(99, 407);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.grpPreview);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpRgb);
            this.Controls.Add(this.grpHtml);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "frmMain";
            this.Text = "What The Hex?";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.grpHtml.ResumeLayout(false);
            this.grpHtml.PerformLayout();
            this.grpRgb.ResumeLayout(false);
            this.grpRgb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picScreenshot)).EndInit();
            this.panel1.ResumeLayout(false);
            this.grpPreview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.GroupBox grpHtml;
        private System.Windows.Forms.GroupBox grpRgb;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.PictureBox picScreenshot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpPreview;
        private System.Windows.Forms.Panel pnlColourPreview;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnClose;

    }
}


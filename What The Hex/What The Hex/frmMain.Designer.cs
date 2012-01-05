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
            this.btnClipHex = new System.Windows.Forms.Button();
            this.grpRgb = new System.Windows.Forms.GroupBox();
            this.btnClipBlue = new System.Windows.Forms.Button();
            this.btnClipGreen = new System.Windows.Forms.Button();
            this.btnClipRed = new System.Windows.Forms.Button();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.picScreenshot = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpPreview = new System.Windows.Forms.GroupBox();
            this.pnlColourPreview = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.grpHtml.SuspendLayout();
            this.grpRgb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picScreenshot)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpPreview.SuspendLayout();
            this.grpStatus.SuspendLayout();
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
            this.txtHex.Location = new System.Drawing.Point(48, 13);
            this.txtHex.Name = "txtHex";
            this.txtHex.Size = new System.Drawing.Size(100, 20);
            this.txtHex.TabIndex = 3;
            // 
            // txtRed
            // 
            this.txtRed.Location = new System.Drawing.Point(48, 12);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(100, 20);
            this.txtRed.TabIndex = 4;
            // 
            // txtGreen
            // 
            this.txtGreen.Location = new System.Drawing.Point(48, 38);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(100, 20);
            this.txtGreen.TabIndex = 5;
            // 
            // txtBlue
            // 
            this.txtBlue.Location = new System.Drawing.Point(48, 64);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(100, 20);
            this.txtBlue.TabIndex = 6;
            // 
            // grpHtml
            // 
            this.grpHtml.Controls.Add(this.btnClipHex);
            this.grpHtml.Controls.Add(this.lblHex);
            this.grpHtml.Controls.Add(this.txtHex);
            this.grpHtml.Location = new System.Drawing.Point(13, 176);
            this.grpHtml.Name = "grpHtml";
            this.grpHtml.Size = new System.Drawing.Size(179, 42);
            this.grpHtml.TabIndex = 5;
            this.grpHtml.TabStop = false;
            this.grpHtml.Text = "HTML";
            // 
            // btnClipHex
            // 
            this.btnClipHex.Location = new System.Drawing.Point(148, 11);
            this.btnClipHex.Name = "btnClipHex";
            this.btnClipHex.Size = new System.Drawing.Size(23, 23);
            this.btnClipHex.TabIndex = 4;
            this.btnClipHex.TabStop = false;
            this.btnClipHex.Text = "C";
            this.btnClipHex.UseVisualStyleBackColor = true;
            this.btnClipHex.Click += new System.EventHandler(this.btnClipHex_Click);
            // 
            // grpRgb
            // 
            this.grpRgb.Controls.Add(this.btnClipBlue);
            this.grpRgb.Controls.Add(this.btnClipGreen);
            this.grpRgb.Controls.Add(this.btnClipRed);
            this.grpRgb.Controls.Add(this.lblBlue);
            this.grpRgb.Controls.Add(this.lblGreen);
            this.grpRgb.Controls.Add(this.lblRed);
            this.grpRgb.Controls.Add(this.txtRed);
            this.grpRgb.Controls.Add(this.txtBlue);
            this.grpRgb.Controls.Add(this.txtGreen);
            this.grpRgb.Location = new System.Drawing.Point(13, 224);
            this.grpRgb.Name = "grpRgb";
            this.grpRgb.Size = new System.Drawing.Size(179, 94);
            this.grpRgb.TabIndex = 6;
            this.grpRgb.TabStop = false;
            this.grpRgb.Text = "RGB";
            // 
            // btnClipBlue
            // 
            this.btnClipBlue.Location = new System.Drawing.Point(148, 62);
            this.btnClipBlue.Name = "btnClipBlue";
            this.btnClipBlue.Size = new System.Drawing.Size(23, 23);
            this.btnClipBlue.TabIndex = 4;
            this.btnClipBlue.TabStop = false;
            this.btnClipBlue.Text = "C";
            this.btnClipBlue.UseVisualStyleBackColor = true;
            this.btnClipBlue.Click += new System.EventHandler(this.btnClipBlue_Click);
            // 
            // btnClipGreen
            // 
            this.btnClipGreen.Location = new System.Drawing.Point(148, 36);
            this.btnClipGreen.Name = "btnClipGreen";
            this.btnClipGreen.Size = new System.Drawing.Size(23, 23);
            this.btnClipGreen.TabIndex = 4;
            this.btnClipGreen.TabStop = false;
            this.btnClipGreen.Text = "C";
            this.btnClipGreen.UseVisualStyleBackColor = true;
            this.btnClipGreen.Click += new System.EventHandler(this.btnClipGreen_Click);
            // 
            // btnClipRed
            // 
            this.btnClipRed.Location = new System.Drawing.Point(148, 10);
            this.btnClipRed.Name = "btnClipRed";
            this.btnClipRed.Size = new System.Drawing.Size(23, 23);
            this.btnClipRed.TabIndex = 4;
            this.btnClipRed.TabStop = false;
            this.btnClipRed.Text = "C";
            this.btnClipRed.UseVisualStyleBackColor = true;
            this.btnClipRed.Click += new System.EventHandler(this.btnClipRed_Click);
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(6, 67);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(28, 13);
            this.lblBlue.TabIndex = 1;
            this.lblBlue.Text = "Blue";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(6, 42);
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
            this.panel1.Location = new System.Drawing.Point(205, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 418);
            this.panel1.TabIndex = 8;
            // 
            // grpPreview
            // 
            this.grpPreview.Controls.Add(this.pnlColourPreview);
            this.grpPreview.Location = new System.Drawing.Point(14, 13);
            this.grpPreview.Name = "grpPreview";
            this.grpPreview.Size = new System.Drawing.Size(178, 117);
            this.grpPreview.TabIndex = 9;
            this.grpPreview.TabStop = false;
            this.grpPreview.Text = "Preview";
            // 
            // pnlColourPreview
            // 
            this.pnlColourPreview.BackColor = System.Drawing.SystemColors.Window;
            this.pnlColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlColourPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlColourPreview.Location = new System.Drawing.Point(3, 16);
            this.pnlColourPreview.Name = "pnlColourPreview";
            this.pnlColourPreview.Size = new System.Drawing.Size(172, 98);
            this.pnlColourPreview.TabIndex = 0;
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbout.Location = new System.Drawing.Point(13, 407);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(179, 23);
            this.btnAbout.TabIndex = 10;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(13, 330);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(179, 23);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "New Screenshot";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(13, 359);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(179, 23);
            this.btnPaste.TabIndex = 8;
            this.btnPaste.Text = "Paste from Clipboard";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(6, 16);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 11;
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.lblStatus);
            this.grpStatus.Location = new System.Drawing.Point(13, 135);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(179, 35);
            this.grpStatus.TabIndex = 12;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Status";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.grpStatus);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.btnNew);
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
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
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
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnClipHex;
        private System.Windows.Forms.Button btnClipBlue;
        private System.Windows.Forms.Button btnClipGreen;
        private System.Windows.Forms.Button btnClipRed;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpStatus;

    }
}


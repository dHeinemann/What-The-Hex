namespace What_The_Hex
{
    partial class frmAbout
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblLicense = new System.Windows.Forms.Label();
            this.llblWebsite = new System.Windows.Forms.LinkLabel();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.llblSource = new System.Windows.Forms.LinkLabel();
            this.picIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(26, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(132, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "What The Hex?";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(72, 67);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(41, 15);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "v0.00";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Copyright (c) 2012 David Heinemann";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(44, 199);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Alrighty then";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Location = new System.Drawing.Point(11, 118);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(162, 13);
            this.lblLicense.TabIndex = 4;
            this.lblLicense.Text = "Released under the MIT License";
            // 
            // llblWebsite
            // 
            this.llblWebsite.AutoSize = true;
            this.llblWebsite.Location = new System.Drawing.Point(78, 150);
            this.llblWebsite.Name = "llblWebsite";
            this.llblWebsite.Size = new System.Drawing.Size(90, 13);
            this.llblWebsite.TabIndex = 5;
            this.llblWebsite.TabStop = true;
            this.llblWebsite.Text = "dHeinemann.com";
            this.llblWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblWebsite_LinkClicked);
            // 
            // lblWebsite
            // 
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.Location = new System.Drawing.Point(23, 150);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(49, 13);
            this.lblWebsite.TabIndex = 6;
            this.lblWebsite.Text = "Website:";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(23, 167);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(44, 13);
            this.lblSource.TabIndex = 7;
            this.lblSource.Text = "Source:";
            // 
            // llblSource
            // 
            this.llblSource.AutoSize = true;
            this.llblSource.Location = new System.Drawing.Point(78, 167);
            this.llblSource.Name = "llblSource";
            this.llblSource.Size = new System.Drawing.Size(63, 13);
            this.llblSource.TabIndex = 8;
            this.llblSource.TabStop = true;
            this.llblSource.Text = "GitHub.com";
            this.llblSource.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSource_LinkClicked);
            // 
            // picIcon
            // 
            this.picIcon.Location = new System.Drawing.Point(77, 31);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(31, 32);
            this.picIcon.TabIndex = 9;
            this.picIcon.TabStop = false;
            // 
            // frmAbout
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(186, 234);
            this.ControlBox = false;
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.llblSource);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.lblWebsite);
            this.Controls.Add(this.llblWebsite);
            this.Controls.Add(this.lblLicense);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.LinkLabel llblWebsite;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.LinkLabel llblSource;
        private System.Windows.Forms.PictureBox picIcon;
    }
}
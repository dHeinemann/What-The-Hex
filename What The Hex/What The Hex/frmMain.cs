// Copyright (c) 2012 David Heinemann
// 
// Permission is hereby granted, free of charge, to any person obtaining a
// copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be included
// in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
// OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
// CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
// SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;

namespace What_The_Hex
{
    public partial class frmMain : Form
    {
        Stack<Bitmap> inStack = new Stack<Bitmap>();
        Stack<Bitmap> outStack = new Stack<Bitmap>();
        Bitmap currentScreenshot;

        public frmMain()
        {
            InitializeComponent();
            this.MouseWheel += new MouseEventHandler(frmMain_MouseWheel);
        }

        private void zoomIn()
        {
            if (inStack.Count > 0)
            {
                outStack.Push(currentScreenshot);
                Bitmap screenshot = inStack.Pop();
                displayImage(screenshot);
            }
        }

        private void zoomOut()
        {
            if (outStack.Count > 0)
            {
                inStack.Push(currentScreenshot);
                Bitmap screenshot = outStack.Pop();
                displayImage(screenshot);
            }
        }

        private void generateZooms(Bitmap image)
        {
            if (inStack.Count > 0)
                inStack.Clear();

            if (outStack.Count > 0)
                outStack.Clear();

            for (int i = 100; i >= 10; i -= 10)
                inStack.Push(generateZoomLevel(image, i));
        }

        private Bitmap generateZoomLevel(Bitmap image, int zoomPercentage)
        {
            int newWidth = image.Width + image.Width * zoomPercentage / 100;
            int newHeight = image.Height + image.Height * zoomPercentage / 100;

            Bitmap zoomedImage = new Bitmap(newWidth, newHeight);
            Graphics gfxShot = Graphics.FromImage((Image)zoomedImage);
            gfxShot.DrawImage(image, 0, 0, newWidth, newHeight);
            return zoomedImage;
        }

        private void takeScreenshot()
        {
            Bitmap screenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                Screen.PrimaryScreen.Bounds.Height,
                PixelFormat.Format32bppArgb);

            Graphics gfxScreenshot = Graphics.FromImage(screenshot);
            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                Screen.PrimaryScreen.Bounds.Y,
                0, 0,
                Screen.PrimaryScreen.Bounds.Size,
                CopyPixelOperation.SourceCopy);

            displayImage(screenshot);
            generateZooms(screenshot);
        }

        private void displayImage(Bitmap image)
        {
            currentScreenshot = image;
            picScreenshot.Image = image;
            picScreenshot.Width = image.Width;
            picScreenshot.Height = image.Height;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            takeScreenshot();
        }

        private void frmMain_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                zoomIn();
            else if (e.Delta < 0)
                zoomOut();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Color selectedColour = currentScreenshot.GetPixel(e.X, e.Y);

                //RGB
                txtRed.Text = Convert.ToString(selectedColour.R);
                txtGreen.Text = Convert.ToString(selectedColour.G);
                txtBlue.Text = Convert.ToString(selectedColour.B);

                //Hex
                txtHex.Text = "#"
                    + selectedColour.R.ToString("X")
                    + selectedColour.G.ToString("X")
                    + selectedColour.B.ToString("X");

                //Preview pane
                pnlColourPreview.BackColor = Color.FromArgb(selectedColour.R,
                    selectedColour.G,
                    selectedColour.B);
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            Thread.Sleep(500);
            takeScreenshot();
            this.WindowState = FormWindowState.Normal;
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                Bitmap screenshot = new Bitmap(Clipboard.GetImage());
                displayImage(screenshot);
                generateZooms(screenshot);
            }
            else
            {
                lblStatus.Text = "Error: no image in clipboard.";
            }
        }

        #region Clipboard functions
        private void btnClipHex_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txtHex.Text);
                lblStatus.Text = "Hex copied to clipboard.";
            }
            catch (ArgumentNullException ex)
            {
                lblStatus.Text = "Error: cannot copy; no data.";
            }
        }

        private void btnClipRed_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txtRed.Text);
                lblStatus.Text = "Red copied to clipboard.";
            }
            catch (ArgumentNullException ex)
            {
                lblStatus.Text = "Error: cannot copy; no data.";
            }
        }

        private void btnClipGreen_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txtGreen.Text);
                lblStatus.Text = "Green copied to clipboard.";
            }
            catch (ArgumentNullException ex)
            {
                lblStatus.Text = "Error: cannot copy; no data.";
            }
        }

        private void btnClipBlue_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txtBlue.Text);
                lblStatus.Text = "Blue copied to clipboard.";
            }
            catch (ArgumentNullException ex)
            {
                lblStatus.Text = "Error: cannot copy; no data.";
            }
        }
        #endregion
    }
}

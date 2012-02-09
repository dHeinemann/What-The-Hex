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
        Bitmap bmpShot;
        Graphics gfxShot;
        Stack<Bitmap> inStack = new Stack<Bitmap>();
        Stack<Bitmap> outStack = new Stack<Bitmap>();

        public frmMain()
        {
            InitializeComponent();
            this.MouseWheel += new MouseEventHandler(frmMain_MouseWheel);
        }

        private void frmMain_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                zoomIn();
            }
            else if (e.Delta < 0)
            {
                zoomOut();
            }
        }

        private void zoomIn()
        {
            if (inStack.Count > 0)
            {
                bmpShot = inStack.Pop();
                picScreenshot.Image = bmpShot;
                picScreenshot.Width = bmpShot.Width;
                picScreenshot.Height = bmpShot.Height;
                outStack.Push(bmpShot);
            }
        }

        private void zoomOut()
        {
            if (outStack.Count > 0)
            {
                bmpShot = outStack.Pop();
                picScreenshot.Image = bmpShot;
                picScreenshot.Width = bmpShot.Width;
                picScreenshot.Height = bmpShot.Height;
                inStack.Push(bmpShot);
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Color selectedColour = bmpShot.GetPixel(e.X, e.Y);

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

        private void frmMain_Load(object sender, EventArgs e)
        {
            takeScreenshot();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            //picScreenshot.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void generateZooms(Bitmap image)
        {
            for (int i = 100; i >= 0; i -= 10)
            {
                inStack.Push(generateZoom(image, i));
            }
        }

        private Bitmap generateZoom(Bitmap image, int zoomPercentage)
        {
            int newWidth = image.Width + image.Width * zoomPercentage / 100;
            int newHeight = image.Height + image.Height * zoomPercentage / 100;

            Bitmap output = new Bitmap(newWidth, newHeight);
            Graphics gfxShot = Graphics.FromImage((Image)output);
            gfxShot.DrawImage(image, 0, 0, newWidth, newHeight);
            return output;
        }

        private void takeScreenshot()
        {
            bmpShot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                Screen.PrimaryScreen.Bounds.Height,
                PixelFormat.Format32bppArgb);
            gfxShot = Graphics.FromImage(bmpShot);
            gfxShot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                Screen.PrimaryScreen.Bounds.Y,
                0, 0,
                Screen.PrimaryScreen.Bounds.Size,
                CopyPixelOperation.SourceCopy);
            picScreenshot.Image = bmpShot;
            picScreenshot.Width = bmpShot.Width;
            picScreenshot.Height = bmpShot.Height;

            generateZooms(bmpShot);
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
                bmpShot = new Bitmap(Clipboard.GetImage());
                picScreenshot.Image = bmpShot;
                picScreenshot.Width = bmpShot.Width;
                picScreenshot.Height = bmpShot.Height;
            }
            else
            {
                lblStatus.Text = "Error: no image in clipboard.";
            }
        }

        private void displayImage()
        {
            //Todo: Refactor other image display functions into this
        }

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
    }
}

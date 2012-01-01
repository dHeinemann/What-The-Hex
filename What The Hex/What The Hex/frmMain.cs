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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace What_The_Hex
{
    public partial class frmMain : Form
    {
        Bitmap bmpShot;
        Graphics gfxShot;

        public frmMain()
        {
            InitializeComponent();
            this.MouseWheel += new MouseEventHandler(frmMain_MouseWheel);
        }

        private void frmMain_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0) //In
            {
                //picScreenshot.Width += 100;
                //picScreenshot.Height += 100;
                //bmpShot.SetResolution(bmpShot.HorizontalResolution + 5, bmpShot.VerticalResolution + 5)
                
                
            }
            else if (e.Delta < 0) //Out
            {
              //  picScreenshot.Width -= 100;
              //  picScreenshot.Height -= 100;
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
            //TODO: Have the user set his own bounds by clicking in the top left and bottom right corners of the area he wants, then use that as the screenshot.  Zoom to max so it's easy to pinpoint the desired colour.
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

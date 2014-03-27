using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace LowPassFilter
{
    public partial class Form1 : Form
    {
        Bitmap bmhighPass;
        Bitmap bmlowPass;
        Bitmap bmhybrid;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLowBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = dialog.FileName;
                txtLowPath.Text = path;
            }
            Console.WriteLine(result);

        }

        private void btnLowPass_Click(object sender, EventArgs e)
        {
            Bitmap originLow = new Bitmap(txtLowPath.Text);
            bmlowPass = lowPass(originLow);
            picLowpass.Image = bmlowPass;
        }

        private Bitmap lowPass(Bitmap originLow)
        {
            int num = (int)blurRange.Value;
            double[] filter = new double[num];
            for (int i = 0; i < num; i++) 
            {
                filter[i] = 1.0 / num;
            }
            int originWidth = originLow.Width;
            int originHeight = originLow.Height;
            int lowWidth = originWidth + filter.Length + 1;
            int lowHeight = originHeight + filter.Length + 1;
            Bitmap imgLow = new Bitmap(lowWidth,lowHeight);
            for (int y = 0; y < imgLow.Height; y++)
                for (int x = 0; x < imgLow.Width; x++)
                    imgLow.SetPixel(x, y, Color.Black);

            for (int y = 0; y < originLow.Height; y++)
                for (int x = 0; x < originLow.Width; x++)
                    for (int j = 0; j < filter.Length; j++)
                    {
                        int red = (int)(imgLow.GetPixel(x + j, y+j).R + originLow.GetPixel(x, y).R * filter[j]);
                        int green = (int)(imgLow.GetPixel(x + j, y+j).G + originLow.GetPixel(x, y).G * filter[j]);
                        int blue = (int)(imgLow.GetPixel(x + j, y+j).B + originLow.GetPixel(x, y).B * filter[j]);
                        if (red > 255) red = 255;
                        if (green > 255) green = 255;
                        if (blue > 255) blue = 255;
                        Color c = Color.FromArgb(red, green, blue);
                        imgLow.SetPixel(x + j, y+j, c);
                    }

            return imgLow;
        }

        private Bitmap highPass(Bitmap originHigh)
        {
            Bitmap imglowpass = lowPass(originHigh);
        
            Bitmap imgHigh = new Bitmap(originHigh.Width,originHigh.Height);
            for (int y = 0; y < originHigh.Height; y++)
                for (int x = 0; x < originHigh.Width; x++)
                {
                    int highRed = (int)(originHigh.GetPixel(x, y).R - imglowpass.GetPixel(x, y).R);
                    int highGreen = (int)(originHigh.GetPixel(x, y).G - imglowpass.GetPixel(x, y).G);
                    int highBlue = (int)(originHigh.GetPixel(x, y).B - imglowpass.GetPixel(x, y).B);
                    if (highRed < 0) highRed = 0;
                    if (highGreen < 0) highGreen = 0;
                    if (highBlue < 0) highBlue = 0;
                    Color highColor = Color.FromArgb(highRed, highGreen, highBlue);
                    imgHigh.SetPixel(x, y, highColor);

                }
            picHighPass.Image = imgHigh;
            return imgHigh;
        }

        private void btnHighBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = dialog.FileName;
                txtHighPath.Text = path;
            }
            Console.WriteLine(result);
        }

        private void btnHighPass_Click(object sender, EventArgs e)
        {
            Bitmap originHigh = new Bitmap(txtHighPath.Text);
            bmhighPass = highPass(originHigh);
            picHighPass.Image = bmhighPass;

        }

        private void btnHybrid_Click(object sender, EventArgs e)
        {
            bmhybrid = hybrid(bmlowPass, bmhighPass);
            picHybrid.Image = bmhybrid;
        }

        private Bitmap hybrid(Bitmap lowPass, Bitmap highPass)
        {
            int width = (lowPass.Width < highPass.Width) ? lowPass.Width : highPass.Width;
            int height = (lowPass.Height < highPass.Height) ? lowPass.Height : highPass.Height;
            bmhybrid = new Bitmap(width, height);
            for (int y = 0; y < bmhybrid.Height; y++)
                for (int x = 0; x < bmhybrid.Width; x++)
                { 
                    int hybridRed = lowPass.GetPixel(x,y).R + highPass.GetPixel(x,y).R;
                    int hybridGreen = lowPass.GetPixel(x,y).G + highPass.GetPixel(x,y).G;
                    int hybridBlue = lowPass.GetPixel(x,y).B + highPass.GetPixel(x,y).B;
                    if (hybridRed > 255) hybridRed = 255;
                    if (hybridGreen > 255) hybridGreen = 255;
                    if (hybridBlue > 255) hybridBlue = 255;
                    Color hybridColor = Color.FromArgb(hybridRed, hybridGreen, hybridBlue);
                    bmhybrid.SetPixel(x, y, hybridColor);
                }
            return bmhybrid;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = saveDialog.ShowDialog();
            if (saveDialog.FileName != "")
            {
                FileStream fs = (FileStream)saveDialog.OpenFile();
                bmhybrid.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                fs.Close();
            }
        }
    }
}

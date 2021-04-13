using System;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ASCII_STL_to_JPG
{
    public partial class Form1 : Form
    {
        const string strFile = @"C:\Users\bzend\OneDrive\Desktop\FMDA_F17_ASCII.stl";
        const string strSave = @"C:\Users\bzend\OneDrive\Desktop\tests\test.bmp";
        public Form1()
        {
            InitializeComponent();
            string strIn = File.ReadAllText(strFile);
            double dblLength = strIn.Length;
            double dblSqrt = Math.Sqrt(dblLength);
            if (dblSqrt != (int)dblSqrt)
            {
                dblSqrt = (int)dblSqrt;
                while(dblLength % dblSqrt != 0)
                    dblSqrt++;

            }
            int h = (int)dblSqrt;
            int w = (int)dblLength / (int)dblSqrt ;
            Bitmap bmpRand = new Bitmap(w,h);
            int intDex = 0;
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    int a = 200;
                    int rgb = (byte)strIn[intDex];
                    bmpRand.SetPixel(x, y, Color.FromArgb(a, rgb, rgb, rgb));
                    intDex++;
                }
            }
            pictureBox1.Image = bmpRand;
            pictureBox1.Image.Save(strSave, ImageFormat.Bmp);
        }
    }
}

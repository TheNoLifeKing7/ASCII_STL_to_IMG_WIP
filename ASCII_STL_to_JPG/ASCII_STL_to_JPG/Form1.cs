using System;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ASCII_STL_to_JPG
{
    public partial class Form1 : Form
    {
        const string strFile = @"";//STL Location
        const string strSave = @"";//Img output location
        public Form1()
        {
            InitializeComponent();
            //reads the ASCII
            string strIn = File.ReadAllText(strFile);
            double dblLength = strIn.Length;
            
            //tries to keep the image square-ish, testing aspect ratio (each Char is a pixel)
            double dblSqrt = Math.Sqrt(dblLength);
            if (dblSqrt != (int)dblSqrt)
            {
                dblSqrt = (int)dblSqrt;
                while(dblLength % dblSqrt != 0)
                    dblSqrt++;

            }
            //save the Height and width and build the Bmp
            int h = (int)dblSqrt;
            int w = (int)dblLength / (int)dblSqrt ;
            Bitmap bmpRand = new Bitmap(w,h);

            //build it pixel by pixel
            int intDex = 0;
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    int rgb = (byte)strIn[intDex];//converts Char at index to byte 0-255, and makes that every RGB val
                    bmpRand.SetPixel(x, y, Color.FromArgb(255, rgb, rgb, rgb));
                    intDex++;
                }
            }
            pictureBox1.Image = bmpRand;//display image
            pictureBox1.Image.Save(strSave, ImageFormat.Bmp);//save image
        }
    }
}

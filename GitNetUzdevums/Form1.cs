using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double m = 30; //scale
            int xc = pictureBox1.Width / 2;   // center coordinates
            int yc = pictureBox1.Height / 2;
            int xe, ye;     // point "screen" coordinates
            double x, y;   // point "math" coordinates
            double step = 0.005;    // step
            Graphics G = pictureBox1.CreateGraphics();
            G.Clear(System.Drawing.Color.White);
            Pen myPen = new Pen(Color.Silver);
            G.DrawLine(myPen, 10, yc, 2 * xc - 10, yc);   // axes
            G.DrawLine(myPen, xc, 10, xc, 2 * yc - 10);
            myPen = new Pen(Color.Black);
            x = -Math.PI;
            // function graph design loop
            while (x < Math.PI)
            {
                try   // if the function does not exist at any point 
                {
                    y = 1/Math.Sin(x);   // Function formula!!!
                    xe = (int)(xc + m * x);
                    ye = (int)(yc - m * y);
                    G.DrawEllipse(myPen, xe, ye, 1, 1);
                }
                catch { }
                x += step;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            double m = 30; //scale
            int xc = pictureBox1.Width / 2;   // center coordinates
            int yc = pictureBox1.Height / 2;
            int xe, ye;     // point "screen" coordinates
            double x, y;   // point "math" coordinates
            double step = 0.005;    // step
            Graphics G = pictureBox1.CreateGraphics();
            G.Clear(System.Drawing.Color.White);
            Pen myPen = new Pen(Color.Silver);
            G.DrawLine(myPen, 10, yc, 2 * xc - 10, yc);   // axes
            G.DrawLine(myPen, xc, 10, xc, 2 * yc - 10);
            myPen = new Pen(Color.Black);
            x = -Math.PI;
            // function graph design loop
            while (x < Math.PI)
            {
                try   // if the function does not exist at any point 
                {
                    y = x * x; // Function formula!!!
                    xe = (int)(xc + m * x);
                    ye = (int)(yc - m * y);
                    G.DrawEllipse(myPen, xe, ye, 1, 1);
                }
                catch { }
                x += step;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double m = 30;
            int xc = pictureBox1.Width / 2;
            int yc = pictureBox1.Height / 2;
            int xe, ye;
            double x, y;
            double step = 0.005;
            Graphics G = pictureBox1.CreateGraphics();
            G.Clear(Color.White);
            Pen axisPen = new Pen(Color.Silver);
            G.DrawLine(axisPen, 10, yc, pictureBox1.Width - 10, yc); 
            G.DrawLine(axisPen, xc, 10, xc, pictureBox1.Height - 10); 
            Pen graphPen = new Pen(Color.Blue);
            x = 0.01;
            while (x < 10)
            {
                try
                {
                    y = Math.Log(x);
                    xe = (int)(xc + m * x);
                    ye = (int)(yc - m * y);
                    G.DrawEllipse(graphPen, xe, ye, 1, 1);
                }
                catch { }
                x += step;
            }
        }


        private void btn2_Click(object sender, EventArgs e)
        {
            double m = 30; 
            int xc = pictureBox1.Width / 2;
            int yc = pictureBox1.Height / 2;
            int xe, ye;
            double x, y;
            double step = 0.005;
            Graphics G = pictureBox1.CreateGraphics();
            G.Clear(Color.White);
            Pen axisPen = new Pen(Color.Silver);
            G.DrawLine(axisPen, 10, yc, pictureBox1.Width - 10, yc); 
            G.DrawLine(axisPen, xc, 10, xc, pictureBox1.Height - 10); 
            x = 0;
            while (x < 10)
            {
                try
                {
                    y = Math.Sqrt(x);
                    xe = (int)(xc + m * x);
                    ye = (int)(yc - m * y);
                    G.DrawEllipse(graphPen, xe, ye, 1, 1);
                }
                catch { }
                x += step;
            }
        }

    }
}

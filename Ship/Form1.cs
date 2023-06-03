using System;
using System.Drawing;
using System.Windows.Forms;
namespace Ship
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.WhiteSmoke);
            SolidBrush myCorp = new SolidBrush(Color.Blue);
            SolidBrush myTrum = new SolidBrush(Color.White);
            SolidBrush myTrub = new SolidBrush(Color.Silver);
            SolidBrush mySeà = new SolidBrush(Color.LightBlue);
            SolidBrush mySmoke = new SolidBrush(Color.White);
            SolidBrush mySun = new SolidBrush(Color.Yellow);
            Pen myWind = new Pen(Color.Black, 2);
            g.FillPie(mySun, 700, 35, 75, 75, 0, 360);
            g.FillPie(mySmoke, 650, 65, 80, 30, 0, 360);
            g.FillPie(mySmoke, 700, 75, 90, 40, 0, 360);
            g.FillPie(mySmoke, 750, 35, 80, 30, 0, 360);
            g.FillRectangle(myTrub, 390, 125, 75, 75);
            g.FillPie(mySmoke, 400, 75, 50, 50, 0, 360);
            g.FillPie(mySmoke, 410, 65, 50, 50, 0, 360);
            g.FillPie(mySmoke, 420, 55, 50, 50, 0, 360);
            g.FillPie(mySmoke, 430, 55, 50, 50, 0, 360);
            g.FillPie(mySmoke, 435, 45, 50, 50, 0, 360);
            g.FillPie(mySmoke, 445, 35, 50, 50, 0, 360);
            g.FillPolygon(myCorp, new Point[]
            {
                new Point(100,300),new Point(700,300),
                new Point(700,300),new Point(600,400),
                new Point(600,400),new Point(200,400),
                new Point(200,400),new Point(100,300)
            }
            );
            g.FillRectangle(myTrum, 250, 200, 350, 100);
            int x = 50;
            int Radius = 50;
            while (x <= pictureBox1.Width - Radius)
            {
                g.FillPie(mySeà, 0 + x, 375, 50, 50, 0, -180);
                x += 50;
            }
            for (int y = 300; y <= 550; y += 50)
            {
                g.DrawEllipse(myWind, y, 240, 20, 20); // 6 îêðóæíîñòåé
            }
        }
    }
}
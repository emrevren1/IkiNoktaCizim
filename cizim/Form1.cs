using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cizim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics cizgi;
        Pen kalem = new Pen(Color.ForestGreen, 2);
        Point nokta1, nokta2;

        void cizim(int n1x,int n1y, int n2x,int n2y)
        {
            nokta1 = new Point(n1x, n1y);
            nokta2 = new Point(n2x, n2y);

            cizgi = this.CreateGraphics();
            cizgi.DrawLine(kalem, nokta1, nokta2);
            cizgi.Dispose();


        }

        static int sayac = 0;
        int gecicix = 0, gecixiy = 0;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            sayac++;
            if(sayac%2==0)
            {
                cizim(gecicix, gecixiy,e.X,e.Y);
            }
            if(sayac%2==1)
            {
                gecicix = e.X;
                gecixiy = e.Y;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
    }
}

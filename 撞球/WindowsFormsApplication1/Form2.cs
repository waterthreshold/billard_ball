using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        int i;
        int x = 10;
        int y = 10;
        ball[] p = new ball[10];

        public Form2()
        {
            InitializeComponent();
            //SolidBrush brush;// = new SolidBrush(Color.Red);
            //SolidBrush brushWhi = new SolidBrush(Color.White);
            for (i = 0; i < 10; i++)
            {
                p[i] = new ball(i);
                p[i].x = i * 10 + 10;
                p[i].y = i * 10 + 10;


                if (i == 0)
                {
                    SolidBrush brushWhi = new SolidBrush(Color.White);
                    p[i].b = brushWhi;
                }



                if (i == 1)
                {
                    SolidBrush brushBla = new SolidBrush(Color.Black);
                    p[i].b = brushBla;
                }
                if (i == 2)
                {
                    SolidBrush brushBro = new SolidBrush(Color.Brown);
                    p[i].b = brushBro;
                }

                if (i == 3)
                {
                    SolidBrush brushPin = new SolidBrush(Color.Pink);
                    p[i].b = brushPin;
                }

                if (i == 4)
                {
                    SolidBrush brushgre = new SolidBrush(Color.Red);
                    p[i].b = brushgre;
                }
                if (i == 5)
                {
                    SolidBrush brushyel = new SolidBrush(Color.Yellow);
                    p[i].b = brushyel;
                }

                if (i == 6)
                {
                    SolidBrush brushsil = new SolidBrush(Color.Silver);
                    p[i].b = brushsil;
                }

                if (i == 7)
                {
                    SolidBrush g = new SolidBrush(Color.Gold);
                    p[i].b = g;
                }

                if (i == 8)
                {
                    SolidBrush brushPP = new SolidBrush(Color.Purple);
                    p[i].b = brushPP;
                }
                if (i == 9)
                {
                    SolidBrush brushoo = new SolidBrush(Color.Orange);
                    p[i].b = brushoo;
                }
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            for (i = 0; i < 10; i++)
            {
                p[i].Draw(e.Graphics);
            }
            //SolidBrush brushRed = new SolidBrush(Color.White);
            //e.Graphics.FillEllipse(brushRed,50,50,10,10);

            Pen pole = new Pen(Color.Brown,3);
            e.Graphics.DrawLine(pole,90,10,10,90);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
        
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pasta_Grafik_Çizimi
{
    public partial class Form1 : Form
    {
        int a, b, c, d; // textbox tan gelen değerleri tutacakalar.

        float d1, d2, d3, d4, toplam=0; // çeviri yapıldıktan sonra grafik değerlerini tuacak.

        Pen p; // Çizim yapacağımız kalemi tanımladık.

        Graphics g; // Çizim işlemini başlatabilmek için grafik nesnemizi tanımladık.

        Rectangle r;

        Brush b1, b2, b3, b4;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text.Trim());
            b = int.Parse(textBox2.Text.Trim());
            c = int.Parse(textBox3.Text.Trim());
            d = int.Parse(textBox4.Text.Trim());

            

            toplam = a + b + c + d;

            d1 = (a / toplam) * 360;
            d2 = (b / toplam) * 360;
            d3 = (c / toplam) * 360;
            d4 = (d / toplam) * 360;


            p = new Pen(Color.Yellow,2);

            g = this.CreateGraphics();

            

            Rectangle rec = new Rectangle(280, 35, 150, 150);

            b1 = new SolidBrush(Color.Red);
            b2 = new SolidBrush(Color.Cyan);
            b3 = new SolidBrush(Color.Blue);
            b4 = new SolidBrush(Color.BurlyWood);

           

            g.DrawPie(p,rec,0,d1);
            g.FillPie(b1, rec, 0, d1);
            
            g.DrawPie(p,rec,d1,d2);
            g.FillPie(b2,rec,d1,d2);

            g.DrawPie(p, rec, d1+d2, d3);
            g.FillPie(b3, rec, d1+d2, d3); 

            g.DrawPie(p, rec, d1+d2+d3, d4);
            g.FillPie(b4, rec, d1+d2+d3, d2);


            panel1.Visible = true;
           
            






        }
    }
}

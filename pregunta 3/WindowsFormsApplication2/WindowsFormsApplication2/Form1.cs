using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        int x, y;
        int mr = 0, mg = 0, mb = 0;
        
        Stack <string>c1 = new Stack<string>();

        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //controlar los fallos
            openFileDialog1.Filter = "Todos|*.*|Archivos JPGE|*.jpg";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            bmp = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*Bitmap bmp;
            bmp = (Bitmap)pictureBox1.Image;*/

            Color c = new Color();
            c = bmp.GetPixel(10, 10);
            textBox1.Text = c.R.ToString();
            textBox2.Text = c.G.ToString();
            textBox3.Text = c.B.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    bmp2.SetPixel(i, j, Color.FromArgb(c.R, 0, 0));

                }
                pictureBox1.Image = bmp2;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    bmp2.SetPixel(i, j, Color.FromArgb(0, 0, c.R));

                }
                pictureBox1.Image = bmp2;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    bmp2.SetPixel(i, j, Color.FromArgb(0, 0, c.R));

                }
                pictureBox1.Image = bmp2;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            textBox4.Text = x.ToString();
            textBox5.Text = y.ToString();
            Color c = new Color();
            mr = 0; mg = 0; mb = 0;
            for (int i = x; i < x + 10; i++)
            {
                for (int j = y; j < y + 10; j++)
                {
                    c = bmp.GetPixel(i, j);
                    mr = mr + c.R;
                    mg = mg + c.G;
                    mb = mb + c.B;

                }
            }
            mr = mr / 100;
            mg = mg / 100;
            mb = mb / 100;


            textBox1.Text = mr.ToString();
            textBox2.Text = mg.ToString();
            textBox3.Text = mb.ToString();
        }
        

        private void button6_Click(object sender, EventArgs e)
        {
            Color cleido = new Color();
            cleido = bmp.GetPixel(x, y);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    if ((cleido.R - 10 <= c.R) && (c.R - 10 <= cleido.R+10) &&
                        (cleido.G - 10 <= c.G) && (c.G - 10 <= cleido.G + 10) &&
                        (cleido.B - 10 <= c.B) && (c.B - 10 <= cleido.B+10)  )
                    {
                        bmp2.SetPixel(i, j, Color.Fuchsia);
                    }
                    else
                    {
                       
                        bmp2.SetPixel(i, j, Color.FromArgb(c.R, c.G, c.B));
                    }
                    

                }
                pictureBox1.Image = bmp2;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Color cleido = new Color();
            int mrn = 0, mgn = 0, mbn = 0;
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            while (c1.Count > 0)
            {
                
                string[] valor = c1.Pop().Split(';');
                int pr = Int32.Parse(valor[0]);
                int pg = Int32.Parse(valor[1]);
                int pb = Int32.Parse(valor[2]);
                int px = Int32.Parse(valor[3]);
                int py = Int32.Parse(valor[4]);
                cleido = bmp.GetPixel(px, py);

                for (int i = 0; i < bmp.Width - 10; i = i + 10)
                {
                    for (int j = 0; j < bmp.Height - 10; j = j + 10)
                    {

                        for (int i2 = i; i2 < i + 10; i2++)
                        {
                            for (int j2 = j; j2 < j + 10; j2++)
                            {
                                c = bmp.GetPixel(i2, j2);
                                mrn = mrn + c.R;
                                mgn = mgn + c.G;
                                mbn = mbn + c.B;
                            }
                        }
                        mrn = mrn / 100;
                        mgn = mgn / 100;
                        mbn = mbn / 100;
                        if ((pr - 10 <= mrn) && (mrn - 10 <= pr + 10) &&
                          (pg - 10 <= mgn) && (mgn - 10 <= pg + 10) &&
                          (pb - 10 <= mbn) && (mbn - 10 <= pb + 10))
                        {
                            for (int i2 = i; i2 < i + 10; i2++)
                            {
                                for (int j2 = j; j2 < j + 10; j2++)
                                {
                                    bmp.SetPixel(i2, j2, Color.FromArgb(pr,pg,pb));
                                }
                            }

                        }
                        else
                        {
                            for (int i2 = i; i2 < i + 10; i2++)
                            {
                                for (int j2 = j; j2 < j + 10; j2++)
                                {
                                    c = bmp.GetPixel(i2, j2);

                                    bmp.SetPixel(i2, j2, Color.FromArgb(c.R, c.G, c.B));
                                }
                            }
                        }

                    }
                    pictureBox1.Image = bmp;
                }
            }
        }


        private void button8_Click(object sender, EventArgs e)
        {
            string cadena = textBox1.Text+";"+textBox2.Text+";"+textBox3.Text+";"+x+";"+y ;
            c1.Push(cadena);
            label6.Text = c1.Count+"";
        }        
        public void cambiar_color(int r, int g, int b, int x, int y)
        {        }
    }
}

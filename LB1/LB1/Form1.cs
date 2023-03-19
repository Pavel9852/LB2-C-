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

namespace LB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap b;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            // Устанавливаем свойства для OpenFileDialog
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            // Отображаем диалоговое окно выбора файла
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Получаем выбранный путь к файлу
                string filePath = openFileDialog1.FileName;

                // Выводим путь к файлу в текстовое поле на форме
                textBox1.Text = filePath;
                b = new Bitmap(Image.FromFile(textBox1.Text));
                pictureBox1.Image = b;
            }
        }

          

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            double I, minI, maxI;
            Color c;
            double sum = 0, srI = 0;

            minI = 255;
            maxI = 0;
            for (int x = 0; x < b.Width; x = x + 1)
            {
                for (int y = 0; y < b.Height; y = y + 1)
                {
                    c = b.GetPixel(x, y);
                    I = (c.R + c.G + c.B) / 3;
                    sum = sum + I;
                    if (minI > I) minI = I;
                    if (maxI < I) maxI = I;
                }
            }
            srI = sum / (b.Width * b.Height);
            MessageBox.Show("Cередня яскравість = " + srI + " min = " + minI + " max = " + maxI);
        }
		private void button3_Click_1(object sender, EventArgs e) //Негатив!!!!!
		{
			Color c, newC;
			int newR, newG, newB;

			for (int x = 0; x < b.Width; x++)
			{
				for (int y = 0; y < b.Height; y++)
				{
					c = b.GetPixel(x, y);

					newR = 255 - c.R;
					newG = 255 - c.G;
					newB = 255 - c.B;

					newC = Color.FromArgb(255, newR, newG, newB);

					b.SetPixel(x, y, newC);
				}
			}

			pictureBox1.Image = b;
		}

		private void Button4_Click_1(object sender, EventArgs e) //Градация серого!!!!! Сильно отличаетс от того что в примере
        {
            Color c, newC;
            int newR, newG, newB;   
            double I;
            double k = Convert.ToDouble(textBox2.Text);
			for (int x = 50; x<b.Width-50; x++) 
            {
                for (int y = 50; x < b.Height-50; y++)
                {
                    c = b.GetPixel(x, y);
                    newR = (int)(k * c.R);
                    newG = (int)(k * c.G);
                    newB = (int)(k * c.B);

                    if (newR > 255) newR = 255;
                    if (newR < 0) newR = 0; // Тут и везде тоже біл другой знак но я поменял, опять таки хз на сколько првильно

                    if (newG > 255) newG = 255;
                    if (newG < 0) newG = 0;

                    if (newB > 255) newG=255;
                    if (newB < 0) newG = 0;
                    
                    newC = Color.FromArgb(255, newR, newG, newB);

					I = (c.R + c.G + c.B) / 3;
                    if (I > 255) I = 255;
                    if (I < 0) I = 0;

                    b.SetPixel(x, y, newC); 

                }
            }
            pictureBox1.Image = b;
        }
		private void Button5_Click_1(object sender, EventArgs e) //Яркость
        {
            Color c, newC;
            int newR, newG, newB;
			double k = Convert.ToDouble(textBox3.Text);
			for (int x = 50; x < b.Width - 50; x++)
            {
                for (int y = 0; y < b.Height - 50; y++)
                {
                    c = b.GetPixel(x, y);
                    newR = (int)(k * c.R);
                    newG = (int)(k * c.G);
                    newB = (int)(k * c.B);

                    if (newR > 255) newR = 255;
                    if (newR < 0) newR = 0;

                    if (newG > 255) newG = 255;
                    if (newG < 0) newG = 0;

                    if (newB > 255) newG = 255;
                    if (newB < 0) newG = 0;

                    newC = Color.FromArgb(255, newR, newG, newB);


                    b.SetPixel(x, y, newC);
                }

			}
			pictureBox1.Image = b;
		}
		private Color Lerp(Color startColor, Color endColor, double t)
		{
			int r = (int)(startColor.R + (endColor.R - startColor.R) * t);
			int g = (int)(startColor.G + (endColor.G - startColor.G) * t);
			int b = (int)(startColor.B + (endColor.B - startColor.B) * t);
			return Color.FromArgb(r, g, b);
		}

		private void Button6_Click_1(object sender, EventArgs e) //Градиент !!!Я как бы хз но выше уже было
		{
			Color c, newC;
			double k = Convert.ToDouble(textBox4.Text);
			Color startColor = Color.Red; // Начальный цвет градиента
			Color endColor = Color.Blue; // Конечный цвет градиента
			int w = b.Width - 100;
			int h = b.Height - 100;
			for (int x = 50; x < b.Width - 50; x++)
			{
				for (int y = 50; y < b.Height - 50; y++)
				{
					double t = (double)(x - 50) / (double)w;
					newC = Lerp(startColor, endColor, t);
					c = b.GetPixel(x, y);
					newC = Color.FromArgb(c.A, (int)(newC.R * k), (int)(newC.G * k), (int)(newC.B * k));
					b.SetPixel(x, y, newC);
				}
			}
			pictureBox1.Image = b;
		}

	}
}

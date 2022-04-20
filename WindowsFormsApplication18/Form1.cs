using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace WindowsForms_GraphicsFunction
{
    public partial class Form1 : Form
    {
        enum константы : byte {сдвиг,рaстяж,поворот,поворотU1,поворотU2}
        константы Tekconst;
        bool факт = false;
        double[,] points;
        const int KT = 5000;
        const double a = 1.0; //рост sin cos 
        const double Масштаб = 2.0;
        double MaxX, MinX, MaxY, MinY;
        double KoefX, KoefY, DeX, DeY;
        Graphics g_form, g_basic_bmp;
        Pen pen1;
        SolidBrush sbrush1;
        Bitmap basic_bmp;
        int ОтступСверху;
        double DX, DY, KX, KY,s;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g_form = this.CreateGraphics();
            pen1 = new Pen(Color.Black);
            sbrush1 = new SolidBrush(Color.Coral);
            ОтступСверху = menuStrip1.Height;
            basic_bmp = new Bitmap(this.ClientSize.Width, this.ClientSize.Height - ОтступСверху );
            g_basic_bmp = Graphics.FromImage(basic_bmp);
            g_basic_bmp.Clear(Color.White);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
             g_basic_bmp.Dispose();
            basic_bmp.Dispose();
            sbrush1.Dispose();
            pen1.Dispose();
            g_form.Dispose();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {  
            if (this.WindowState == FormWindowState.Minimized)
                return;
            if (this.ClientSize.Width == basic_bmp.Width && this.ClientSize.Height -  ОтступСверху == basic_bmp.Height)
                return;
            if (basic_bmp != null)
            {
               basic_bmp.Dispose();
            }
            if (g_basic_bmp != null)
                g_basic_bmp.Dispose();
            if (g_form != null)
                g_form.Dispose();
            g_form = this.CreateGraphics();
            basic_bmp = new Bitmap(this.ClientSize.Width, this.ClientSize.Height -  ОтступСверху);
            g_basic_bmp = Graphics.FromImage(basic_bmp);
            g_basic_bmp.Clear(Color.White);
            if (факт)
            {
                g_form.DrawImageUnscaled(basic_bmp, 0, ОтступСверху);
                Ris(points);
            }

        }

        private void построитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            points = new double[KT, 3];
            double шагпоphi = (2.0*2.0 * Math.PI - 0.0) / KT;
            double phi;
            for (int i = 0; i < KT; i++) // for(double phi = 0.0; phi <= 2.0*Math.Pi; phi+= шагпоphi)
            {
                phi = 0.0 + i * шагпоphi;
                points[i,0] = -a*(Math.Cos(phi)-Math.Cos(2*phi));
                points[i,1] = -a*(Math.Sin(phi)-Math.Sin(2*phi));
                points[i, 2] = 1.0;
                if (i == 0)
                {
                    MinX = MaxX = points[i, 0];
                    MinY = MaxY = points[i, 1];
                }
                else
                {
                    if (MinX > points[i, 0]) MinX = points[i, 0];
                    if (MaxX < points[i, 0]) MaxX = points[i, 0];
                    if (MinY > points[i, 1]) MinY = points[i, 1];
                    if (MaxY < points[i, 1]) MaxY = points[i, 1];
                }
            }
            факт = true;
            демонстрацияСдвигаToolStripMenuItem.Enabled = true;
            демонстрацияПоворотаToolStripMenuItem.Enabled = true;
            демонстрацияСжатияToolStripMenuItem.Enabled = true;
            демонстрацияСдвигаИПоворотаToolStripMenuItem.Enabled = true;
            демонстрацияПоворотаИСдвигаToolStripMenuItem.Enabled = true;
            Ris(points);
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Ris(double[,] T)
        { 
            KoefX = (basic_bmp.Width / Масштаб) / (MaxX - MinX);
            KoefY = (basic_bmp.Height/ Масштаб) / (MinY - MaxY);
            DeX = -KoefX * MinX + (1.0 - 1.0 / Масштаб) * basic_bmp.Width/2;
            DeY = -KoefY * MaxY + (1.0 - 1.0 / Масштаб) * basic_bmp.Height/2;
            g_basic_bmp.Clear(Color.White);
            for (int i = 0; i < KT; i++)
                g_basic_bmp.FillEllipse(sbrush1, (float)(KoefX * T[i, 0] + DeX - 3), (float)(KoefY * T[i, 1] + DeY - 3), 6, 6);
            const int K=8;
            String myString = "";
            Font myFont = new Font("Times New Roman", 8, FontStyle.Regular);
            if (MaxX * MinX < 0)
            {
                g_basic_bmp.DrawLine(pen1, (float)DeX, 0, (float)DeX, basic_bmp.Height);
                double ШагПоY = (MaxY - MinY) / K;
                for (int i = 0; i <= K; i++)
                {
                    if (-i * ШагПоY < MinY)
                        break;
                    myString = string.Format("{0:F2}", -i * ШагПоY);
                    g_basic_bmp.DrawString(myString, myFont, SystemBrushes.Highlight, (float)DeX - 35, (float)(KoefY * -i * ШагПоY + DeY));
                    g_basic_bmp.DrawLine(pen1, (float)DeX - 2, (float)(KoefY * -i * ШагПоY + DeY), (float)DeX + 2, (float)(KoefY * -i * ШагПоY + DeY));
                }
                for (int i = 1; i <= K; i++)
                {
                    if (i * ШагПоY > MaxY)
                        break;
                    myString = string.Format("{0:F2}", i * ШагПоY);
                    g_basic_bmp.DrawString(myString, myFont, SystemBrushes.Highlight, (float)DeX - 35, (float)(KoefY * i * ШагПоY + DeY));
                    g_basic_bmp.DrawLine(pen1, (float)DeX - 2, (float)(KoefY * i * ШагПоY + DeY), (float)DeX + 2, (float)(KoefY * i * ШагПоY + DeY));
                }
            }
            if (MaxY * MinY < 0)
            {
              double ШагПоX = (MaxX - MinX) / K;
              for (int i = 1; i <= K; i++)
              {
                  myString = string.Format("{0:F2}", -i * ШагПоX);
                  g_basic_bmp.DrawString(myString, myFont, SystemBrushes.Highlight, (float)(KoefX * -i * ШагПоX + DeX), (float)DeY + 10);
                  g_basic_bmp.DrawLine(pen1, (float)(KoefX * -i * ШагПоX + DeX), (float)DeY - 2,  (float)(KoefX * -i * ШагПоX + DeX),(float)DeY + 2);
                  if (-i * ШагПоX < MinX)
                      break;             
              }
              for (int i = 1; i <= K; i++)
              {
                  
                  myString = string.Format("{0:F2}", i * ШагПоX);
                  g_basic_bmp.DrawString(myString, myFont, SystemBrushes.Highlight, (float)(KoefX * i * ШагПоX + DeX), (float)DeY + 10);
                  g_basic_bmp.DrawLine(pen1, (float)(KoefX * i * ШагПоX + DeX), (float)DeY - 2, (float)(KoefX * i * ШагПоX + DeX), (float)DeY + 2);
                  if (i * ШагПоX > MaxX)
                      break;

              }
              g_basic_bmp.DrawLine(pen1, 0, (float)DeY,basic_bmp.Width , (float)DeY);
            }
          

            g_form.DrawImageUnscaled(basic_bmp, 0, ОтступСверху);
      }
       

        private void Form1_Paint(object sender, PaintEventArgs e)

        {  
            if (факт && basic_bmp != null)
                e.Graphics.DrawImageUnscaled(basic_bmp, 0, ОтступСверху);

        }
        private void ymnMatrNaVek(double [,]A,double [,]B, ref double [,]C)
        {
            int i, j, t;
            for(t = 0; t < KT; t++)
            for (i = 0; i < 3; i++)
            {
                C[t,i] = 0;
                for (j = 0; j < 3; j++)
                    C[t,i] += A[i, j] * B[t,j];
            }
        }
        private void ymnMatrNaMatr(double[,] A, double[,] B, ref double[,] C)
        {
          int i, j, k;
          for (i = 0; i < 3; i++)
            for (j = 0; j < 3; j++)
            {
              C[i, j] = 0;
              for (k = 0; k < 3; k++)
                C[i, j] += A[i, k] * B[k, j];
            }


        }
        private void демонстрацияСдвигаToolStripMenuItem_Click(object sender, EventArgs e)
        {
          DX = 0.0;
          DY = 0.0;
            Tekconst = константы.сдвиг;
            timer1.Enabled = true;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
          double[,] transform = new double[3, 3];
          double[,] transformToghki = new double[KT, 3];
          double[,] transform2 = new double[3, 3];
          double[,] transform3 = new double[3, 3];

          switch (Tekconst)
          {
            case константы.сдвиг:
              {
                transform[0, 0] = 1; transform[0, 1] = 0; transform[0, 2] = DX;
                transform[1, 0] = 0; transform[1, 1] = 1; transform[1, 2] = DY;
                transform[2, 0] = 0; transform[2, 1] = 0; transform[2, 2] = 1;
                ymnMatrNaVek(transform, points, ref transformToghki);
                Ris(transformToghki);
                DX += 0.05;
                DY += 0.05;
                if (DX > 5.0)
                  timer1.Enabled = false;
                break;
              }
            case константы.рaстяж:
              {
                transform[0, 0] = 1 / KX; transform[0, 1] = 0; transform[0, 2] = 0;
                transform[1, 0] = 0; transform[1, 1] = 1 / KY; transform[1, 2] = 0;
                transform[2, 0] = 0; transform[2, 1] = 0; transform[2, 2] = 1;
                ymnMatrNaVek(transform, points, ref transformToghki);
                Ris(transformToghki);
                KX -= 0.04;
                KY -= 0.04;
                if (KY < 0.9)
                  timer1.Enabled = false;
                break;
              }
            case константы.поворот:
              {
                transform[0, 0] = Math.Cos(s); transform[0, 1] = Math.Sin(s); transform[0, 2] = 0;
                transform[1, 0] = -Math.Sin(s); transform[1, 1] = Math.Cos(s); transform[1, 2] = 0;
                transform[2, 0] = 0; transform[2, 1] = 0; transform[2, 2] = 1;
                ymnMatrNaVek(transform, points, ref transformToghki);
                Ris(transformToghki);
                s += 0.2;
                if (s > 2.0*Math.PI)
                  timer1.Enabled = false;
                break;

              }
            case константы.поворотU1:
              {
                transform[0, 0] = 1; transform[0, 1] = 0; transform[0, 2] = 2.0;
                transform[1, 0] = 0; transform[1, 1] = 1; transform[1, 2] = 1.0;
                transform[2, 0] = 0; transform[2, 1] = 0; transform[2, 2] = 1;
                transform2[0, 0] = Math.Cos(s); transform2[0, 1] = Math.Sin(s); transform2[0, 2] = 0;
                transform2[1, 0] = -Math.Sin(s); transform2[1, 1] = Math.Cos(s); transform2[1, 2] = 0;
                transform2[2, 0] = 0; transform2[2, 1] = 0; transform2[2, 2] = 1;
                ymnMatrNaMatr(transform, transform2, ref transform3);
                ymnMatrNaVek(transform3, points, ref transformToghki);
                Ris(transformToghki);
                s += 0.1;
                if (s > 2.0 * Math.PI)
                  timer1.Enabled = false;
                break;

              }
            case константы.поворотU2:
              {
                transform[0, 0] = 1; transform[0, 1] = 0; transform[0, 2] = 2.0;
                transform[1, 0] = 0; transform[1, 1] = 1; transform[1, 2] = 1.0;
                transform[2, 0] = 0; transform[2, 1] = 0; transform[2, 2] = 1;
                transform2[0, 0] = Math.Cos(s); transform2[0, 1] = Math.Sin(s); transform2[0, 2] = 0;
                transform2[1, 0] = -Math.Sin(s); transform2[1, 1] = Math.Cos(s); transform2[1, 2] = 0;
                transform2[2, 0] = 0; transform2[2, 1] = 0; transform2[2, 2] = 1;
                ymnMatrNaMatr(transform2, transform, ref transform3);
                ymnMatrNaVek(transform3, points, ref transformToghki);
                Ris(transformToghki);
                s += 0.2;
                if (s > 2.0 * Math.PI)
                  timer1.Enabled = false;
                break;

              }

          }
        }

        private void демонстрацияСжатияToolStripMenuItem_Click(object sender, EventArgs e)
        {
          KX = 4;
          KY = 4;
          Tekconst = константы.рaстяж;
          timer1.Enabled = true;
          
        }

      private void демонстрацияПоворотаToolStripMenuItem_Click(object sender, EventArgs e)
      {
        s=0;
        Tekconst=константы.поворот;
         timer1.Enabled = true;
      }

      private void демонстрацияСдвигаИПоворотаToolStripMenuItem_Click(object sender, EventArgs e)
      {
        s = 0;
        Tekconst = константы.поворотU1;
        timer1.Enabled = true;
      }

      private void демонстрацияПоворотаИСдвигаToolStripMenuItem_Click(object sender, EventArgs e)
      {
        s = 0;
        Tekconst = константы.поворотU2;
        timer1.Enabled = true;
      }

      private void выходToolStripMenuItem_Click(object sender, EventArgs e)
      {
        Close();
      }
       

       
    }
}

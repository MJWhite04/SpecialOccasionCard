using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace SpecialOccasionCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //Pens, and Brushes
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black);
            Pen whitePen = new Pen(Color.White, 3);
            Pen YellowPen = new Pen(Color.Yellow);
            Pen redPen = new Pen(Color.Red);
            Pen maroonPen = new Pen(Color.Maroon);
            Pen darkgreenPen = new Pen(Color.DarkGreen);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush darkgreenBrush = new SolidBrush(Color.DarkGreen);
            Font drawFont = new Font("Playfair Display", 25, FontStyle.Bold);

            //clear background
            g.Clear(Color.Green);

            //ornament1
            g.FillEllipse(redBrush, 300, 125, 150, 150);
            g.DrawEllipse(blackPen, 300, 125, 150, 150);

            //snowflake1
            g.DrawLine(whitePen, 315, 200, 350, 200);
            g.DrawLine(whitePen, 330, 180, 330, 220);
            g.DrawLine(whitePen, 315, 220, 350, 180);
            g.DrawLine(whitePen, 315, 180, 350, 220);

            //ornament2
            g.FillEllipse(redBrush, 350, 60, 150, 150);
            g.DrawEllipse(blackPen, 350, 60, 150, 150);

            //rotating part of ornament
            g.TranslateTransform(457, 53);
            g.RotateTransform(35);
            g.DrawRectangle(maroonPen, 0, 0, 30, 10);
            g.FillRectangle(yellowBrush, 0, 0, 30, 10);
            g.ResetTransform();
            g.DrawEllipse(blackPen, 464, 42, 20, 20);

            //snowflake2
            g.DrawLine(whitePen, 390, 155, 415, 155);
            g.DrawLine(whitePen, 402, 140, 402, 170);
            g.DrawLine(whitePen, 390, 170, 415, 140);
            g.DrawLine(whitePen, 390, 140, 415, 170);

            //ornament3
            g.FillEllipse(redBrush, 415, 150, 150, 150);
            g.DrawEllipse(blackPen, 415, 150, 150, 150);

            //rotating part of ornament
            g.TranslateTransform(525, 145);
            g.RotateTransform(40);
            g.DrawRectangle(maroonPen, 0, 0, 30, 10);
            g.FillRectangle(yellowBrush, 0, 0, 30, 10);
            g.ResetTransform();
            g.DrawEllipse(blackPen, 533, 137, 20, 20);

            //snowflake3
            g.DrawLine(whitePen, 440, 200, 480, 200);
            g.DrawLine(whitePen, 460, 180, 460, 220);
            g.DrawLine(whitePen, 440, 220, 480, 180);
            g.DrawLine(whitePen, 440, 180, 480, 220);

            //Text on Screen
            g.DrawString("Merry Christmas", drawFont, whiteBrush, 50, 70);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Pens and Brushes
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black);
            Pen whitePen = new Pen(Color.White, 3);
            Pen MwhitePen = new Pen(Color.White, 18);
            Pen DwhitePen = new Pen(Color.White, 100);
            Pen YellowPen = new Pen(Color.Yellow);
            Pen redPen = new Pen(Color.Red);
            Pen maroonPen = new Pen(Color.Maroon);
            Pen darkgreenPen = new Pen(Color.DarkGreen);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush darkgreenBrush = new SolidBrush(Color.DarkGreen);
            Font drawFont = new Font("Playfair Display", 25, FontStyle.Bold);

            //Background Color
            g.Clear(Color.Green);

            //wait a quarter of a second and display screen contents below
            Thread.Sleep(750);

            //Sleigh Bells Ringing as Santa Flys
            SoundPlayer sleighBells = new SoundPlayer(Properties.Resources.Sleigh_Bells);
            sleighBells.Play();

            //Santa and Present
            g.FillRectangle(redBrush, 100, 200, 80, 30);
            g.DrawLine(whitePen, 100, 240, 175, 240);
            g.DrawLine(whitePen, 160, 240, 160, 230);
            g.DrawLine(whitePen, 120, 240, 120, 230);
            g.DrawLine(blackPen, 140, 200, 140, 185);
            g.DrawEllipse(blackPen,138, 175, 10, 10);
            g.FillRectangle(redBrush, 60, 205, 20, 20);

            //House 1
            g.DrawLine(DwhitePen, 428, 236, 508, 164);
            g.FillRectangle(redBrush, 400, 200, 140, 120);
            g.DrawRectangle(whitePen, 400, 200, 140, 120);
            g.DrawRectangle(whitePen, 455, 270, 30, 50);
            g.DrawEllipse(whitePen, 459, 300, 3, 3);
            g.DrawEllipse(whitePen, 420, 220, 25, 25);
            g.DrawEllipse(whitePen, 495, 220, 25, 25);

            //Text on Screen
            g.DrawString("And Have A Happy New Year", drawFont, whiteBrush, 30, 60);

            Fly();

        }
        
        private void House()
        {
            //Pens and Brushes
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black);
            Pen whitePen = new Pen(Color.White, 3);
            Pen MwhitePen = new Pen(Color.White, 18);
            Pen DwhitePen = new Pen(Color.White, 100);
            Pen YellowPen = new Pen(Color.Yellow);
            Pen redPen = new Pen(Color.Red);
            Pen maroonPen = new Pen(Color.Maroon);
            Pen darkgreenPen = new Pen(Color.DarkGreen);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush darkgreenBrush = new SolidBrush(Color.DarkGreen);
            Font drawFont = new Font("Playfair Display", 25, FontStyle.Bold);

            //Background Color
            g.Clear(Color.Green);

            //House 1
            g.DrawLine(DwhitePen, 428, 236, 508, 164);
            g.FillRectangle(redBrush, 400, 200, 140, 120);
            g.DrawRectangle(whitePen, 400, 200, 140, 120);
            g.DrawRectangle(whitePen, 455, 270, 30, 50);
            g.DrawEllipse(whitePen, 459, 300, 3, 3);
            g.DrawEllipse(whitePen, 420, 220, 25, 25);
            g.DrawEllipse(whitePen, 495, 220, 25, 25);

            //Text on Screen
            g.DrawString("And Have A Happy New Year", drawFont, whiteBrush, 30, 60);

        }
        private void Fly()
        {
            //Pens and Brushes
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black);
            Pen whitePen = new Pen(Color.White, 3);
            Pen MwhitePen = new Pen(Color.White, 18);
            Pen DwhitePen = new Pen(Color.White, 100);
            Pen YellowPen = new Pen(Color.Yellow);
            Pen redPen = new Pen(Color.Red);
            Pen maroonPen = new Pen(Color.Maroon);
            Pen darkgreenPen = new Pen(Color.DarkGreen);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush darkgreenBrush = new SolidBrush(Color.DarkGreen);
            Font drawFont = new Font("Playfair Display", 25, FontStyle.Bold);

            for (int x = 1; x <= 21; x++)
            {
                House();
                g.FillRectangle(redBrush, 100 + x * 10, 200, 80, 30);
                g.DrawLine(whitePen, 100 + x * 10, 240, 175 + x * 10, 240);
                g.DrawLine(whitePen, 160 + x * 10, 240, 160 + x * 10, 230);
                g.DrawLine(whitePen, 120 + x * 10, 240, 120 + x * 10, 230);
                g.DrawLine(blackPen, 140 + x * 10, 200, 140 + x * 10, 185);
                g.DrawEllipse(blackPen, 138 + x * 10, 175, 10, 10);
                g.FillRectangle(redBrush, 60 + x * 10, 205, 20, 20);
                Thread.Sleep(200);
                Refresh();
            }

            for (int y = 1; y <= 10; y++)
            {
                House();
                g.FillRectangle(redBrush, 300, 200, 80, 30);
                g.DrawLine(whitePen, 300, 240, 375, 240);
                g.DrawLine(whitePen, 360, 240, 360, 230);
                g.DrawLine(whitePen, 320, 240, 320, 230);
                g.DrawLine(blackPen, 340, 200, 340, 185);
                g.DrawEllipse(blackPen, 338, 175, 10, 10);
                g.FillRectangle(redBrush, 360, 205 + y * 10, 20, 20);
                Thread.Sleep(200);
                Refresh();

            }

            for (int x = 1; x <= 25; x++)
            {
                House();
                g.FillRectangle(redBrush, 300 + x * 10, 200, 80, 30);
                g.DrawLine(whitePen, 300 + x * 10, 240, 375 + x * 10, 240);
                g.DrawLine(whitePen, 360 + x * 10, 240, 360 + x * 10, 230);
                g.DrawLine(whitePen, 320 + x * 10, 240, 320 + x * 10, 230);
                g.DrawLine(blackPen, 340 + x * 10, 200, 340 + x * 10, 185);
                g.DrawEllipse(blackPen, 338 + x * 10, 175, 10, 10);
                g.FillRectangle(redBrush, 360, 300, 20, 20);
                Thread.Sleep(200);
                Refresh();
            }

        }

    
    }
}

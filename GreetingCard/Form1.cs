///Garrett, September 26, Serbian Kebab Removal Card
///This program demonstrates timing effects with sounds and graphics
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

namespace GreetingCard
{
    public partial class serbiaForm : Form
    {
        public serbiaForm()
        {
            InitializeComponent();
        }

        private void serbiaForm_Click(object sender, EventArgs e)
        {
            //Opening Sound
            SoundPlayer slavPlayer = new SoundPlayer(Properties.Resources.CheekiBreeki);
            slavPlayer.Play();
            Thread.Sleep(3000);

            //set up graphics and sound  
            BackgroundImage = null;
            Graphics onScreen = this.CreateGraphics();
            Bitmap bm = new Bitmap(this.Width, this.Height);
            Graphics offScreen = Graphics.FromImage(bm);
            Pen drawPen = new Pen(Color.Black, 5);
            Pen skinPen = new Pen(Color.NavajoWhite, 8);
            SolidBrush slavBrush = new SolidBrush(Color.Brown);
            SolidBrush tubeBrush = new SolidBrush(Color.DarkGray);
            SolidBrush skinBrush = new SolidBrush(Color.NavajoWhite);
            SolidBrush accBrush = new SolidBrush(Color.Gray);
            SolidBrush eyebrush = new SolidBrush(Color.Black);
            Font serbFont = new Font("Segoe UI", 16);
            SolidBrush textBrush = new SolidBrush(Color.Red);

            SoundPlayer songPlayer = new SoundPlayer(Properties.Resources.Remove);
            Thread.Sleep(100);
            songPlayer.Play();

            //Animation
            for (int x = 1; x <= 1501; x++)
            {
                //Default
                offScreen.DrawLine(skinPen, 200, 125, 125, 250); //left arm
                offScreen.DrawLine(skinPen, 300, 125, 350, 250); //right arm
                offScreen.DrawRectangle(drawPen, 200, 125, 100, 125); //torso
                offScreen.FillRectangle(slavBrush, 200, 125, 100, 125); //torso fill
                offScreen.DrawRectangle(drawPen, 201, 250, 98, 125); //legs
                offScreen.FillRectangle(slavBrush, 201, 250, 98, 125); //legs fill
                offScreen.DrawLine(drawPen, 250, 250, 250, 375);//legs divide
                offScreen.DrawEllipse(drawPen, 213, 50, 75, 75); //head
                offScreen.FillEllipse(skinBrush, 213, 50, 75, 75); //head fill
                offScreen.DrawEllipse(drawPen, 233, 75, 7, 7);//left eye
                offScreen.FillEllipse(eyebrush, 233, 75, 7, 7);//left eye fill
                offScreen.DrawEllipse(drawPen, 263, 75, 7, 7);//right eye
                offScreen.FillEllipse(eyebrush, 263, 75, 7, 7);//right eye fill
                offScreen.DrawLine(drawPen, 235, 95, 270, 95);//mouth
                offScreen.DrawRectangle(drawPen, 160, 235, 220, 25);//accordion tube
                offScreen.FillRectangle(tubeBrush, 160, 235, 220, 25);//accordion tube fill
                offScreen.DrawRectangle(drawPen, 110, 225, 50, 50);//accordion left
                offScreen.FillRectangle(accBrush, 110, 225, 50, 50);//accordion left fill
                offScreen.DrawRectangle(drawPen, 330, 225, 50, 50);//accordion right
                offScreen.FillRectangle(accBrush, 330, 225, 50, 50);//accordion right fill

                onScreen.DrawImage(bm, 0, 0);

                offScreen.Clear(Color.White);

                //animation starts - accordion-10
                Thread.Sleep(100);

                offScreen.DrawLine(skinPen, 200, 125, 115, 250); //left arm
                offScreen.DrawLine(skinPen, 300, 125, 360, 250); //right arm
                offScreen.DrawRectangle(drawPen, 200, 125, 100, 125); //torso
                offScreen.FillRectangle(slavBrush, 200, 125, 100, 125); //torso fill
                offScreen.DrawRectangle(drawPen, 201, 250, 98, 125); //legs
                offScreen.FillRectangle(slavBrush, 201, 250, 98, 125); //legs fill
                offScreen.DrawLine(drawPen, 250, 250, 250, 375);//legs divide
                offScreen.DrawEllipse(drawPen, 213, 50, 75, 75); //head
                offScreen.FillEllipse(skinBrush, 213, 50, 75, 75); //head fill
                offScreen.DrawEllipse(drawPen, 233, 75, 7, 7);//left eye
                offScreen.FillEllipse(eyebrush, 233, 75, 7, 7);//left eye fill
                offScreen.DrawEllipse(drawPen, 263, 75, 7, 7);//right eye
                offScreen.FillEllipse(eyebrush, 263, 75, 7, 7);//right eye fill
                offScreen.DrawLine(drawPen, 235, 95, 270, 95);//mouth
                offScreen.DrawRectangle(drawPen, 150, 235, 240, 25);//accordion tube
                offScreen.FillRectangle(tubeBrush, 150, 235, 240, 25);//accordion tube fill
                offScreen.DrawRectangle(drawPen, 100, 225, 50, 50);//accordion left
                offScreen.FillRectangle(accBrush, 100, 225, 50, 50);//accordion left fill
                offScreen.DrawRectangle(drawPen, 340, 225, 50, 50);//accordion right
                offScreen.FillRectangle(accBrush, 340, 225, 50, 50);//accordion right fill

                onScreen.DrawImage(bm, 0, 0);

                offScreen.Clear(Color.White);

                //accordion-20

                Thread.Sleep(100);

                offScreen.DrawLine(skinPen, 200, 125, 105, 250); //left arm
                offScreen.DrawLine(skinPen, 300, 125, 370, 250); //right arm
                offScreen.DrawRectangle(drawPen, 200, 125, 100, 125); //torso
                offScreen.FillRectangle(slavBrush, 200, 125, 100, 125); //torso fill
                offScreen.DrawRectangle(drawPen, 201, 250, 98, 125); //legs
                offScreen.FillRectangle(slavBrush, 201, 250, 98, 125); //legs fill
                offScreen.DrawLine(drawPen, 250, 250, 250, 375);//legs divide
                offScreen.DrawEllipse(drawPen, 213, 50, 75, 75); //head
                offScreen.FillEllipse(skinBrush, 213, 50, 75, 75); //head fill
                offScreen.DrawEllipse(drawPen, 233, 75, 7, 7);//left eye
                offScreen.FillEllipse(eyebrush, 233, 75, 7, 7);//left eye fill
                offScreen.DrawEllipse(drawPen, 263, 75, 7, 7);//right eye
                offScreen.FillEllipse(eyebrush, 263, 75, 7, 7);//right eye fill
                offScreen.DrawLine(drawPen, 235, 95, 270, 95);//mouth
                offScreen.DrawRectangle(drawPen, 140, 235, 260, 25);//accordion tube
                offScreen.FillRectangle(tubeBrush, 140, 235, 260, 25);//accordion tube fill
                offScreen.DrawRectangle(drawPen, 90, 225, 50, 50);//accordion left
                offScreen.FillRectangle(accBrush, 90, 225, 50, 50);//accordion left fill
                offScreen.DrawRectangle(drawPen, 350, 225, 50, 50);//accordion right
                offScreen.FillRectangle(accBrush, 350, 225, 50, 50);//accordion right fill

                onScreen.DrawImage(bm, 0, 0);

                offScreen.Clear(Color.White);

                //accordion-10
                Thread.Sleep(100);

                offScreen.DrawLine(skinPen, 200, 125, 115, 250); //left arm
                offScreen.DrawLine(skinPen, 300, 125, 360, 250); //right arm
                offScreen.DrawRectangle(drawPen, 200, 125, 100, 125); //torso
                offScreen.FillRectangle(slavBrush, 200, 125, 100, 125); //torso fill
                offScreen.DrawRectangle(drawPen, 201, 250, 98, 125); //legs
                offScreen.FillRectangle(slavBrush, 201, 250, 98, 125); //legs fill
                offScreen.DrawLine(drawPen, 250, 250, 250, 375);//legs divide
                offScreen.DrawEllipse(drawPen, 213, 50, 75, 75); //head
                offScreen.FillEllipse(skinBrush, 213, 50, 75, 75); //head fill
                offScreen.DrawEllipse(drawPen, 233, 75, 7, 7);//left eye
                offScreen.FillEllipse(eyebrush, 233, 75, 7, 7);//left eye fill
                offScreen.DrawEllipse(drawPen, 263, 75, 7, 7);//right eye
                offScreen.FillEllipse(eyebrush, 263, 75, 7, 7);//right eye fill
                offScreen.DrawLine(drawPen, 235, 95, 270, 95);//mouth
                offScreen.DrawRectangle(drawPen, 150, 235, 240, 25);//accordion tube
                offScreen.FillRectangle(tubeBrush, 150, 235, 240, 25);//accordion tube fill
                offScreen.DrawRectangle(drawPen, 100, 225, 50, 50);//accordion left
                offScreen.FillRectangle(accBrush, 100, 225, 50, 50);//accordion left fill
                offScreen.DrawRectangle(drawPen, 340, 225, 50, 50);//accordion right
                offScreen.FillRectangle(accBrush, 340, 225, 50, 50);//accordion right fill

                onScreen.DrawImage(bm, 0, 0);

                offScreen.Clear(Color.White);

                //text
                onScreen.DrawString("Serbia Strong  Remove Kebab", serbFont, textBrush, 30, 10);

                //Weirdly Positioned One (between -10 and +10)
                Thread.Sleep(100);

                offScreen.DrawLine(skinPen, 200, 125, 135, 250); //left arm
                offScreen.DrawLine(skinPen, 300, 125, 340, 250); //right arm
                offScreen.DrawRectangle(drawPen, 200, 125, 100, 125); //torso
                offScreen.FillRectangle(slavBrush, 200, 125, 100, 125); //torso fill
                offScreen.DrawRectangle(drawPen, 201, 250, 98, 125); //legs  
                offScreen.FillRectangle(slavBrush, 201, 250, 98, 125); //legs fill
                offScreen.DrawLine(drawPen, 250, 250, 250, 375);//legs divide
                offScreen.DrawEllipse(drawPen, 213, 50, 75, 75); //head
                offScreen.FillEllipse(skinBrush, 213, 50, 75, 75); //head fill
                offScreen.DrawEllipse(drawPen, 233, 75, 7, 7);//left eye
                offScreen.FillEllipse(eyebrush, 233, 75, 7, 7);//left eye fill
                offScreen.DrawEllipse(drawPen, 263, 75, 7, 7);//right eye
                offScreen.FillEllipse(eyebrush, 263, 75, 7, 7);//right eye fill
                offScreen.DrawLine(drawPen, 235, 95, 270, 95);//mouth
                offScreen.DrawRectangle(drawPen, 170, 235, 200, 25);//accordion tube
                offScreen.FillRectangle(tubeBrush, 170, 235, 200, 25);//accordion tube fill
                offScreen.DrawRectangle(drawPen, 120, 225, 50, 50);//accordion left
                offScreen.FillRectangle(accBrush, 120, 225, 50, 50);//accordion left fill
                offScreen.DrawRectangle(drawPen, 320, 225, 50, 50);//accordion right
                offScreen.FillRectangle(accBrush, 320, 225, 50, 50);//accordion right fill

                onScreen.DrawImage(bm, 0, 0);

                offScreen.Clear(Color.White);

                //accordion+10
                Thread.Sleep(100);

                offScreen.DrawLine(skinPen, 200, 125, 125, 250); //left arm
                offScreen.DrawLine(skinPen, 300, 125, 350, 250); //right arm
                offScreen.DrawRectangle(drawPen, 200, 125, 100, 125); //torso
                offScreen.FillRectangle(slavBrush, 200, 125, 100, 125); //torso fill
                offScreen.DrawRectangle(drawPen, 201, 250, 98, 125); //legs
                offScreen.FillRectangle(slavBrush, 201, 250, 98, 125); //legs fill
                offScreen.DrawLine(drawPen, 250, 250, 250, 375);//legs divide
                offScreen.DrawEllipse(drawPen, 213, 50, 75, 75); //head
                offScreen.FillEllipse(skinBrush, 213, 50, 75, 75); //head fill
                offScreen.DrawEllipse(drawPen, 233, 75, 7, 7);//left eye
                offScreen.FillEllipse(eyebrush, 233, 75, 7, 7);//left eye fill
                offScreen.DrawEllipse(drawPen, 263, 75, 7, 7);//right eye
                offScreen.FillEllipse(eyebrush, 263, 75, 7, 7);//right eye fill
                offScreen.DrawLine(drawPen, 235, 95, 270, 95);//mouth
                offScreen.DrawRectangle(drawPen, 160, 235, 220, 25);//accordion tube
                offScreen.FillRectangle(tubeBrush, 160, 235, 220, 25);//accordion tube fill
                offScreen.DrawRectangle(drawPen, 110, 225, 50, 50);//accordion left
                offScreen.FillRectangle(accBrush, 110, 225, 50, 50);//accordion left fill
                offScreen.DrawRectangle(drawPen, 330, 225, 50, 50);//accordion right
                offScreen.FillRectangle(accBrush, 330, 225, 50, 50);//accordion right fill

                onScreen.DrawImage(bm, 0, 0);

                offScreen.Clear(Color.White);

                //accordion+20
                Thread.Sleep(100);

                offScreen.DrawLine(skinPen, 200, 125, 135, 250); //left arm
                offScreen.DrawLine(skinPen, 300, 125, 340, 250); //right arm
                offScreen.DrawRectangle(drawPen, 200, 125, 100, 125); //torso
                offScreen.FillRectangle(slavBrush, 200, 125, 100, 125); //torso fill
                offScreen.DrawRectangle(drawPen, 201, 250, 98, 125); //legs
                offScreen.FillRectangle(slavBrush, 201, 250, 98, 125); //legs fill
                offScreen.DrawLine(drawPen, 250, 250, 250, 375);//legs divide
                offScreen.DrawEllipse(drawPen, 213, 50, 75, 75); //head
                offScreen.FillEllipse(skinBrush, 213, 50, 75, 75); //head fill
                offScreen.DrawEllipse(drawPen, 233, 75, 7, 7);//left eye
                offScreen.FillEllipse(eyebrush, 233, 75, 7, 7);//left eye fill
                offScreen.DrawEllipse(drawPen, 263, 75, 7, 7);//right eye
                offScreen.FillEllipse(eyebrush, 263, 75, 7, 7);//right eye fill
                offScreen.DrawLine(drawPen, 235, 95, 270, 95);//mouth
                offScreen.DrawRectangle(drawPen, 170, 235, 200, 25);//accordion tube
                offScreen.FillRectangle(tubeBrush, 170, 235, 200, 25);//accordion tube fill
                offScreen.DrawRectangle(drawPen, 120, 225, 50, 50);//accordion left
                offScreen.FillRectangle(accBrush, 120, 225, 50, 50);//accordion left fill
                offScreen.DrawRectangle(drawPen, 320, 225, 50, 50);//accordion right
                offScreen.FillRectangle(accBrush, 320, 225, 50, 50);//accordion right fill

                onScreen.DrawImage(bm, 0, 0);

                offScreen.Clear(Color.White);

                //accordion+30
                Thread.Sleep(100);

                offScreen.DrawLine(skinPen, 200, 125, 145, 250); //left arm
                offScreen.DrawLine(skinPen, 300, 125, 330, 250); //right arm
                offScreen.DrawRectangle(drawPen, 200, 125, 100, 125); //torso
                offScreen.FillRectangle(slavBrush, 200, 125, 100, 125); //torso fill
                offScreen.DrawRectangle(drawPen, 201, 250, 98, 125); //legs
                offScreen.FillRectangle(slavBrush, 201, 250, 98, 125); //legs fill
                offScreen.DrawLine(drawPen, 250, 250, 250, 375);//legs divide
                offScreen.DrawEllipse(drawPen, 213, 50, 75, 75); //head
                offScreen.FillEllipse(skinBrush, 213, 50, 75, 75); //head fill
                offScreen.DrawEllipse(drawPen, 233, 75, 7, 7);//left eye
                offScreen.FillEllipse(eyebrush, 233, 75, 7, 7);//left eye fill
                offScreen.DrawEllipse(drawPen, 263, 75, 7, 7);//right eye
                offScreen.FillEllipse(eyebrush, 263, 75, 7, 7);//right eye fill
                offScreen.DrawLine(drawPen, 235, 95, 270, 95);//mouth
                offScreen.DrawRectangle(drawPen, 180, 235, 180, 25);//accordion tube
                offScreen.FillRectangle(tubeBrush, 180, 235, 180, 25);//accordion tube fill
                offScreen.DrawRectangle(drawPen, 130, 225, 50, 50);//accordion left
                offScreen.FillRectangle(accBrush, 130, 225, 50, 50);//accordion left fill
                offScreen.DrawRectangle(drawPen, 310, 225, 50, 50);//accordion right
                offScreen.FillRectangle(accBrush, 310, 225, 50, 50);//accordion right fill

                onScreen.DrawImage(bm, 0, 0);

                offScreen.Clear(Color.White);

                //text
                onScreen.DrawString("Serbia Strong  Remove Kebab", serbFont, textBrush, 30, 10);

                //accordion+40
                Thread.Sleep(100);

                offScreen.DrawLine(skinPen, 200, 125, 155, 250); //left arm
                offScreen.DrawLine(skinPen, 300, 125, 320, 250); //right arm
                offScreen.DrawRectangle(drawPen, 200, 125, 100, 125); //torso
                offScreen.FillRectangle(slavBrush, 200, 125, 100, 125); //torso fill
                offScreen.DrawRectangle(drawPen, 201, 250, 98, 125); //legs
                offScreen.FillRectangle(slavBrush, 201, 250, 98, 125); //legs fill
                offScreen.DrawLine(drawPen, 250, 250, 250, 375);//legs divide
                offScreen.DrawEllipse(drawPen, 213, 50, 75, 75); //head
                offScreen.FillEllipse(skinBrush, 213, 50, 75, 75); //head fill
                offScreen.DrawEllipse(drawPen, 233, 75, 7, 7);//left eye
                offScreen.FillEllipse(eyebrush, 233, 75, 7, 7);//left eye fill
                offScreen.DrawEllipse(drawPen, 263, 75, 7, 7);//right eye
                offScreen.FillEllipse(eyebrush, 263, 75, 7, 7);//right eye fill
                offScreen.DrawLine(drawPen, 235, 95, 270, 95);//mouth
                offScreen.DrawRectangle(drawPen, 190, 235, 160, 25);//accordion tube
                offScreen.FillRectangle(tubeBrush, 190, 235, 160, 25);//accordion tube fill
                offScreen.DrawRectangle(drawPen, 140, 225, 50, 50);//accordion left
                offScreen.FillRectangle(accBrush, 140, 225, 50, 50);//accordion left fill
                offScreen.DrawRectangle(drawPen, 300, 225, 50, 50);//accordion right
                offScreen.FillRectangle(accBrush, 300, 225, 50, 50);//accordion right 

                onScreen.DrawImage(bm, 0, 0);

                offScreen.Clear(Color.White);

                //accordion+50
                Thread.Sleep(100);

                offScreen.DrawLine(skinPen, 200, 125, 165, 250); //left arm
                offScreen.DrawLine(skinPen, 300, 125, 310, 250); //right arm
                offScreen.DrawRectangle(drawPen, 200, 125, 100, 125); //torso
                offScreen.FillRectangle(slavBrush, 200, 125, 100, 125); //torso fill
                offScreen.DrawRectangle(drawPen, 201, 250, 98, 125); //legs
                offScreen.FillRectangle(slavBrush, 201, 250, 98, 125); //legs fill
                offScreen.DrawLine(drawPen, 250, 250, 250, 375);//legs divide
                offScreen.DrawEllipse(drawPen, 213, 50, 75, 75); //head
                offScreen.FillEllipse(skinBrush, 213, 50, 75, 75); //head fill
                offScreen.DrawEllipse(drawPen, 233, 75, 7, 7);//left eye
                offScreen.FillEllipse(eyebrush, 233, 75, 7, 7);//left eye fill
                offScreen.DrawEllipse(drawPen, 263, 75, 7, 7);//right eye
                offScreen.FillEllipse(eyebrush, 263, 75, 7, 7);//right eye fill
                offScreen.DrawLine(drawPen, 235, 95, 270, 95);//mouth
                offScreen.DrawRectangle(drawPen, 200, 235, 140, 25);//accordion tube
                offScreen.FillRectangle(tubeBrush, 200, 235, 140, 25);//accordion tube fill
                offScreen.DrawRectangle(drawPen, 150, 225, 50, 50);//accordion left
                offScreen.FillRectangle(accBrush, 150, 225, 50, 50);//accordion left fill
                offScreen.DrawRectangle(drawPen, 290, 225, 50, 50);//accordion right
                offScreen.FillRectangle(accBrush, 290, 225, 50, 50);//accordion right fill

                onScreen.DrawImage(bm, 0, 0);

                offScreen.Clear(Color.White);

                //accordion+60
                Thread.Sleep(100);

                offScreen.DrawLine(skinPen, 200, 125, 175, 250); //left arm
                offScreen.DrawLine(skinPen, 300, 125, 300, 250); //right arm
                offScreen.DrawRectangle(drawPen, 200, 125, 100, 125); //torso
                offScreen.FillRectangle(slavBrush, 200, 125, 100, 125); //torso fill
                offScreen.DrawRectangle(drawPen, 201, 250, 98, 125); //legs
                offScreen.FillRectangle(slavBrush, 201, 250, 98, 125); //legs fill
                offScreen.DrawLine(drawPen, 250, 250, 250, 375);//legs divide
                offScreen.DrawEllipse(drawPen, 213, 50, 75, 75); //head
                offScreen.FillEllipse(skinBrush, 213, 50, 75, 75); //head fill
                offScreen.DrawEllipse(drawPen, 233, 75, 7, 7);//left eye
                offScreen.FillEllipse(eyebrush, 233, 75, 7, 7);//left eye fill
                offScreen.DrawEllipse(drawPen, 263, 75, 7, 7);//right eye
                offScreen.FillEllipse(eyebrush, 263, 75, 7, 7);//right eye fill
                offScreen.DrawLine(drawPen, 235, 95, 270, 95);//mouth
                offScreen.DrawRectangle(drawPen, 210, 235, 120, 25);//accordion tube
                offScreen.FillRectangle(tubeBrush, 210, 235, 120, 25);//accordion tube fill
                offScreen.DrawRectangle(drawPen, 160, 225, 50, 50);//accordion left
                offScreen.FillRectangle(accBrush, 160, 225, 50, 50);//accordion left fill
                offScreen.DrawRectangle(drawPen, 280, 225, 50, 50);//accordion right
                offScreen.FillRectangle(accBrush, 280, 225, 50, 50);//accordion right fill

                onScreen.DrawImage(bm, 0, 0);

                offScreen.Clear(Color.White);

                //accordion+70
                Thread.Sleep(100);

                offScreen.DrawLine(skinPen, 200, 125, 185, 250); //left arm
                offScreen.DrawLine(skinPen, 300, 125, 290, 250); //right arm
                offScreen.DrawRectangle(drawPen, 200, 125, 100, 125); //torso
                offScreen.FillRectangle(slavBrush, 200, 125, 100, 125); //torso fill
                offScreen.DrawRectangle(drawPen, 201, 250, 98, 125); //legs
                offScreen.FillRectangle(slavBrush, 201, 250, 98, 125); //legs fill
                offScreen.DrawLine(drawPen, 250, 250, 250, 375);//legs divide
                offScreen.DrawEllipse(drawPen, 213, 50, 75, 75); //head
                offScreen.FillEllipse(skinBrush, 213, 50, 75, 75); //head fill
                offScreen.DrawEllipse(drawPen, 233, 75, 7, 7);//left eye
                offScreen.FillEllipse(eyebrush, 233, 75, 7, 7);//left eye fill
                offScreen.DrawEllipse(drawPen, 263, 75, 7, 7);//right eye
                offScreen.FillEllipse(eyebrush, 263, 75, 7, 7);//right eye fill
                offScreen.DrawLine(drawPen, 235, 95, 270, 95);//mouth
                offScreen.DrawRectangle(drawPen, 220, 235, 100, 25);//accordion tube
                offScreen.FillRectangle(tubeBrush, 220, 235, 100, 25);//accordion tube fill
                offScreen.DrawRectangle(drawPen, 170, 225, 50, 50);//accordion left
                offScreen.FillRectangle(accBrush, 170, 225, 50, 50);//accordion left fill
                offScreen.DrawRectangle(drawPen, 270, 225, 50, 50);//accordion right
                offScreen.FillRectangle(accBrush, 270, 225, 50, 50);//accordion right fill

                onScreen.DrawImage(bm, 0, 0);

                offScreen.Clear(Color.White);

                //text
                onScreen.DrawString("Serbia Strong  Remove Kebab", serbFont, textBrush, 30, 10);

                //accordion+60
                Thread.Sleep(100);

                offScreen.DrawLine(skinPen, 200, 125, 175, 250); //left arm
                offScreen.DrawLine(skinPen, 300, 125, 300, 250); //right arm
                offScreen.DrawRectangle(drawPen, 200, 125, 100, 125); //torso
                offScreen.FillRectangle(slavBrush, 200, 125, 100, 125); //torso fill
                offScreen.DrawRectangle(drawPen, 201, 250, 98, 125); //legs
                offScreen.FillRectangle(slavBrush, 201, 250, 98, 125); //legs fill
                offScreen.DrawLine(drawPen, 250, 250, 250, 375);//legs divide
                offScreen.DrawEllipse(drawPen, 213, 50, 75, 75); //head
                offScreen.FillEllipse(skinBrush, 213, 50, 75, 75); //head fill
                offScreen.DrawEllipse(drawPen, 233, 75, 7, 7);//left eye
                offScreen.FillEllipse(eyebrush, 233, 75, 7, 7);//left eye fill
                offScreen.DrawEllipse(drawPen, 263, 75, 7, 7);//right eye
                offScreen.FillEllipse(eyebrush, 263, 75, 7, 7);//right eye fill
                offScreen.DrawLine(drawPen, 235, 95, 270, 95);//mouth
                offScreen.DrawRectangle(drawPen, 210, 235, 120, 25);//accordion tube
                offScreen.FillRectangle(tubeBrush, 210, 235, 120, 25);//accordion tube fill
                offScreen.DrawRectangle(drawPen, 160, 225, 50, 50);//accordion left
                offScreen.FillRectangle(accBrush, 160, 225, 50, 50);//accordion left fill
                offScreen.DrawRectangle(drawPen, 280, 225, 50, 50);//accordion right
                offScreen.FillRectangle(accBrush, 280, 225, 50, 50);//accordion right fill

                onScreen.DrawImage(bm, 0, 0);

                offScreen.Clear(Color.White);

                //accordion+50
                Thread.Sleep(100);

                offScreen.DrawLine(skinPen, 200, 125, 165, 250); //left arm
                offScreen.DrawLine(skinPen, 300, 125, 310, 250); //right arm
                offScreen.DrawRectangle(drawPen, 200, 125, 100, 125); //torso
                offScreen.FillRectangle(slavBrush, 200, 125, 100, 125); //torso fill
                offScreen.DrawRectangle(drawPen, 201, 250, 98, 125); //legs
                offScreen.FillRectangle(slavBrush, 201, 250, 98, 125); //legs fill
                offScreen.DrawLine(drawPen, 250, 250, 250, 375);//legs divide
                offScreen.DrawEllipse(drawPen, 213, 50, 75, 75); //head
                offScreen.FillEllipse(skinBrush, 213, 50, 75, 75); //head fill
                offScreen.DrawEllipse(drawPen, 233, 75, 7, 7);//left eye
                offScreen.FillEllipse(eyebrush, 233, 75, 7, 7);//left eye fill
                offScreen.DrawEllipse(drawPen, 263, 75, 7, 7);//right eye
                offScreen.FillEllipse(eyebrush, 263, 75, 7, 7);//right eye fill
                offScreen.DrawLine(drawPen, 235, 95, 270, 95);//mouth
                offScreen.DrawRectangle(drawPen, 200, 235, 140, 25);//accordion tube
                offScreen.FillRectangle(tubeBrush, 200, 235, 140, 25);//accordion tube fill
                offScreen.DrawRectangle(drawPen, 150, 225, 50, 50);//accordion left
                offScreen.FillRectangle(accBrush, 150, 225, 50, 50);//accordion left fill
                offScreen.DrawRectangle(drawPen, 290, 225, 50, 50);//accordion right
                offScreen.FillRectangle(accBrush, 290, 225, 50, 50);//accordion right fill

                onScreen.DrawImage(bm, 0, 0);

                offScreen.Clear(Color.White);

                //accordion+40
                Thread.Sleep(100);

                offScreen.DrawLine(skinPen, 200, 125, 155, 250); //left arm
                offScreen.DrawLine(skinPen, 300, 125, 320, 250); //right arm
                offScreen.DrawRectangle(drawPen, 200, 125, 100, 125); //torso
                offScreen.FillRectangle(slavBrush, 200, 125, 100, 125); //torso fill
                offScreen.DrawRectangle(drawPen, 201, 250, 98, 125); //legs
                offScreen.FillRectangle(slavBrush, 201, 250, 98, 125); //legs fill
                offScreen.DrawLine(drawPen, 250, 250, 250, 375);//legs divide
                offScreen.DrawEllipse(drawPen, 213, 50, 75, 75); //head
                offScreen.FillEllipse(skinBrush, 213, 50, 75, 75); //head fill
                offScreen.DrawEllipse(drawPen, 233, 75, 7, 7);//left eye
                offScreen.FillEllipse(eyebrush, 233, 75, 7, 7);//left eye fill
                offScreen.DrawEllipse(drawPen, 263, 75, 7, 7);//right eye
                offScreen.FillEllipse(eyebrush, 263, 75, 7, 7);//right eye fill
                offScreen.DrawLine(drawPen, 235, 95, 270, 95);//mouth
                offScreen.DrawRectangle(drawPen, 190, 235, 160, 25);//accordion tube
                offScreen.FillRectangle(tubeBrush, 190, 235, 160, 25);//accordion tube fill
                offScreen.DrawRectangle(drawPen, 140, 225, 50, 50);//accordion left
                offScreen.FillRectangle(accBrush, 140, 225, 50, 50);//accordion left fill
                offScreen.DrawRectangle(drawPen, 300, 225, 50, 50);//accordion right
                offScreen.FillRectangle(accBrush, 300, 225, 50, 50);//accordion right 

                onScreen.DrawImage(bm, 0, 0);

                offScreen.Clear(Color.White);

                //accordion+30
                Thread.Sleep(100);

                offScreen.DrawLine(skinPen, 200, 125, 145, 250); //left arm
                offScreen.DrawLine(skinPen, 300, 125, 330, 250); //right arm
                offScreen.DrawRectangle(drawPen, 200, 125, 100, 125); //torso
                offScreen.FillRectangle(slavBrush, 200, 125, 100, 125); //torso fill
                offScreen.DrawRectangle(drawPen, 201, 250, 98, 125); //legs
                offScreen.FillRectangle(slavBrush, 201, 250, 98, 125); //legs fill
                offScreen.DrawLine(drawPen, 250, 250, 250, 375);//legs divide
                offScreen.DrawEllipse(drawPen, 213, 50, 75, 75); //head
                offScreen.FillEllipse(skinBrush, 213, 50, 75, 75); //head fill
                offScreen.DrawEllipse(drawPen, 233, 75, 7, 7);//left eye
                offScreen.FillEllipse(eyebrush, 233, 75, 7, 7);//left eye fill
                offScreen.DrawEllipse(drawPen, 263, 75, 7, 7);//right eye
                offScreen.FillEllipse(eyebrush, 263, 75, 7, 7);//right eye fill
                offScreen.DrawLine(drawPen, 235, 95, 270, 95);//mouth
                offScreen.DrawRectangle(drawPen, 180, 235, 180, 25);//accordion tube
                offScreen.FillRectangle(tubeBrush, 180, 235, 180, 25);//accordion tube fill
                offScreen.DrawRectangle(drawPen, 130, 225, 50, 50);//accordion left
                offScreen.FillRectangle(accBrush, 130, 225, 50, 50);//accordion left fill
                offScreen.DrawRectangle(drawPen, 310, 225, 50, 50);//accordion right
                offScreen.FillRectangle(accBrush, 310, 225, 50, 50);//accordion right fill

                onScreen.DrawImage(bm, 0, 0);

                offScreen.Clear(Color.White);

                //text
                onScreen.DrawString("Serbia Strong  Remove Kebab", serbFont, textBrush, 30, 10);

                //accordion+20
                Thread.Sleep(100);

                offScreen.DrawLine(skinPen, 200, 125, 135, 250); //left arm
                offScreen.DrawLine(skinPen, 300, 125, 340, 250); //right arm
                offScreen.DrawRectangle(drawPen, 200, 125, 100, 125); //torso
                offScreen.FillRectangle(slavBrush, 200, 125, 100, 125); //torso fill
                offScreen.DrawRectangle(drawPen, 201, 250, 98, 125); //legs
                offScreen.FillRectangle(slavBrush, 201, 250, 98, 125); //legs fill
                offScreen.DrawLine(drawPen, 250, 250, 250, 375);//legs divide
                offScreen.DrawEllipse(drawPen, 213, 50, 75, 75); //head
                offScreen.FillEllipse(skinBrush, 213, 50, 75, 75); //head fill
                offScreen.DrawEllipse(drawPen, 233, 75, 7, 7);//left eye
                offScreen.FillEllipse(eyebrush, 233, 75, 7, 7);//left eye fill
                offScreen.DrawEllipse(drawPen, 263, 75, 7, 7);//right eye
                offScreen.FillEllipse(eyebrush, 263, 75, 7, 7);//right eye fill
                offScreen.DrawLine(drawPen, 235, 95, 270, 95);//mouth
                offScreen.DrawRectangle(drawPen, 170, 235, 200, 25);//accordion tube
                offScreen.FillRectangle(tubeBrush, 170, 235, 200, 25);//accordion tube fill
                offScreen.DrawRectangle(drawPen, 120, 225, 50, 50);//accordion left
                offScreen.FillRectangle(accBrush, 120, 225, 50, 50);//accordion left fill
                offScreen.DrawRectangle(drawPen, 320, 225, 50, 50);//accordion right
                offScreen.FillRectangle(accBrush, 320, 225, 50, 50);//accordion right fill

                onScreen.DrawImage(bm, 0, 0);

                offScreen.Clear(Color.White);

                //accordion+10
                Thread.Sleep(100);

                offScreen.DrawLine(skinPen, 200, 125, 125, 250); //left arm
                offScreen.DrawLine(skinPen, 300, 125, 350, 250); //right arm
                offScreen.DrawRectangle(drawPen, 200, 125, 100, 125); //torso
                offScreen.FillRectangle(slavBrush, 200, 125, 100, 125); //torso fill
                offScreen.DrawRectangle(drawPen, 201, 250, 98, 125); //legs
                offScreen.FillRectangle(slavBrush, 201, 250, 98, 125); //legs fill
                offScreen.DrawLine(drawPen, 250, 250, 250, 375);//legs divide
                offScreen.DrawEllipse(drawPen, 213, 50, 75, 75); //head
                offScreen.FillEllipse(skinBrush, 213, 50, 75, 75); //head fill
                offScreen.DrawEllipse(drawPen, 233, 75, 7, 7);//left eye
                offScreen.FillEllipse(eyebrush, 233, 75, 7, 7);//left eye fill
                offScreen.DrawEllipse(drawPen, 263, 75, 7, 7);//right eye
                offScreen.FillEllipse(eyebrush, 263, 75, 7, 7);//right eye fill
                offScreen.DrawLine(drawPen, 235, 95, 270, 95);//mouth
                offScreen.DrawRectangle(drawPen, 160, 235, 220, 25);//accordion tube
                offScreen.FillRectangle(tubeBrush, 160, 235, 220, 25);//accordion tube fill
                offScreen.DrawRectangle(drawPen, 110, 225, 50, 50);//accordion left
                offScreen.FillRectangle(accBrush, 110, 225, 50, 50);//accordion left fill
                offScreen.DrawRectangle(drawPen, 330, 225, 50, 50);//accordion right
                offScreen.FillRectangle(accBrush, 330, 225, 50, 50);//accordion right fill

                onScreen.DrawImage(bm, 0, 0);

                offScreen.Clear(Color.White);

                //default
                Thread.Sleep(100);
                offScreen.DrawLine(skinPen, 200, 125, 125, 250); //left arm
                offScreen.DrawLine(skinPen, 300, 125, 350, 250); //right arm
                offScreen.DrawRectangle(drawPen, 200, 125, 100, 125); //torso
                offScreen.FillRectangle(slavBrush, 200, 125, 100, 125); //torso fill
                offScreen.DrawRectangle(drawPen, 201, 250, 98, 125); //legs
                offScreen.FillRectangle(slavBrush, 201, 250, 98, 125); //legs fill
                offScreen.DrawLine(drawPen, 250, 250, 250, 375);//legs divide
                offScreen.DrawEllipse(drawPen, 213, 50, 75, 75); //head
                offScreen.FillEllipse(skinBrush, 213, 50, 75, 75); //head fill
                offScreen.DrawEllipse(drawPen, 233, 75, 7, 7);//left eye
                offScreen.FillEllipse(eyebrush, 233, 75, 7, 7);//left eye fill
                offScreen.DrawEllipse(drawPen, 263, 75, 7, 7);//right eye
                offScreen.FillEllipse(eyebrush, 263, 75, 7, 7);//right eye fill
                offScreen.DrawLine(drawPen, 235, 95, 270, 95);//mouth
                offScreen.DrawRectangle(drawPen, 160, 235, 220, 25);//accordion tube
                offScreen.FillRectangle(tubeBrush, 160, 235, 220, 25);//accordion tube fill
                offScreen.DrawRectangle(drawPen, 110, 225, 50, 50);//accordion left
                offScreen.FillRectangle(accBrush, 110, 225, 50, 50);//accordion left fill
                offScreen.DrawRectangle(drawPen, 330, 225, 50, 50);//accordion right
                offScreen.FillRectangle(accBrush, 330, 225, 50, 50);//accordion right fill

                onScreen.DrawImage(bm, 0, 0);

                offScreen.Clear(Color.White);

                //accordion-10
                Thread.Sleep(100);

                offScreen.DrawLine(skinPen, 200, 125, 115, 250); //left arm
                offScreen.DrawLine(skinPen, 300, 125, 360, 250); //right arm
                offScreen.DrawRectangle(drawPen, 200, 125, 100, 125); //torso
                offScreen.FillRectangle(slavBrush, 200, 125, 100, 125); //torso fill
                offScreen.DrawRectangle(drawPen, 201, 250, 98, 125); //legs
                offScreen.FillRectangle(slavBrush, 201, 250, 98, 125); //legs fill
                offScreen.DrawLine(drawPen, 250, 250, 250, 375);//legs divide
                offScreen.DrawEllipse(drawPen, 213, 50, 75, 75); //head
                offScreen.FillEllipse(skinBrush, 213, 50, 75, 75); //head fill
                offScreen.DrawEllipse(drawPen, 233, 75, 7, 7);//left eye
                offScreen.FillEllipse(eyebrush, 233, 75, 7, 7);//left eye fill
                offScreen.DrawEllipse(drawPen, 263, 75, 7, 7);//right eye
                offScreen.FillEllipse(eyebrush, 263, 75, 7, 7);//right eye fill
                offScreen.DrawLine(drawPen, 235, 95, 270, 95);//mouth
                offScreen.DrawRectangle(drawPen, 150, 235, 240, 25);//accordion tube
                offScreen.FillRectangle(tubeBrush, 150, 235, 240, 25);//accordion tube fill
                offScreen.DrawRectangle(drawPen, 100, 225, 50, 50);//accordion left
                offScreen.FillRectangle(accBrush, 100, 225, 50, 50);//accordion left fill
                offScreen.DrawRectangle(drawPen, 340, 225, 50, 50);//accordion right
                offScreen.FillRectangle(accBrush, 340, 225, 50, 50);//accordion right fill

                onScreen.DrawImage(bm, 0, 0);

                offScreen.Clear(Color.White);

                //text
                onScreen.DrawString("Serbia Strong  Remove Kebab", serbFont, textBrush, 30, 10);

                //accordion-20

                Thread.Sleep(100);

                offScreen.DrawLine(skinPen, 200, 125, 105, 250); //left arm
                offScreen.DrawLine(skinPen, 300, 125, 370, 250); //right arm
                offScreen.DrawRectangle(drawPen, 200, 125, 100, 125); //torso
                offScreen.FillRectangle(slavBrush, 200, 125, 100, 125); //torso fill
                offScreen.DrawRectangle(drawPen, 201, 250, 98, 125); //legs
                offScreen.FillRectangle(slavBrush, 201, 250, 98, 125); //legs fill
                offScreen.DrawLine(drawPen, 250, 250, 250, 375);//legs divide
                offScreen.DrawEllipse(drawPen, 213, 50, 75, 75); //head
                offScreen.FillEllipse(skinBrush, 213, 50, 75, 75); //head fill
                offScreen.DrawEllipse(drawPen, 233, 75, 7, 7);//left eye
                offScreen.FillEllipse(eyebrush, 233, 75, 7, 7);//left eye fill
                offScreen.DrawEllipse(drawPen, 263, 75, 7, 7);//right eye
                offScreen.FillEllipse(eyebrush, 263, 75, 7, 7);//right eye fill
                offScreen.DrawLine(drawPen, 235, 95, 270, 95);//mouth
                offScreen.DrawRectangle(drawPen, 140, 235, 260, 25);//accordion tube
                offScreen.FillRectangle(tubeBrush, 140, 235, 260, 25);//accordion tube fill
                offScreen.DrawRectangle(drawPen, 90, 225, 50, 50);//accordion left
                offScreen.FillRectangle(accBrush, 90, 225, 50, 50);//accordion left fill
                offScreen.DrawRectangle(drawPen, 350, 225, 50, 50);//accordion right
                offScreen.FillRectangle(accBrush, 350, 225, 50, 50);//accordion right fill

                onScreen.DrawImage(bm, 0, 0);

                offScreen.Clear(Color.White);
            }
        }
    }
}
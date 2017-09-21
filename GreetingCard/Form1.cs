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
            //set up graphics and sound  
            BackgroundImage = null;
            Graphics onScreen = this.CreateGraphics();
            Bitmap bm = new Bitmap(this.Width, this.Height);
            Graphics offScreen = Graphics.FromImage(bm);
            Pen drawPen = new Pen(Color.Black, 5);
            Pen skinPen = new Pen(Color.NavajoWhite, 8);
            SolidBrush slavBrush = new SolidBrush(Color.Brown);
            SolidBrush skinBrush = new SolidBrush(Color.NavajoWhite);
            SolidBrush accBrush = new SolidBrush(Color.Gray);

            SoundPlayer slavPlayer = new SoundPlayer(Properties.Resources.Remove);

            //Image
            slavPlayer.Play();

            onScreen.DrawLine(skinPen, 200, 125, 125, 250); //left arm
            onScreen.DrawLine(skinPen, 300, 125, 350, 250); //right arm
            onScreen.DrawRectangle(drawPen, 200, 125, 100, 125); //torso
            onScreen.FillRectangle(slavBrush, 200, 125, 100, 125); //torso fill
            onScreen.DrawEllipse(drawPen, 213, 70, 75, 75); //head
            onScreen.FillEllipse(skinBrush, 213, 70, 75, 75); //head fill
        }
    }
}

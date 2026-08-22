using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarGame
{
    public partial class Form1 : Form
    {
        //ROAD

        private Timer timeroad;
        private Image roadImage;
        private int roadWidth;
        private int roadHeight;
        private float roadY;
        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            InitializeWindow();
            RegisterEvets();
            InitializedRoad();
        }

        private void InitializeWindow()
        {
            ClientSize = new Size(420, 640);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            KeyPreview = true;
        }

        private void InitializedRoad()
        {
           roadImage = Properties.Resources.road;
            roadWidth = ClientSize.Width;
            roadHeight = ClientSize.Height;
           
            timeroad = new Timer();
            timeroad.Interval = 30;
            timeroad.Tick += Timeroad_Tick;
            timeroad.Start();
        }


        private void RegisterEvets()
        {
            Paint += Form1_Paint;
            MouseClick += Form1_MouseClick;
            MouseMove += Form1_MouseMove;
            KeyUp += Form1_KeyUp;
            KeyDown += Form1_KeyDown;
        }

        private void Timeroad_Tick(object sender, EventArgs e)
        {
            roadY += 5;

            if (roadY >= roadHeight)
                roadY -= roadHeight;

            if (roadY < 0)
                roadY += roadHeight;

            Invalidate();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawRoad(e.Graphics);
        }

        private void DrawRoad(Graphics g)
        {
            g.DrawImage(roadImage, 0, roadY, roadWidth, roadHeight);
            g.DrawImage(roadImage, 0, roadY - roadHeight, roadWidth, roadHeight);
        }
    }
}

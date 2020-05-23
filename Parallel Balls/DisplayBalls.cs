using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parallel_Balls
{
    public partial class DisplayBalls : Form
    {
        private const int OFFSET = 30;
        private const int PEN_WIDTH = 1;
        private const int BALL_RADIUS = 10;
        private const int MIN_SPEED = 10;
        private const int MAX_SPEED = 50;

        public Rectangle area;
        Ball[] balls;
        int amountOfBalls, side;
        List<Thread> threads;

        public DisplayBalls()
        {
            InitializeComponent();
        }

        public DisplayBalls(int side, int amount)
        {
            InitializeComponent();
            amountOfBalls = amount;
            this.side = side;
            Width = side + 2 * OFFSET + 20;
            Height = Width + 30;
            area = new Rectangle(OFFSET, OFFSET, side, side);
            //timer.Interval = 10;
            this.DoubleBuffered = true;
            InitBalls();
            InitThreads();
        }
        private void InitThreads()
        {
            threads = new List<Thread>();
            foreach (Ball ball in balls)
            {
                Thread tr = new Thread(MoveBall);
                threads.Add(tr);
                tr.IsBackground = true;
                tr.Start(ball);

            }
            Thread thr = new Thread(UpdateField);
            thr.IsBackground = true;
            thr.Priority = ThreadPriority.AboveNormal;           
            threads.Add(thr);
            thr.Start();

        }
        
        private void UpdateField()
        {
            while (true)
            {
                Thread.Sleep(10);
                this.BeginInvoke((MethodInvoker)(() => { this.Refresh(); }));
            }
        }
        private void MoveBall(object ball)
        {
            while (true)
            {
                
                 MakeStep((Ball)ball);                                              

            }
        }
        private void MakeStep(Ball ball)
        {
            Thread.Sleep(ball.Speed);
            int possibleX = (int)(ball.x + 5 * Math.Cos(ball.Direction)),
                possibleY = (int)(ball.y + 5 * Math.Sin(ball.Direction));
            bool check = CheckIntersect(possibleX, possibleY, ball);


            ball.x = check ? (int)(ball.x + 5 * Math.Cos(ball.Direction)) : possibleX;
            ball.y = check ? (int)(ball.y + 5 * Math.Sin(ball.Direction)) : possibleY;
        }

        private bool CheckIntersect(int x, int y, Ball ball)
        {
            if (x <= area.X || x + 2 * BALL_RADIUS >= area.X + area.Width)
            {
                ball.Direction = ball.Direction > 0 ? Math.PI - ball.Direction : -Math.PI - ball.Direction;
                return true;
            }
            if (y <= area.Y || y + 2 * BALL_RADIUS >= area.Y + area.Height)
            {
                ball.Direction = -ball.Direction;
                return true;
            }
            return false;
        }
    
        private void InitBalls()
        {
            Random rand = new Random();
            balls = new Ball[amountOfBalls];
            for(int i = 0; i < balls.Length; i++)
            {
                balls[i] = new Ball(rand.Next(MIN_SPEED, MAX_SPEED),
                    rand.NextDouble() * Math.PI - rand.NextDouble() * Math.PI,
                    Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)),
                    area.X + area.Width / 2,
                    area.Y + area.Height / 2);
            }

        }
        
        private void DrawArea(PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(0, 0, 0), PEN_WIDTH);
            e.Graphics.DrawRectangle(pen, area);
        }

        private void Display_Paint(object sender, PaintEventArgs e)
        {
            DrawArea(e);
            DrawBalls(e);
        }

        private void DisplayBalls_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopThreads();
        }
        private void StopThreads()
        {
            foreach(Thread t in threads)
            {
                t.Abort();
            }
        }

        private void DrawBalls(PaintEventArgs e)
        {           
            foreach(Ball ball in balls)
            {
                Pen pen = new Pen(ball.Color, BALL_RADIUS);
                e.Graphics.DrawEllipse(pen, ball.x, ball.y, BALL_RADIUS, BALL_RADIUS);
            }
        }
    }
}

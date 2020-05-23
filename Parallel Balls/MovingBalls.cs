using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parallel_Balls
{
    public partial class MovingBalls : Form
    {
        private const int MIN_SIZE = 200;
        private const int MAX_SIZE = 700;
        private const int MAX_BALLS = 20;
       

        public MovingBalls()
        {
            InitializeComponent();
        }
        
        private void Start()
        {
            //Ввод значений 
            if(!Int32.TryParse(squareSizeTB.Text, out int side))
            {
                MessageBox.Show("Сторона квадрата должна быть целым числом!");
                return;
            }
            if(side <= MIN_SIZE || side >= MAX_SIZE)
            {
                MessageBox.Show("Сторона квадрата не может быть меньше " + MIN_SIZE
                    + " или больше " + MAX_SIZE);
                return;
            }
            if (!Int32.TryParse(amountOfBallsTB.Text, out int amountBalls))
            {
                MessageBox.Show("Количество шаров должно быть целым числом!");
                return;
            }
            if (amountBalls <= 0 || amountBalls >= MAX_BALLS)
            {
                MessageBox.Show("Количество шаров не может быть меньше " + 0
                    + " или больше " + MAX_BALLS);
                return;
            }

            //Инициализация формы для отображения шаров
            new DisplayBalls(side, amountBalls).Show();
                       
        }
        private void startBtn_Click(object sender, EventArgs e)
        {
            Start();
        }
    }
}

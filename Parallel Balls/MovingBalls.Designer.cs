namespace Parallel_Balls
{
    partial class MovingBalls
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.amountOfBallsTB = new System.Windows.Forms.TextBox();
            this.squareSizeTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(100, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество шариков:";
            // 
            // amountOfBallsTB
            // 
            this.amountOfBallsTB.Location = new System.Drawing.Point(310, 99);
            this.amountOfBallsTB.Name = "amountOfBallsTB";
            this.amountOfBallsTB.Size = new System.Drawing.Size(53, 22);
            this.amountOfBallsTB.TabIndex = 1;
            // 
            // squareSizeTB
            // 
            this.squareSizeTB.Location = new System.Drawing.Point(310, 156);
            this.squareSizeTB.Name = "squareSizeTB";
            this.squareSizeTB.Size = new System.Drawing.Size(53, 22);
            this.squareSizeTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Сторона квадрата (в пикселях):";
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startBtn.Location = new System.Drawing.Point(217, 294);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(232, 74);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "Запуск";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // MovingBalls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 470);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.squareSizeTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amountOfBallsTB);
            this.Controls.Add(this.label1);
            this.Name = "MovingBalls";
            this.Text = "Moving Balls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amountOfBallsTB;
        private System.Windows.Forms.TextBox squareSizeTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startBtn;
    }
}


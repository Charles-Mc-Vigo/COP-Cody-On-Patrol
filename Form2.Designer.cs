namespace Duty_After_Coding
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GameOver = new Label();
            restartButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // GameOver
            // 
            GameOver.AutoSize = true;
            GameOver.BackColor = Color.Transparent;
            GameOver.Font = new Font("Poppins Black", 50F, FontStyle.Regular, GraphicsUnit.Point);
            GameOver.ForeColor = Color.White;
            GameOver.Location = new Point(193, 258);
            GameOver.Name = "GameOver";
            GameOver.Size = new Size(470, 118);
            GameOver.TabIndex = 0;
            GameOver.Tag = "";
            GameOver.Text = "Game Over!";
            // 
            // restartButton
            // 
            restartButton.BackColor = Color.DodgerBlue;
            restartButton.Font = new Font("Poppins ExtraBold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            restartButton.ForeColor = Color.White;
            restartButton.Location = new Point(263, 362);
            restartButton.Name = "restartButton";
            restartButton.Size = new Size(114, 64);
            restartButton.TabIndex = 1;
            restartButton.Text = "Restart";
            restartButton.UseVisualStyleBackColor = false;
            restartButton.Click += restartButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Red;
            exitButton.Font = new Font("Poppins ExtraBold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(440, 362);
            exitButton.MaximumSize = new Size(114, 64);
            exitButton.MinimumSize = new Size(114, 64);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(114, 64);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.loadingimage3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(restartButton);
            Controls.Add(GameOver);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label GameOver;
        private Button restartButton;
        private Button exitButton;
    }
}
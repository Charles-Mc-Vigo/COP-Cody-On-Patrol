namespace Duty_After_Coding
{
    partial class loadingscreen
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
            components = new System.ComponentModel.Container();
            Loading = new Label();
            loadingTimer = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // Loading
            // 
            Loading.AutoSize = true;
            Loading.BackColor = Color.DarkSlateGray;
            Loading.Font = new Font("Snap ITC", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Loading.ForeColor = Color.GreenYellow;
            Loading.Location = new Point(490, 600);
            Loading.Name = "Loading";
            Loading.Size = new Size(148, 37);
            Loading.TabIndex = 0;
            Loading.Text = "Loading";
            // 
            // loadingTimer
            // 
            loadingTimer.Enabled = true;
            loadingTimer.Interval = 50;
            loadingTimer.Tick += loadingTimer_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Location = new Point(397, 550);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(328, 32);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 255, 128);
            panel2.Location = new Point(397, 550);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(11, 30);
            panel2.TabIndex = 2;
            // 
            // loadingscreen
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.loadingimage3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1129, 693);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Loading);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(1129, 693);
            MinimizeBox = false;
            MinimumSize = new Size(1129, 693);
            Name = "loadingscreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "loadingscreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Loading;
        private System.Windows.Forms.Timer loadingTimer;
        private Panel panel1;
        private Panel panel2;
    }
}
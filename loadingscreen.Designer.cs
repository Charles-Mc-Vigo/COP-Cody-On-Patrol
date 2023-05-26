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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Loading
            // 
            Loading.AutoSize = true;
            Loading.BackColor = Color.Transparent;
            Loading.Font = new Font("Snap ITC", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Loading.ForeColor = Color.GreenYellow;
            Loading.Location = new Point(429, 474);
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
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(528, 346);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 25);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 255, 128);
            panel2.Location = new Point(2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 24);
            panel2.TabIndex = 2;
            // 
            // loadingscreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.loadingimage3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1351, 480);
            Controls.Add(panel1);
            Controls.Add(Loading);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MaximumSize = new Size(1351, 480);
            MinimizeBox = false;
            MinimumSize = new Size(1351, 480);
            Name = "loadingscreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "loadingscreen";
            panel1.ResumeLayout(false);
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
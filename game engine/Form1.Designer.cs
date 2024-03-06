namespace game_engine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            FPSCounter = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            DrawClock = new System.Windows.Forms.Timer(components);
            GameClock = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 1);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "FPS: ";
            // 
            // FPSCounter
            // 
            FPSCounter.Enabled = true;
            FPSCounter.Interval = 1000;
            FPSCounter.Tick += FPSCounterTick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 419);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // DrawClock
            // 
            DrawClock.Enabled = true;
            DrawClock.Interval = 1;
            DrawClock.Tick += DrawClockTick;
            // 
            // GameClock
            // 
            GameClock.Enabled = true;
            GameClock.Interval = 50;
            GameClock.Tick += GameClockTick;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer FPSCounter;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer DrawClock;
        private System.Windows.Forms.Timer GameClock;
    }
}

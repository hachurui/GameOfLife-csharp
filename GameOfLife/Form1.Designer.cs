namespace GameOfLife
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
            pnlGame = new Panel();
            btnStart = new Button();
            btnGenerate = new Button();
            tmrGen = new System.Windows.Forms.Timer(components);
            btnStop = new Button();
            SuspendLayout();
            // 
            // pnlGame
            // 
            pnlGame.Location = new Point(12, 12);
            pnlGame.Name = "pnlGame";
            pnlGame.Size = new Size(301, 301);
            pnlGame.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(192, 255, 192);
            btnStart.Enabled = false;
            btnStart.Location = new Point(119, 333);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(80, 44);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(255, 255, 192);
            btnGenerate.Location = new Point(12, 333);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(80, 44);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "Generate Grid";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // tmrGen
            // 
            tmrGen.Tick += tmrGen_Tick;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.FromArgb(255, 192, 192);
            btnStop.Enabled = false;
            btnStop.Location = new Point(233, 333);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(80, 44);
            btnStop.TabIndex = 3;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(325, 448);
            Controls.Add(btnStop);
            Controls.Add(btnGenerate);
            Controls.Add(btnStart);
            Controls.Add(pnlGame);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlGame;
        private Button btnStart;
        private Button btnGenerate;
        private System.Windows.Forms.Timer tmrGen;
        private Button btnStop;
    }
}

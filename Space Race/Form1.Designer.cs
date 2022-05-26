namespace Space_Race
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.gameEngine = new System.Windows.Forms.Timer(this.components);
            this.p1Score = new System.Windows.Forms.Label();
            this.p2Score = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameEngine
            // 
            this.gameEngine.Interval = 20;
            this.gameEngine.Tick += new System.EventHandler(this.gameEngine_Tick);
            // 
            // p1Score
            // 
            this.p1Score.AutoSize = true;
            this.p1Score.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Score.ForeColor = System.Drawing.Color.White;
            this.p1Score.Location = new System.Drawing.Point(12, 641);
            this.p1Score.Name = "p1Score";
            this.p1Score.Size = new System.Drawing.Size(44, 50);
            this.p1Score.TabIndex = 0;
            this.p1Score.Text = "0";
            // 
            // p2Score
            // 
            this.p2Score.AutoSize = true;
            this.p2Score.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Score.ForeColor = System.Drawing.Color.White;
            this.p2Score.Location = new System.Drawing.Point(444, 641);
            this.p2Score.Name = "p2Score";
            this.p2Score.Size = new System.Drawing.Size(44, 50);
            this.p2Score.TabIndex = 1;
            this.p2Score.Text = "0";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(76, 281);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(345, 68);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Press Space to Start \r\nEscape to End The Game";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(500, 700);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.p2Score);
            this.Controls.Add(this.p1Score);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameEngine;
        private System.Windows.Forms.Label p1Score;
        private System.Windows.Forms.Label p2Score;
        private System.Windows.Forms.Label titleLabel;
    }
}


namespace bird_hunting_game
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bird_right = new System.Windows.Forms.PictureBox();
            this.bird_left = new System.Windows.Forms.PictureBox();
            this.grass_pbox = new System.Windows.Forms.PictureBox();
            this.panelinfo = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.bird_right2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass_pbox)).BeginInit();
            this.panelinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bird_right2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::bird_hunting_game.Properties.Resources.scarecrow_gif;
            this.pictureBox1.Location = new System.Drawing.Point(690, 279);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // bird_right
            // 
            this.bird_right.BackColor = System.Drawing.Color.Transparent;
            this.bird_right.Image = global::bird_hunting_game.Properties.Resources.bird_right_4;
            this.bird_right.Location = new System.Drawing.Point(33, 195);
            this.bird_right.Name = "bird_right";
            this.bird_right.Size = new System.Drawing.Size(55, 51);
            this.bird_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird_right.TabIndex = 2;
            this.bird_right.TabStop = false;
            this.bird_right.Click += new System.EventHandler(this.bird_right_Click);
            // 
            // bird_left
            // 
            this.bird_left.BackColor = System.Drawing.Color.Transparent;
            this.bird_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bird_left.Image = global::bird_hunting_game.Properties.Resources.bird_left_3;
            this.bird_left.Location = new System.Drawing.Point(847, 95);
            this.bird_left.Name = "bird_left";
            this.bird_left.Size = new System.Drawing.Size(55, 51);
            this.bird_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird_left.TabIndex = 1;
            this.bird_left.TabStop = false;
            this.bird_left.Click += new System.EventHandler(this.bird_left_Click);
            // 
            // grass_pbox
            // 
            this.grass_pbox.BackColor = System.Drawing.Color.Transparent;
            this.grass_pbox.Image = global::bird_hunting_game.Properties.Resources.grass;
            this.grass_pbox.Location = new System.Drawing.Point(-1, 279);
            this.grass_pbox.Name = "grass_pbox";
            this.grass_pbox.Size = new System.Drawing.Size(928, 341);
            this.grass_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grass_pbox.TabIndex = 0;
            this.grass_pbox.TabStop = false;
            // 
            // panelinfo
            // 
            this.panelinfo.BackColor = System.Drawing.Color.Transparent;
            this.panelinfo.Controls.Add(this.lblTime);
            this.panelinfo.Controls.Add(this.lblScore);
            this.panelinfo.Location = new System.Drawing.Point(-1, 0);
            this.panelinfo.Name = "panelinfo";
            this.panelinfo.Size = new System.Drawing.Size(928, 30);
            this.panelinfo.TabIndex = 4;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(824, 3);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(97, 25);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Time: 60";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(4, 3);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(94, 25);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score: 0";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // bird_right2
            // 
            this.bird_right2.BackColor = System.Drawing.Color.Transparent;
            this.bird_right2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bird_right2.Image = global::bird_hunting_game.Properties.Resources.bird_right_3;
            this.bird_right2.Location = new System.Drawing.Point(12, 31);
            this.bird_right2.Name = "bird_right2";
            this.bird_right2.Size = new System.Drawing.Size(55, 51);
            this.bird_right2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird_right2.TabIndex = 5;
            this.bird_right2.TabStop = false;
            this.bird_right2.Click += new System.EventHandler(this.bird_right2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImage = global::bird_hunting_game.Properties.Resources.clouds3;
            this.ClientSize = new System.Drawing.Size(926, 619);
            this.Controls.Add(this.bird_right2);
            this.Controls.Add(this.panelinfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bird_right);
            this.Controls.Add(this.bird_left);
            this.Controls.Add(this.grass_pbox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bird Hunter Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass_pbox)).EndInit();
            this.panelinfo.ResumeLayout(false);
            this.panelinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bird_right2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox grass_pbox;
        private System.Windows.Forms.PictureBox bird_left;
        private System.Windows.Forms.PictureBox bird_right;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelinfo;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox bird_right2;
    }
}


namespace Flappy_bird_Game
{
    partial class Game
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
            this.game_time = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.life3 = new System.Windows.Forms.PictureBox();
            this.life2 = new System.Windows.Forms.PictureBox();
            this.life1 = new System.Windows.Forms.PictureBox();
            this.score_lbl = new System.Windows.Forms.Label();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.levellbl = new System.Windows.Forms.Label();
            this.restartbtn = new System.Windows.Forms.Label();
            this.nxlLevelbtn = new System.Windows.Forms.Label();
            this.pipe_top2 = new System.Windows.Forms.PictureBox();
            this.exLife = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipe_bottom = new System.Windows.Forms.PictureBox();
            this.pipe_top = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_top2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exLife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            this.SuspendLayout();
            // 
            // game_time
            // 
            this.game_time.Interval = 20;
            this.game_time.Tick += new System.EventHandler(this.gameTimeTickEvent);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.life3);
            this.panel1.Controls.Add(this.life2);
            this.panel1.Controls.Add(this.life1);
            this.panel1.Location = new System.Drawing.Point(6, 382);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 50);
            this.panel1.TabIndex = 8;
            // 
            // life3
            // 
            this.life3.Image = global::Flappy_bird_Game.Properties.Resources.h;
            this.life3.Location = new System.Drawing.Point(105, 2);
            this.life3.Margin = new System.Windows.Forms.Padding(2);
            this.life3.Name = "life3";
            this.life3.Size = new System.Drawing.Size(51, 46);
            this.life3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life3.TabIndex = 2;
            this.life3.TabStop = false;
            // 
            // life2
            // 
            this.life2.Image = global::Flappy_bird_Game.Properties.Resources.h;
            this.life2.Location = new System.Drawing.Point(53, 2);
            this.life2.Margin = new System.Windows.Forms.Padding(2);
            this.life2.Name = "life2";
            this.life2.Size = new System.Drawing.Size(51, 46);
            this.life2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life2.TabIndex = 1;
            this.life2.TabStop = false;
            // 
            // life1
            // 
            this.life1.Image = global::Flappy_bird_Game.Properties.Resources.h;
            this.life1.Location = new System.Drawing.Point(1, 2);
            this.life1.Margin = new System.Windows.Forms.Padding(2);
            this.life1.Name = "life1";
            this.life1.Size = new System.Drawing.Size(51, 46);
            this.life1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life1.TabIndex = 0;
            this.life1.TabStop = false;
            // 
            // score_lbl
            // 
            this.score_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_lbl.Location = new System.Drawing.Point(168, 384);
            this.score_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(299, 46);
            this.score_lbl.TabIndex = 9;
            this.score_lbl.Text = "Score :";
            this.score_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.gameOverLabel.Font = new System.Drawing.Font("MV Boli", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.Location = new System.Drawing.Point(153, 98);
            this.gameOverLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(424, 167);
            this.gameOverLabel.TabIndex = 10;
            this.gameOverLabel.Text = "label1";
            this.gameOverLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gameOverLabel.Visible = false;
            this.gameOverLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // levellbl
            // 
            this.levellbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levellbl.Location = new System.Drawing.Point(474, 385);
            this.levellbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.levellbl.Name = "levellbl";
            this.levellbl.Size = new System.Drawing.Size(202, 46);
            this.levellbl.TabIndex = 12;
            this.levellbl.Text = "Level : 1";
            this.levellbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // restartbtn
            // 
            this.restartbtn.Image = global::Flappy_bird_Game.Properties.Resources.resnewbtn;
            this.restartbtn.Location = new System.Drawing.Point(375, 212);
            this.restartbtn.Name = "restartbtn";
            this.restartbtn.Size = new System.Drawing.Size(154, 38);
            this.restartbtn.TabIndex = 16;
            this.restartbtn.Visible = false;
            this.restartbtn.Click += new System.EventHandler(this.restartbtn_Click);
            // 
            // nxlLevelbtn
            // 
            this.nxlLevelbtn.Image = global::Flappy_bird_Game.Properties.Resources.nextbtn;
            this.nxlLevelbtn.Location = new System.Drawing.Point(197, 212);
            this.nxlLevelbtn.Name = "nxlLevelbtn";
            this.nxlLevelbtn.Size = new System.Drawing.Size(154, 38);
            this.nxlLevelbtn.TabIndex = 15;
            this.nxlLevelbtn.Visible = false;
            this.nxlLevelbtn.Click += new System.EventHandler(this.nxlLevelbtn_Click);
            // 
            // pipe_top2
            // 
            this.pipe_top2.Image = global::Flappy_bird_Game.Properties.Resources.Picture_11;
            this.pipe_top2.Location = new System.Drawing.Point(842, -1);
            this.pipe_top2.Margin = new System.Windows.Forms.Padding(2);
            this.pipe_top2.Name = "pipe_top2";
            this.pipe_top2.Size = new System.Drawing.Size(64, 92);
            this.pipe_top2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe_top2.TabIndex = 13;
            this.pipe_top2.TabStop = false;
            // 
            // exLife
            // 
            this.exLife.Image = global::Flappy_bird_Game.Properties.Resources.h;
            this.exLife.Location = new System.Drawing.Point(311, 46);
            this.exLife.Margin = new System.Windows.Forms.Padding(2);
            this.exLife.Name = "exLife";
            this.exLife.Size = new System.Drawing.Size(40, 37);
            this.exLife.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exLife.TabIndex = 3;
            this.exLife.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::Flappy_bird_Game.Properties.Resources.MAsSR;
            this.ground.Location = new System.Drawing.Point(-2, 358);
            this.ground.Margin = new System.Windows.Forms.Padding(2);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(722, 84);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 7;
            this.ground.TabStop = false;
            // 
            // pipe_bottom
            // 
            this.pipe_bottom.Image = global::Flappy_bird_Game.Properties.Resources.PinClipart1;
            this.pipe_bottom.Location = new System.Drawing.Point(357, 280);
            this.pipe_bottom.Margin = new System.Windows.Forms.Padding(2);
            this.pipe_bottom.Name = "pipe_bottom";
            this.pipe_bottom.Size = new System.Drawing.Size(87, 85);
            this.pipe_bottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe_bottom.TabIndex = 4;
            this.pipe_bottom.TabStop = false;
            this.pipe_bottom.Click += new System.EventHandler(this.pipe_bottom_Click);
            // 
            // pipe_top
            // 
            this.pipe_top.Image = global::Flappy_bird_Game.Properties.Resources.Picture_11;
            this.pipe_top.Location = new System.Drawing.Point(355, -1);
            this.pipe_top.Margin = new System.Windows.Forms.Padding(2);
            this.pipe_top.Name = "pipe_top";
            this.pipe_top.Size = new System.Drawing.Size(64, 92);
            this.pipe_top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe_top.TabIndex = 1;
            this.pipe_top.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = global::Flappy_bird_Game.Properties.Resources.R;
            this.bird.Location = new System.Drawing.Point(40, 142);
            this.bird.Margin = new System.Windows.Forms.Padding(2);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(50, 48);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            this.bird.Click += new System.EventHandler(this.bird_Click);
            // 
            // Game
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(720, 438);
            this.Controls.Add(this.restartbtn);
            this.Controls.Add(this.nxlLevelbtn);
            this.Controls.Add(this.pipe_top2);
            this.Controls.Add(this.levellbl);
            this.Controls.Add(this.exLife);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.score_lbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipe_bottom);
            this.Controls.Add(this.pipe_top);
            this.Controls.Add(this.bird);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Game";
            this.Text = "Flappy Bird Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpEvent);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.life3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_top2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exLife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pipe_top;
        private System.Windows.Forms.PictureBox pipe_bottom;
        private System.Windows.Forms.Timer game_time;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox life3;
        private System.Windows.Forms.PictureBox life2;
        private System.Windows.Forms.PictureBox life1;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.PictureBox exLife;
        private System.Windows.Forms.Label levellbl;
        private System.Windows.Forms.PictureBox pipe_top2;
        private System.Windows.Forms.Label nxlLevelbtn;
        private System.Windows.Forms.Label restartbtn;
    }
}


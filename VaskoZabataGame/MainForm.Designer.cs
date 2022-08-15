namespace VaskoZabataGame
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.Aki = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.musicBtn = new System.Windows.Forms.PictureBox();
            this.Life1 = new System.Windows.Forms.PictureBox();
            this.Life3 = new System.Windows.Forms.PictureBox();
            this.Life2 = new System.Windows.Forms.PictureBox();
            this.Pond = new System.Windows.Forms.PictureBox();
            this.AI2 = new System.Windows.Forms.PictureBox();
            this.AI3 = new System.Windows.Forms.PictureBox();
            this.AI1 = new System.Windows.Forms.PictureBox();
            this.award = new System.Windows.Forms.PictureBox();
            this.blood = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.roadTrack2 = new System.Windows.Forms.PictureBox();
            this.roadTrack1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Life1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Life3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Life2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Pond);
            this.panel1.Controls.Add(this.AI2);
            this.panel1.Controls.Add(this.AI3);
            this.panel1.Controls.Add(this.AI1);
            this.panel1.Controls.Add(this.award);
            this.panel1.Controls.Add(this.blood);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.roadTrack2);
            this.panel1.Controls.Add(this.roadTrack1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 519);
            this.panel1.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(109)))), ((int)(((byte)(0)))));
            this.btnStart.Font = new System.Drawing.Font("Impact", 12F);
            this.btnStart.Location = new System.Drawing.Point(198, 595);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(99, 41);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "S T A R T";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.RestartGame);
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Impact", 15.75F);
            this.txtScore.Location = new System.Drawing.Point(12, 546);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(475, 37);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Score: 0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 650);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Press Left and Right arrow keys to move";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Aki
            // 
            this.Aki.AutoSize = true;
            this.Aki.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.Aki.Location = new System.Drawing.Point(469, 673);
            this.Aki.Name = "Aki";
            this.Aki.Size = new System.Drawing.Size(18, 9);
            this.Aki.TabIndex = 10;
            this.Aki.Text = "A❤";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.label1.Location = new System.Drawing.Point(10, 673);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 9);
            this.label1.TabIndex = 11;
            this.label1.Text = "c y b e r m e h";
            // 
            // musicBtn
            // 
            this.musicBtn.BackColor = System.Drawing.Color.Transparent;
            this.musicBtn.Image = global::VaskoZabataGame.Properties.Resources.musicOn;
            this.musicBtn.Location = new System.Drawing.Point(12, 546);
            this.musicBtn.Name = "musicBtn";
            this.musicBtn.Size = new System.Drawing.Size(35, 35);
            this.musicBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.musicBtn.TabIndex = 9;
            this.musicBtn.TabStop = false;
            this.musicBtn.Tag = "";
            this.musicBtn.Click += new System.EventHandler(this.musicBtnClick);
            // 
            // Life1
            // 
            this.Life1.BackColor = System.Drawing.Color.Transparent;
            this.Life1.Image = global::VaskoZabataGame.Properties.Resources.lifeInactive;
            this.Life1.Location = new System.Drawing.Point(369, 548);
            this.Life1.Name = "Life1";
            this.Life1.Size = new System.Drawing.Size(35, 35);
            this.Life1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Life1.TabIndex = 8;
            this.Life1.TabStop = false;
            this.Life1.Tag = "";
            // 
            // Life3
            // 
            this.Life3.BackColor = System.Drawing.Color.Transparent;
            this.Life3.Image = global::VaskoZabataGame.Properties.Resources.lifeInactive;
            this.Life3.Location = new System.Drawing.Point(450, 548);
            this.Life3.Name = "Life3";
            this.Life3.Size = new System.Drawing.Size(35, 35);
            this.Life3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Life3.TabIndex = 7;
            this.Life3.TabStop = false;
            this.Life3.Tag = "rightStone";
            // 
            // Life2
            // 
            this.Life2.BackColor = System.Drawing.Color.Transparent;
            this.Life2.Image = global::VaskoZabataGame.Properties.Resources.lifeInactive;
            this.Life2.Location = new System.Drawing.Point(409, 548);
            this.Life2.Name = "Life2";
            this.Life2.Size = new System.Drawing.Size(35, 35);
            this.Life2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Life2.TabIndex = 6;
            this.Life2.TabStop = false;
            this.Life2.Tag = "";
            // 
            // Pond
            // 
            this.Pond.BackColor = System.Drawing.Color.White;
            this.Pond.Image = global::VaskoZabataGame.Properties.Resources.pond;
            this.Pond.Location = new System.Drawing.Point(314, 62);
            this.Pond.Name = "Pond";
            this.Pond.Size = new System.Drawing.Size(50, 50);
            this.Pond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Pond.TabIndex = 7;
            this.Pond.TabStop = false;
            this.Pond.Tag = "pond";
            this.Pond.Visible = false;
            // 
            // AI2
            // 
            this.AI2.BackColor = System.Drawing.Color.White;
            this.AI2.Image = global::VaskoZabataGame.Properties.Resources.stone2;
            this.AI2.Location = new System.Drawing.Point(215, 62);
            this.AI2.Name = "AI2";
            this.AI2.Size = new System.Drawing.Size(50, 50);
            this.AI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AI2.TabIndex = 6;
            this.AI2.TabStop = false;
            this.AI2.Tag = "centerStone";
            // 
            // AI3
            // 
            this.AI3.BackColor = System.Drawing.Color.White;
            this.AI3.Image = global::VaskoZabataGame.Properties.Resources.stone3;
            this.AI3.Location = new System.Drawing.Point(422, 62);
            this.AI3.Name = "AI3";
            this.AI3.Size = new System.Drawing.Size(50, 50);
            this.AI3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AI3.TabIndex = 5;
            this.AI3.TabStop = false;
            this.AI3.Tag = "rightStone";
            // 
            // AI1
            // 
            this.AI1.BackColor = System.Drawing.Color.White;
            this.AI1.Image = global::VaskoZabataGame.Properties.Resources.stone1;
            this.AI1.Location = new System.Drawing.Point(76, 62);
            this.AI1.Name = "AI1";
            this.AI1.Size = new System.Drawing.Size(50, 50);
            this.AI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AI1.TabIndex = 5;
            this.AI1.TabStop = false;
            this.AI1.Tag = "leftStone";
            // 
            // award
            // 
            this.award.BackColor = System.Drawing.Color.Transparent;
            this.award.Image = ((System.Drawing.Image)(resources.GetObject("award.Image")));
            this.award.Location = new System.Drawing.Point(76, 165);
            this.award.Name = "award";
            this.award.Size = new System.Drawing.Size(313, 148);
            this.award.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.award.TabIndex = 5;
            this.award.TabStop = false;
            // 
            // blood
            // 
            this.blood.BackColor = System.Drawing.Color.White;
            this.blood.Image = ((System.Drawing.Image)(resources.GetObject("blood.Image")));
            this.blood.Location = new System.Drawing.Point(48, 319);
            this.blood.Name = "blood";
            this.blood.Size = new System.Drawing.Size(35, 35);
            this.blood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.blood.TabIndex = 5;
            this.blood.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.White;
            this.player.Image = global::VaskoZabataGame.Properties.Resources.frog;
            this.player.Location = new System.Drawing.Point(215, 402);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 50);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 5;
            this.player.TabStop = false;
            // 
            // roadTrack2
            // 
            this.roadTrack2.BackColor = System.Drawing.Color.Transparent;
            this.roadTrack2.Location = new System.Drawing.Point(0, 0);
            this.roadTrack2.Name = "roadTrack2";
            this.roadTrack2.Size = new System.Drawing.Size(475, 519);
            this.roadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack2.TabIndex = 4;
            this.roadTrack2.TabStop = false;
            // 
            // roadTrack1
            // 
            this.roadTrack1.Location = new System.Drawing.Point(0, -519);
            this.roadTrack1.Name = "roadTrack1";
            this.roadTrack1.Size = new System.Drawing.Size(475, 519);
            this.roadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack1.TabIndex = 0;
            this.roadTrack1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(499, 691);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Aki);
            this.Controls.Add(this.musicBtn);
            this.Controls.Add(this.Life1);
            this.Controls.Add(this.Life3);
            this.Controls.Add(this.Life2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Vasko Žabata";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Life1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Life3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Life2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox roadTrack2;
        private System.Windows.Forms.PictureBox roadTrack1;
        private System.Windows.Forms.PictureBox AI3;
        private System.Windows.Forms.PictureBox AI1;
        private System.Windows.Forms.PictureBox award;
        private System.Windows.Forms.PictureBox blood;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox AI2;
        private System.Windows.Forms.PictureBox Pond;
        private System.Windows.Forms.PictureBox Life2;
        private System.Windows.Forms.PictureBox Life3;
        private System.Windows.Forms.PictureBox Life1;
        private System.Windows.Forms.PictureBox musicBtn;
        private System.Windows.Forms.Label Aki;
        private System.Windows.Forms.Label label1;
    }
}


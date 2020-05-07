namespace PekMenSimp
{
    partial class Igra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Igra));
            this.TimerMove = new System.Windows.Forms.Timer(this.components);
            this.TimerAnimate = new System.Windows.Forms.Timer(this.components);
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.TimerHeroMelt = new System.Windows.Forms.Timer(this.components);
            this.GameOverBox = new System.Windows.Forms.PictureBox();
            this.Hero = new System.Windows.Forms.PictureBox();
            this.Food = new System.Windows.Forms.PictureBox();
            this.Enemy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GameOverBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerMove
            // 
            this.TimerMove.Interval = 20;
            this.TimerMove.Tick += new System.EventHandler(this.TimerMove_Tick);
            // 
            // TimerAnimate
            // 
            this.TimerAnimate.Tick += new System.EventHandler(this.TimerAnimate_Tick);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ScoreLabel.Location = new System.Drawing.Point(12, 9);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(79, 29);
            this.ScoreLabel.TabIndex = 3;
            this.ScoreLabel.Text = "label1";
            // 
            // TimerHeroMelt
            // 
            this.TimerHeroMelt.Interval = 150;
            this.TimerHeroMelt.Tick += new System.EventHandler(this.TimerHeroMelt_Tick);
            // 
            // GameOverBox
            // 
            this.GameOverBox.BackColor = System.Drawing.Color.Transparent;
            this.GameOverBox.Image = global::PekMenSimp.Properties.Resources.Gameover;
            this.GameOverBox.Location = new System.Drawing.Point(163, 194);
            this.GameOverBox.Name = "GameOverBox";
            this.GameOverBox.Size = new System.Drawing.Size(406, 115);
            this.GameOverBox.TabIndex = 6;
            this.GameOverBox.TabStop = false;
            // 
            // Hero
            // 
            this.Hero.Location = new System.Drawing.Point(104, 100);
            this.Hero.Name = "Hero";
            this.Hero.Size = new System.Drawing.Size(91, 88);
            this.Hero.TabIndex = 0;
            this.Hero.TabStop = false;
            // 
            // Food
            // 
            this.Food.Location = new System.Drawing.Point(294, 138);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(50, 50);
            this.Food.TabIndex = 1;
            this.Food.TabStop = false;
            // 
            // Enemy
            // 
            this.Enemy.Location = new System.Drawing.Point(556, 196);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(80, 80);
            this.Enemy.TabIndex = 2;
            this.Enemy.TabStop = false;
            // 
            // Igra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 457);
            this.Controls.Add(this.GameOverBox);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.Hero);
            this.Controls.Add(this.Food);
            this.Controls.Add(this.Enemy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Igra";
            this.Text = "SimpMan 0.1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Igra_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.GameOverBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Hero;
        private System.Windows.Forms.PictureBox Food;
        private System.Windows.Forms.PictureBox Enemy;
        private System.Windows.Forms.Timer TimerMove;
        private System.Windows.Forms.Timer TimerAnimate;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Timer TimerHeroMelt;
        private System.Windows.Forms.PictureBox GameOverBox;
    }
}


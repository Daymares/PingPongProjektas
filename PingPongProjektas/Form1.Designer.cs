﻿
namespace PingPongProjektas
{
    partial class PingPong
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
            this.Player = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.npc = new System.Windows.Forms.PictureBox();
            this.playerScore = new System.Windows.Forms.Label();
            this.npcScore = new System.Windows.Forms.Label();
            this.timerTicks = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npc)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Player.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Player.Location = new System.Drawing.Point(12, 191);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(30, 150);
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.White;
            this.Ball.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ball.Location = new System.Drawing.Point(350, 250);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(30, 30);
            this.Ball.TabIndex = 1;
            this.Ball.TabStop = false;
            // 
            // npc
            // 
            this.npc.BackColor = System.Drawing.Color.DarkRed;
            this.npc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.npc.Location = new System.Drawing.Point(742, 191);
            this.npc.Name = "npc";
            this.npc.Size = new System.Drawing.Size(30, 150);
            this.npc.TabIndex = 2;
            this.npc.TabStop = false;
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScore.ForeColor = System.Drawing.Color.Lime;
            this.playerScore.Location = new System.Drawing.Point(100, 530);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(21, 24);
            this.playerScore.TabIndex = 3;
            this.playerScore.Text = "0";
            // 
            // npcScore
            // 
            this.npcScore.AutoSize = true;
            this.npcScore.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npcScore.ForeColor = System.Drawing.Color.Lime;
            this.npcScore.Location = new System.Drawing.Point(650, 530);
            this.npcScore.Name = "npcScore";
            this.npcScore.Size = new System.Drawing.Size(21, 24);
            this.npcScore.TabIndex = 4;
            this.npcScore.Text = "0";
            // 
            // timerTicks
            // 
            this.timerTicks.Enabled = true;
            this.timerTicks.Interval = 20;
            // 
            // PingPong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.npcScore);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.npc);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Player);
            this.Name = "PingPong";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PingPong_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDownn);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUpp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox npc;
        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label npcScore;
        private System.Windows.Forms.Timer timerTicks;
    }
}


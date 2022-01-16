using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongProjektas
{
    public partial class PingPong : Form
    {
        public PingPong()
        {
            InitializeComponent();
            
        }

        bool playerGoup; // zaidejas kyla
        bool playerGodown; // zaidejas leidziasi
        int speed = 10; // kokiu greiciu juda platforma
        int xball = 10; // kamuolio x koordinate
        int yball = 10; // kamuolio y koordinate
        int playerPoints = 0;
        int npcPoints = 0;

        private void PingPong_Load(object sender, EventArgs e)
        {
           
        }

        private void keyDownn(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                playerGoup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                playerGodown = true;
            }
        }

        private void keyUpp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                playerGoup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                playerGodown = false;
            }
        }

        private void timerTick(object sender, KeyEventArgs e)
        {
            playerScore.Text = "" + playerScore;
            npcScore.Text = "" + npcScore;

            Ball.Top -= yball;
            Ball.Left -= xball;

            npc.Top += speed;

            if (playerPoints < 5)
            {
                if (npc.Top < 0 || npc.Top > 455)
                {
                    speed = -speed;
                }
            }
            else
            {
                npc.Top = Ball.Top + 30;
            }
        }
    }
}

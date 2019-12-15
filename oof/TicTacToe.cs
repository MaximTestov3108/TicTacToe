using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oof
{
    public partial class TicTacToe : Form
    {
        enum Players
        {
            Not,
            Cross,
            Zero
        }

        Players last_player = Players.Zero;
        Players[] Boxes = new Players[9];
        Players win = Players.Not;
        private void players_replace(Button cur_button, int pos)
        {
            if (last_player == Players.Cross)
            {
                var bmp = new Bitmap(Properties.Resources.пончик);
                cur_button.BackgroundImage = bmp;
                cur_button.BackgroundImageLayout = ImageLayout.Stretch;
                last_player = Players.Zero;
                changes(pos, Players.Zero);
            } else if (last_player == Players.Zero)
            {
                var bmp = new Bitmap(Properties.Resources.салат);
                cur_button.BackgroundImage = bmp;
                cur_button.BackgroundImageLayout = ImageLayout.Stretch;
                last_player = Players.Cross;
                changes(pos, Players.Cross);
            }
            cur_button.Enabled = false;

            end_game();
            if 
        }

        private void end_game()
        {
            if (Boxes[0].Equals(Boxes[1]) && Boxes[0].Equals(Boxes[2]) && !Boxes[0].Equals(Players.Not))
            {
                win = Boxes[0];
            } else if (Boxes[3].Equals(Boxes[4]) && Boxes[3].Equals(Boxes[5]) && !Boxes[3].Equals(Players.Not))
            {
                win = Boxes[3];
            } else if (Boxes[6].Equals(Boxes[7]) && Boxes[6].Equals(Boxes[8]) && !Boxes[6].Equals(Players.Not))
            {
                win = Boxes[6];
            } else if (Boxes[0].Equals(Boxes[4]) && Boxes[0].Equals(Boxes[8]) && !Boxes[0].Equals(Players.Not))
            {
                win = Boxes[0];
            } else if (Boxes[2].Equals(Boxes[4]) && Boxes[2].Equals(Boxes[6]) && !Boxes[2].Equals(Players.Not))
            {
                win = Boxes[2];
            }
        }

        private void changes(int pos, Players player)
        {

            Boxes[pos] = player;
        }

        public TicTacToe()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            players_replace(button1, 0);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            players_replace(button5, 1);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            players_replace(button4, 2);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            players_replace(button9, 3);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            players_replace(button6, 4);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            players_replace(button3, 5);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            players_replace(button8, 6);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            players_replace(button7, 7);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            players_replace(button2, 8);
        }
    }
}

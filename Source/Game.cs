using System;
using System.Drawing;
using System.Windows.Forms;

namespace Visual_tic_tac_toe
{
    public partial class Game : Form
    {
        //Get the name of each player from the register form
        private string player1 = Register.player1;
        private string player2 = Register.player2;

        //Is equals to 1 or 2 depending of the player actually playing
        private int turn = 1;

        //Is equal to true when the game is finished
        private bool finished = false;
        private int[,] map = new int[,]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        public Game()
        {
            InitializeComponent();
            label1.Text = "Actual turn : " + player1;
        }

        /*if opt equals 1 the function tells if the game is finished
        if opt equals 2 the function tells if a player has won or not*/
        private bool GameFinished(int opt)
        {
            if (map[0, 0] == map[0, 1] && map[0, 1] == map[0, 2])
                return (true);
            if (map[1, 0] == map[1, 1] && map[1, 1] == map[1, 2])
                return (true);
            if (map[2, 0] == map[2, 1] && map[2, 1] == map[2, 2])
                return (true);
            if (map[0, 0] == map[1, 1] && map[1, 1] == map[2, 2])
                return (true);
            if (map[0, 2] == map[1, 1] && map[1, 1] == map[2, 0])
                return (true);
            if (map[0, 0] == map[1, 0] && map[1, 0] == map[2, 0])
                return (true);
            if (map[0, 1] == map[1, 1] && map[1, 1] == map[2, 1])
                return (true);
            if (map[0, 2] == map[1, 2] && map[1, 2] == map[2, 2])
                return (true);
            if (opt == 1)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (map[i, j] != 0 && map[i, j] != -1)
                            return (false);
                    }
                }
                return (true);
            }
            return (false);
        }

        //Reverse the actual player after each turn and the text at the top of the form
        private void ActualizeTurn()
        {
            if (turn == 1 && !finished) {
                label1.Text = "Actual turn : " + player2;
                turn = 2;
            } else if (turn == 2 && !finished) {
                label1.Text = "Actual turn : " + player1;
                turn = 1;
            }
        }

        //This function fills the map with -1 for player 1 and 0 for player 2
        private void FillMap(Button my_button)
        {
            int nb = my_button.Text[0] - 48;
            int i = 0;
            int j = 0;

            if (nb >= 1 && nb <= 3) {
                i = 0;
                j = nb - 1;
            } else if (nb >= 4 && nb <= 6) {
                i = 1;
                j = nb - 4;
            } else if (nb >= 7 && nb <=9) {
                i = 2;
                j = nb - 7;
            }
            map[i, j] = turn - 2;
        }

        private string GetPlayerName()
        {
            if (turn == 1)
                return (player1);
            else
                return (player2);
        }

        private string GetEndString()
        {
            string end = "The player " + turn + " (" + GetPlayerName() + ") has won !";

            return (end);
        }

        //This function make sure that each button only get choose only one time
        private void AffectButton(Button my_button)
        {
            if (my_button.BackColor == Color.FromName("Control") && !GameFinished(1))
            {
                if (turn == 1)
                    my_button.BackColor = Color.FromName("Lime");
                else
                    my_button.BackColor = Color.FromName("Cyan");
                ActualizeTurn();
                FillMap(my_button);
            }
            if (GameFinished(1))
            {
                ActualizeTurn();
                finished = true;
                if (GameFinished(2))
                    MessageBox.Show(GetEndString(), "Game finished", MessageBoxButtons.OK, MessageBoxIcon.None);
                else
                    MessageBox.Show("Nobody won !", "Game finished", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AffectButton((Button)sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AffectButton((Button)sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AffectButton((Button)sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AffectButton((Button)sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AffectButton((Button)sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AffectButton((Button)sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AffectButton((Button)sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AffectButton((Button)sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AffectButton((Button)sender);
        }

        //Function that make sure you want to exit the program
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit the application ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                e.Cancel = true;
        }
    }
}

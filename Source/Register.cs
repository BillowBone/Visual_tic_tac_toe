using System;
using System.Windows.Forms;

namespace Visual_tic_tac_toe
{
    public partial class Register : Form
    {
        public static string player1 = null;
        public static string player2 = null;

        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && player1 == null && textBox1.Text.Length < 17)
            {
                player1 = textBox1.Text;
                textBox1.Text = "";
                label1.Text = "Enter the name of the player 2";
            }
            else if (textBox1.Text.Length > 0 && player1 != null && player1 != textBox1.Text && textBox1.Text.Length < 17)
            {
                player2 = textBox1.Text;
                label1.Dispose();
                textBox1.Dispose();
                button1.Dispose();
                this.Close();
            }
        }
    }
}

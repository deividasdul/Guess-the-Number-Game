using System;

namespace Guess_the_Number_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            computerOutputBox.Text = Convert.ToString(random.Next(100));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userInputBox.Text == computerOutputBox.Text)
            {
                MessageBox.Show("You've won!");
                computerOutputBox.PasswordChar = '\0';
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(userInputBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Your input must be a number!");
            }
            else
            {
                if (Convert.ToInt32(userInputBox.Text) < Convert.ToInt32(computerOutputBox.Text))
                {
                    MessageBox.Show("Too low!");
                }
                else
                {
                    MessageBox.Show("Too high!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            computerOutputBox.PasswordChar = '*';
            userInputBox.Text = string.Empty;
            Random random = new Random();
            computerOutputBox.Text = Convert.ToString(random.Next(100));
        }
    }
}
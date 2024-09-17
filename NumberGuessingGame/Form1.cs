namespace NumberGuessingGame
{
    public partial class Form1 : Form
    {
        private int targetNumber;
        private int attempts;

        public Form1()
        {
            InitializeComponent();
            StartNewGame();
        }

        private void StartNewGame()
        {
            Random random = new Random();
            targetNumber = random.Next(1, 101); 
            attempts = 0;
            lblMessage.Text = "Guess a number between 1 and 100";
            txtGuess.Clear();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            int userGuess;
            if (int.TryParse(txtGuess.Text, out userGuess))
            {
                attempts++; 
                if (userGuess == targetNumber)
                {
                    lblMessage.Text = $"Congratulations! You guessed the number in {attempts} attempts";
                }
                else if(userGuess > 100)
                {
                    lblMessage.Text = $"The number {userGuess} is greater than 100, please enter the appropriate number ";
                }
                else if (userGuess < targetNumber)
                {
                    lblMessage.Text = "Too low! Try again";
                }
                else
                {
                    lblMessage.Text = "Too high! Try again";
                }
            }
            else
            {
                lblMessage.Text = "Please enter a valid number";
            }

            txtGuess.Clear();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void txtGuess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGuess_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
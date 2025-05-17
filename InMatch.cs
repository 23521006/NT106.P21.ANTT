namespace GameNT106
{
    public partial class InMatch : Form
    {
        string playerChoice;
        string opponentChoice;
        string[] Options = { "R", "P", "S", "R", "P", "S", "R", "P", "S", "R", "P", "S", "R", "P", "S", "R", "P", "S", "R", "P", "S", "R", "P", "S" };
        Random random = new Random();
        int opponentScore;
        int playerScore;
        string resultPlayer, resultOpponent;

        public InMatch()
        {
            InitializeComponent();
        }

        private void MakeChoice(object sender, EventArgs e)
        {
            Button tempButton = sender as Button;
            playerChoice = (string)tempButton.Tag;
            int i = random.Next(0, Options.Length);
            opponentChoice = Options[i];
            UpdateTextandImage(playerChoice, pictureBoxPlayer);
            UpdateTextandImage(opponentChoice, pictureBoxOpponent);
            CheckGame();
        }

        private void UpdateTextandImage(string text, PictureBox pic)
        {
            switch (text)
            {
                case "R":
                    pic.Image = Properties.Resources.ROCK;
                    break;
                case "P":
                    pic.Image = Properties.Resources.PAPER;
                    break;
                case "S":
                    pic.Image = Properties.Resources.SCISSORS;
                    break;
            }
        }
        private void CheckGame()
        {
            if (opponentChoice == playerChoice)
            {
                resultPlayer = "Draw!";
                resultOpponent = "Draw!";
            }
            else if ((playerChoice == "R" && opponentChoice == "P") || (playerChoice == "S" && opponentChoice == "R") || (playerChoice == "P" && opponentChoice == "S"))
            {
                opponentScore++;
                resultOpponent = "Win!";
                resultPlayer = "Lose!";
            }
            else
            {
                playerScore++;
                resultOpponent = "Lose!";
                resultPlayer = "Win!";
            }

            labelPlayerScore.Text = "Your Score: " + playerScore + Environment.NewLine + resultPlayer;
            labelOpponentScore.Text = "Opponent's Score: " + opponentScore + Environment.NewLine + resultOpponent;
        }
    }
}

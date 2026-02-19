using System.Windows.Forms;

namespace start
{
    public partial class MainForm : Form
    {
        private const int labelSize = 70;
        private const int padding = 6;
        private const int startX = 10;
        private const int startY = 70;

        private int mapSize = 4;
        private Label[,] LabelsMap;
        private int score = 0;
        private int bestScore = 0;
        private string userName;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var startForm = new StartForm();
            startForm.ShowDialog();
            userName = startForm.userNameTextBox.Text;

            CalculateMapSize(startForm.radioButtons);

            InitMap();
            GenerateNumber();
            ShowScore();
            CalculateBestScore();
        }

        private void CalculateMapSize(List<RadioButton> radioButtons)
        {
            foreach (var radioButton in radioButtons)
            {
                if (radioButton.Checked)
                {
                    mapSize = Convert.ToInt32(radioButton.Text[0].ToString());
                    break;
                }
            }
        }

        private void CalculateBestScore()
        {
            var users = UserManager.GetAll();

            if (users.Count == 0)
            {
                return;
            }

            bestScore = users[0].Score;

            foreach (var user in users)
            {
                if (user.Score > bestScore)
                {
                    bestScore = user.Score;
                }
            }

            ShowBestScore();
        }

        private void ShowBestScore()
        {
            if (score > bestScore)
            {
                bestScore = score;
            }

            bestScoreResultLabel.Text = bestScore.ToString();
        }

        private void ShowScore()
        {
            scoreResultLabel.Text = score.ToString();
        }

        private void InitMap()
        {
            ClientSize = new Size(startX + (labelSize + padding) * mapSize, startY + (labelSize + padding) * mapSize);

            LabelsMap = new Label[mapSize, mapSize];

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newLabel = CreateLabel(i, j);
                    Controls.Add(newLabel);
                    LabelsMap[i, j] = newLabel;
                }
            }
        }

        private void GenerateNumber()
        {
            var random = new Random();

            while (true)
            {
                var randomNumberLabel = random.Next(mapSize * mapSize);
                var indexRow = randomNumberLabel / mapSize;
                var indexCol = randomNumberLabel % mapSize;

                if (LabelsMap[indexRow, indexCol].Text == string.Empty)
                {
                    var randomNumber = random.Next(1, 101);

                    if (randomNumber <= 75)
                    {
                        LabelsMap[indexRow, indexCol].Text = "2";
                    }
                    else
                    {
                        LabelsMap[indexRow, indexCol].Text = "4";
                    }

                    break;
                }
            }
        }

        private Label CreateLabel(int indexRow, int indexColumn)
        {
            var label = new Label();
            label.BackColor = SystemColors.ButtonShadow;
            label.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            label.Size = new Size(labelSize, labelSize);
            label.TextAlign = ContentAlignment.MiddleCenter;
            var x = startX + indexColumn * (labelSize + padding);
            var y = startY + indexRow * (labelSize + padding);
            label.Location = new Point(x, y);

            label.TextChanged += Label_TextChanged;

            return label;
        }

        private void Label_TextChanged(object? sender, EventArgs e)
        {
            var label = (Label)sender;

            switch(label.Text)
            {
                case "": label.BackColor = SystemColors.ButtonShadow; break;
                case "2": label.BackColor = Color.FromArgb(238, 228, 218); break;
                case "4": label.BackColor = Color.FromArgb(237, 224, 200); break;
                case "8": label.BackColor = Color.FromArgb(242, 177, 121); break;
                case "16": label.BackColor = Color.FromArgb(245, 149, 99); break;
                case "32": label.BackColor = Color.FromArgb(246, 124, 95); break;
                case "64": label.BackColor = Color.FromArgb(246, 94, 59); break;
                case "128": label.BackColor = Color.FromArgb(237, 207, 114); break;
                case "256": label.BackColor = Color.FromArgb(237, 204, 97); break;
                case "512": label.BackColor = Color.FromArgb(237, 200, 80); break;
                case "1024": label.BackColor = Color.FromArgb(237, 197, 63); break;
                case "2048": label.BackColor = Color.FromArgb(237, 194, 46); break;                
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Right && e.KeyCode != Keys.Left && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down)
            {
                return;
            }

            if (e.KeyCode == Keys.Right)
            {
                MoveRight();
            }

            if (e.KeyCode == Keys.Left)
            {
                MoveLeft();
            }

            if (e.KeyCode == Keys.Up)
            {
                MoveUp();
            }

            if (e.KeyCode == Keys.Down)
            {
                MoveDown();
            }

            GenerateNumber();
            ShowScore();
            ShowBestScore();

            if (Win())
            {
                UserManager.Add(new User() { Name = userName + score, Score = score });
                MessageBox.Show("You ara winner!");
                return;
            }

            if (EndGame())
            {
                UserManager.Add(new User() { Name = userName + score, Score = score });
                MessageBox.Show("Game over!");
                return;
            }
        }

        private void MoveDown()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (LabelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (LabelsMap[k, j].Text != string.Empty)
                            {
                                if (LabelsMap[i, j].Text == LabelsMap[k, j].Text)
                                {
                                    var number = int.Parse(LabelsMap[i, j].Text);
                                    LabelsMap[i, j].Text = (number * 2).ToString();
                                    score += number * 2;
                                    LabelsMap[k, j].Text = string.Empty;
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (LabelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (LabelsMap[k, j].Text != string.Empty)
                            {
                                LabelsMap[i, j].Text = LabelsMap[k, j].Text;
                                LabelsMap[k, j].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MoveUp()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (LabelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (LabelsMap[k, j].Text != string.Empty)
                            {
                                if (LabelsMap[i, j].Text == LabelsMap[k, j].Text)
                                {
                                    var number = int.Parse(LabelsMap[i, j].Text);
                                    LabelsMap[i, j].Text = (number * 2).ToString();
                                    score += number * 2;
                                    LabelsMap[k, j].Text = string.Empty;
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (LabelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (LabelsMap[k, j].Text != string.Empty)
                            {
                                LabelsMap[i, j].Text = LabelsMap[k, j].Text;
                                LabelsMap[k, j].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MoveLeft()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (LabelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (LabelsMap[i, k].Text != string.Empty)
                            {
                                if (LabelsMap[i, j].Text == LabelsMap[i, k].Text)
                                {
                                    var number = int.Parse(LabelsMap[i, j].Text);
                                    LabelsMap[i, j].Text = (number * 2).ToString();
                                    score += number * 2;
                                    LabelsMap[i, k].Text = string.Empty;
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (LabelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (LabelsMap[i, k].Text != string.Empty)
                            {
                                LabelsMap[i, j].Text = LabelsMap[i, k].Text;
                                LabelsMap[i, k].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MoveRight()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (LabelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (LabelsMap[i, k].Text != string.Empty)
                            {
                                if (LabelsMap[i, j].Text == LabelsMap[i, k].Text)
                                {
                                    var number = int.Parse(LabelsMap[i, j].Text);
                                    LabelsMap[i, j].Text = (number * 2).ToString();
                                    score += number * 2;
                                    LabelsMap[i, k].Text = string.Empty;
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (LabelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (LabelsMap[i, k].Text != string.Empty)
                            {
                                LabelsMap[i, j].Text = LabelsMap[i, k].Text;
                                LabelsMap[i, k].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private bool Win()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (LabelsMap[i, j].Text == "2048")
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool EndGame()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (LabelsMap[i, j].Text == "")
                    {
                        return false;
                    }
                }
            }

            for (int i = 0; i < mapSize - 1; i++)
            {
                for (int j = 0; j < mapSize - 1; j++)
                {
                    if (LabelsMap[i, j].Text == LabelsMap[i, j + 1].Text || LabelsMap[i, j].Text == LabelsMap[i + 1, j].Text)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRules();
        }

        private void RestartGame()
        {
            // Add current game to history before restarting
            if (score > 0)
            {
                AddToGameHistory();
            }

            // Reset current score but keep best score
            score = 0;
            ShowScore();

            // Clear the board
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    LabelsMap[i, j].Text = string.Empty;
                }
            }

            // Generate initial numbers with 75% chance of 2 and 25% chance of 4
            GenerateNumber();
            GenerateNumber();
        }

        private void ShowRules()
        {
            RulesForm rulesForm = new RulesForm();
            rulesForm.ShowDialog();
        }

        private void LoadBestScore()
        {
            string bestScorePath = Path.Combine(Application.StartupPath, "bestscore.txt");
            if (File.Exists(bestScorePath))
            {
                string content = File.ReadAllText(bestScorePath);
                if (int.TryParse(content, out int savedBestScore))
                {
                    bestScore = savedBestScore;
                }
            }
        }

        private void SaveBestScore()
        {
            string bestScorePath = Path.Combine(Application.StartupPath, "bestscore.txt");
            File.WriteAllText(bestScorePath, bestScore.ToString());
        }

        //private void LoadGameHistory()
        //{
        //    gameHistory = new List<(string playerName, int score, DateTime date)>();
        //    string historyPath = Path.Combine(Application.StartupPath, "history.txt");
        //    if (File.Exists(historyPath))
        //    {
        //        string[] lines = File.ReadAllLines(historyPath);
        //        foreach (string line in lines)
        //        {
        //            string[] parts = line.Split('|');
        //            if (parts.Length == 3 &&
        //                int.TryParse(parts[1], out int savedScore) &&
        //                DateTime.TryParse(parts[2], out DateTime savedDate))
        //            {
        //                gameHistory.Add((parts[0], savedScore, savedDate));
        //            }
        //        }
        //    }
        //}

        private void SaveGameHistory()
        {
            string historyPath = Path.Combine(Application.StartupPath, "history.txt");
            List<string> lines = new List<string>();
            //foreach (var record in gameHistory)
            //{
            //    lines.Add($"{record.playerName}|{record.score}|{record.date}");
            //}
            File.WriteAllLines(historyPath, lines);
        }

        private void UpdateBestScore()
        {
            if (score > bestScore)
            {
                bestScore = score;
                SaveBestScore();
            }
        }

        private void AddToGameHistory()
        {
            // Prompt user for their name
            string playerName = PromptForPlayerName();
            //if (!string.IsNullOrEmpty(playerName))
            //{
            //    gameHistory.Add((playerName, score, DateTime.Now));
            //    SaveGameHistory();
            //}
        }

        private string PromptForPlayerName()
        {
            using (var form = new Form())
            {
                form.Text = "Введите имя";
                form.Size = new System.Drawing.Size(300, 150);
                form.StartPosition = FormStartPosition.CenterParent;
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.MaximizeBox = false;
                form.MinimizeBox = false;

                var label = new Label() { Left = 10, Top = 20, Text = "Введите ваше имя:", Width = 280 };
                var textBox = new TextBox() { Left = 10, Top = 45, Width = 260 };
                var okButton = new Button() { Text = "OK", Left = 100, Width = 80, Top = 80, DialogResult = DialogResult.OK };

                form.Controls.Add(label);
                form.Controls.Add(textBox);
                form.Controls.Add(okButton);

                form.AcceptButton = okButton;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    return textBox.Text.Trim();
                }
                return string.Empty;
            }
        }

        //private void HistoryToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    HistoryForm historyForm = new HistoryForm();
        //    historyForm.SetHistoryData(gameHistory);
        //    historyForm.ShowDialog();
        //}

        private void рестартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void правилаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Правила игры:");
        }

        private void показатьРезультатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultsForm = new ResultsForm();
            resultsForm.ShowDialog();
        }
    }
}

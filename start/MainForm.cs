namespace start
{
    public partial class MainForm : Form
    {
        private const int mapSize = 4;
        private Label[,] LabelsMap;
        private static Random random = new Random();
        private int score = 0;
        private int bestScore = 0;
        private List<(string playerName, int score, DateTime date)> gameHistory;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBestScore();
            LoadGameHistory();
            //RestartGame();
            InitMap();
            GenerateNumber();
            GenerateNumber();
            ShowScore();
        }

        private void ShowScore()
        {
            scoreLabel.Text = $"Текущий: {score} | Лучший: {bestScore}";
        }

        private void InitMap()
        {
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
            while (true)
            {
                var randomNumberLabel = random.Next(mapSize * mapSize);
                var indexRow = randomNumberLabel / mapSize;
                var indexCol = randomNumberLabel % mapSize;

                if (LabelsMap[indexRow, indexCol].Text == string.Empty)
                {
                    // Generate 2 with 75% probability and 4 with 25% probability
                    int numberToPlace = random.Next(100) < 75 ? 2 : 4;
                    LabelsMap[indexRow, indexCol].Text = numberToPlace.ToString();
                    break;
                }
            }
        }

        private Label CreateLabel(int indexRow, int indexColumn)
        {
            var label = new Label();
            label.BackColor = SystemColors.ButtonShadow;
            label.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            label.Size = new Size(70, 70);
            label.TextAlign = ContentAlignment.MiddleCenter;
            var x = 10 + indexColumn * 76;
            var y = 70 + indexRow * 76;
            label.Location = new Point(x, y);

            return label;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
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

            if (e.KeyCode == Keys.Left)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = 0; j < mapSize; j++)
                    {
                        if (LabelsMap[i, j].Text != string.Empty)
                        {
                            for (int k = j + 1 ; k < mapSize; k++)
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

            if (e.KeyCode == Keys.Up)
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

            if (e.KeyCode == Keys.Down)
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

            GenerateNumber();
            UpdateBestScore();
            ShowScore();
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

        private void LoadGameHistory()
        {
            gameHistory = new List<(string playerName, int score, DateTime date)>();
            string historyPath = Path.Combine(Application.StartupPath, "history.txt");
            if (File.Exists(historyPath))
            {
                string[] lines = File.ReadAllLines(historyPath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3 &&
                        int.TryParse(parts[1], out int savedScore) &&
                        DateTime.TryParse(parts[2], out DateTime savedDate))
                    {
                        gameHistory.Add((parts[0], savedScore, savedDate));
                    }
                }
            }
        }

        private void SaveGameHistory()
        {
            string historyPath = Path.Combine(Application.StartupPath, "history.txt");
            List<string> lines = new List<string>();
            foreach (var record in gameHistory)
            {
                lines.Add($"{record.playerName}|{record.score}|{record.date}");
            }
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
            if (!string.IsNullOrEmpty(playerName))
            {
                gameHistory.Add((playerName, score, DateTime.Now));
                SaveGameHistory();
            }
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

        private void HistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            historyForm.SetHistoryData(gameHistory);
            historyForm.ShowDialog();
        }
    }
}

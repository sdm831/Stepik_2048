using System;
using System.Windows.Forms;

namespace start
{
    public partial class HistoryForm : Form
    {
        private BindingSource bindingSource;
        private DataGridView dataGridView;

        public HistoryForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "История игр";
            this.Size = new System.Drawing.Size(500, 400);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimizeBox = true;

            // Create controls
            this.dataGridView = new DataGridView();
            var closeButton = new Button();

            // Configure DataGridView
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Size = new System.Drawing.Size(460, 300);
            this.dataGridView.AutoGenerateColumns = true;
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = true;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.MultiSelect = false;
            this.dataGridView.RowHeadersVisible = false;
            
            // Create columns
            this.dataGridView.Columns.Add("PlayerName", "Игрок");
            this.dataGridView.Columns.Add("Score", "Очки");
            this.dataGridView.Columns.Add("Date", "Дата");

            // Configure Close button
            closeButton.Location = new System.Drawing.Point(210, 320);
            closeButton.Size = new System.Drawing.Size(80, 30);
            closeButton.Text = "Закрыть";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += (sender, e) => this.Close();

            // Add controls to form
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(closeButton);

            // Set up data binding
            this.bindingSource = new BindingSource();
            this.dataGridView.DataSource = this.bindingSource;
        }

        public void SetHistoryData(System.Collections.Generic.List<(string playerName, int score, DateTime date)> history)
        {
            // Clear existing data
            this.bindingSource.Clear();

            // Add history data to the grid
            foreach (var record in history)
            {
                this.bindingSource.Add(new { 
                    PlayerName = record.playerName, 
                    Score = record.score, 
                    Date = record.date.ToString("dd.MM.yyyy HH:mm") 
                });
            }

            // Format the grid
            if (this.dataGridView.Columns.Count >= 3)
            {
                this.dataGridView.Columns["PlayerName"].Width = 150;
                this.dataGridView.Columns["Score"].Width = 100;
                this.dataGridView.Columns["Score"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.dataGridView.Columns["Date"].Width = 150;
            }
        }
    }
}
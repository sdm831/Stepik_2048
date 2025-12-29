using System;
using System.Windows.Forms;

namespace start
{
    public partial class RulesForm : Form
    {
        public RulesForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Правила игры";
            this.Size = new System.Drawing.Size(400, 300);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Create controls
            var richTextBox = new RichTextBox();
            var okButton = new Button();

            // Configure RichTextBox
            richTextBox.Location = new System.Drawing.Point(12, 12);
            richTextBox.Size = new System.Drawing.Size(360, 200);
            richTextBox.ReadOnly = true;
            richTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox.Text = "Правила игры 2048:\n\n" +
                              "1. Используйте клавиши со стрелками для перемещения плиток.\n" +
                              "2. При перемещении одинаковые числа объединяются в одно (суммируются).\n" +
                              "3. Цель игры - получить плитку с числом 2048.\n" +
                              "4. Игра заканчивается, когда на поле нет свободных клеток и нельзя сделать ход.\n\n" +
                              "Дополнительная информация:\n" +
                              "- После каждого хода появляется новая плитка (2 или 4)\n" +
                              "- Вы получаете очки за объединение плиток\n" +
                              "- Играйте как можно дольше, чтобы набрать больше очков!";

            // Configure OK button
            okButton.Location = new System.Drawing.Point(160, 220);
            okButton.Size = new System.Drawing.Size(80, 30);
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += (sender, e) => this.Close();

            // Add controls to form
            this.Controls.Add(richTextBox);
            this.Controls.Add(okButton);
        }
    }
}
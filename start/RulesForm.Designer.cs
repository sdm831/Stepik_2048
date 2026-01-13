namespace start
{
    partial class RulesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Text = "Правила игры";
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Create and configure RichTextBox
            var richTextBox = new System.Windows.Forms.RichTextBox();
            richTextBox.Location = new System.Drawing.Point(12, 12);
            richTextBox.Size = new System.Drawing.Size(360, 200);
            richTextBox.ReadOnly = true;
            richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            richTextBox.Name = "richTextBoxRules";
            richTextBox.TabIndex = 0;
            richTextBox.Text = "Правила игры 2048:\n\n" +
                              "1. Используйте клавиши со стрелками для перемещения плиток.\n" +
                              "2. При перемещении одинаковые числа объединяются в одно (суммируются).\n" +
                              "3. Цель игры - получить плитку с числом 2048.\n" +
                              "4. Игра заканчивается, когда на поле нет свободных клеток и нельзя сделать ход.\n\n" +
                              "Дополнительная информация:\n" +
                              "- После каждого хода появляется новая плитка (2 или 4)\n" +
                              "- Вы получаете очки за объединение плиток\n" +
                              "- Играйте как можно дольше, чтобы набрать больше очков!";

            // Create and configure OK button
            var okButton = new System.Windows.Forms.Button();
            okButton.Location = new System.Drawing.Point(160, 220);
            okButton.Size = new System.Drawing.Size(80, 30);
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Name = "buttonOK";
            okButton.TabIndex = 1;
            okButton.Click += new System.EventHandler(this.OkButton_Click);

            // Add controls to form
            this.Controls.Add(richTextBox);
            this.Controls.Add(okButton);
        }

        #endregion

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
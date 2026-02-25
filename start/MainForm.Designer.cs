
namespace start
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            правилаToolStripMenuItem = new ToolStripMenuItem();
            рестартToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            показатьРезультатыToolStripMenuItem = new ToolStripMenuItem();
            scoreLabel = new Label();
            scoreResultLabel = new Label();
            bestScoreResultLabel = new Label();
            bestScoreLabel = new Label();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 28);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(319, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, показатьРезультатыToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(319, 28);
            menuStrip2.TabIndex = 3;
            menuStrip2.Text = "menuStrip2";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { правилаToolStripMenuItem, рестартToolStripMenuItem, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // правилаToolStripMenuItem
            // 
            правилаToolStripMenuItem.Name = "правилаToolStripMenuItem";
            правилаToolStripMenuItem.Size = new Size(153, 26);
            правилаToolStripMenuItem.Text = "Правила";
            правилаToolStripMenuItem.Click += правилаToolStripMenuItem_Click;
            // 
            // рестартToolStripMenuItem
            // 
            рестартToolStripMenuItem.Name = "рестартToolStripMenuItem";
            рестартToolStripMenuItem.Size = new Size(153, 26);
            рестартToolStripMenuItem.Text = "Рестарт";
            рестартToolStripMenuItem.Click += рестартToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(153, 26);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // показатьРезультатыToolStripMenuItem
            // 
            показатьРезультатыToolStripMenuItem.Name = "показатьРезультатыToolStripMenuItem";
            показатьРезультатыToolStripMenuItem.Size = new Size(169, 24);
            показатьРезультатыToolStripMenuItem.Text = "Показать результаты";
            показатьРезультатыToolStripMenuItem.Click += показатьРезультатыToolStripMenuItem_Click;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(10, 32);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(43, 20);
            scoreLabel.TabIndex = 4;
            scoreLabel.Text = "Счет:";
            // 
            // scoreResultLabel
            // 
            scoreResultLabel.AutoSize = true;
            scoreResultLabel.Location = new Point(58, 32);
            scoreResultLabel.Name = "scoreResultLabel";
            scoreResultLabel.Size = new Size(17, 20);
            scoreResultLabel.TabIndex = 5;
            scoreResultLabel.Text = "0";
            // 
            // bestScoreResultLabel
            // 
            bestScoreResultLabel.AutoSize = true;
            bestScoreResultLabel.Location = new Point(240, 32);
            bestScoreResultLabel.Name = "bestScoreResultLabel";
            bestScoreResultLabel.Size = new Size(17, 20);
            bestScoreResultLabel.TabIndex = 7;
            bestScoreResultLabel.Text = "0";
            // 
            // bestScoreLabel
            // 
            bestScoreLabel.AutoSize = true;
            bestScoreLabel.Location = new Point(96, 32);
            bestScoreLabel.Name = "bestScoreLabel";
            bestScoreLabel.Size = new Size(138, 20);
            bestScoreLabel.TabIndex = 6;
            bestScoreLabel.Text = "Лучший результат:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 421);
            Controls.Add(bestScoreResultLabel);
            Controls.Add(bestScoreLabel);
            Controls.Add(scoreResultLabel);
            Controls.Add(scoreLabel);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "2048";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem правилаToolStripMenuItem;
        private ToolStripMenuItem рестартToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem показатьРезультатыToolStripMenuItem;
        private Label scoreLabel;
        private Label scoreResultLabel;
        private Label bestScoreResultLabel;
        private Label bestScoreLabel;
    }
}

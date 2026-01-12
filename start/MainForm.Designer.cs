
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
            this.menuStrip1 = new MenuStrip();
            this.gameToolStripMenuItem = new ToolStripMenuItem();
            this.newGameToolStripMenuItem = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.exitToolStripMenuItem = new ToolStripMenuItem();
            this.helpToolStripMenuItem = new ToolStripMenuItem();
            this.historyToolStripMenuItem = new ToolStripMenuItem();
            this.rulesToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            scoreLabel = new Label();
            this.menuStrip1.SuspendLayout();
            SuspendLayout();
            //
            // menuStrip1
            //
            this.menuStrip1.ImageScalingSize = new Size(20, 20);
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new Size(319, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            //
            // gameToolStripMenuItem
            //
            this.gameToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new Size(69, 24);
            this.gameToolStripMenuItem.Text = "Игра";
            //
            // newGameToolStripMenuItem
            //
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new Size(180, 26);
            this.newGameToolStripMenuItem.Text = "Новая игра";
            this.newGameToolStripMenuItem.Click += new EventHandler(this.NewGameToolStripMenuItem_Click);
            //
            // toolStripSeparator1
            //
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(177, 6);
            //
            // exitToolStripMenuItem
            //
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new Size(180, 26);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new EventHandler(this.ExitToolStripMenuItem_Click);
            //
            // helpToolStripMenuItem
            //
            this.helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.historyToolStripMenuItem,
            this.rulesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new Size(83, 24);
            this.helpToolStripMenuItem.Text = "Справка";
            //
            // historyToolStripMenuItem
            //
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new Size(180, 26);
            this.historyToolStripMenuItem.Text = "История";
            this.historyToolStripMenuItem.Click += new EventHandler(this.HistoryToolStripMenuItem_Click);
            //
            // rulesToolStripMenuItem
            //
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new Size(180, 26);
            this.rulesToolStripMenuItem.Text = "Правила";
            this.rulesToolStripMenuItem.Click += new EventHandler(this.RulesToolStripMenuItem_Click);
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Location = new Point(22, 40);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 0;
            label1.Text = "Счет: ";
            //
            // scoreLabel
            //
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(75, 40);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(17, 20);
            scoreLabel.TabIndex = 1;
            scoreLabel.Text = "0";
            //
            // MainForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 421);
            Controls.Add(scoreLabel);
            Controls.Add(label1);
            Controls.Add(this.menuStrip1);
            MainMenuStrip = this.menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "2048";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gameToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem historyToolStripMenuItem;
        private ToolStripMenuItem rulesToolStripMenuItem;
        private Label label1;
        private Label scoreLabel;
    }
}

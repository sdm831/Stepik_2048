namespace start
{
    partial class StartForm
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
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            userNamelabel = new Label();
            userNameTextBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(66, 10);
            label1.Name = "label1";
            label1.Size = new Size(238, 28);
            label1.TabIndex = 0;
            label1.Text = "Выберете размер поля";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            radioButton1.Location = new Point(56, 59);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(60, 27);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "4x4";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            radioButton2.Location = new Point(246, 59);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(58, 27);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "6x6";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            radioButton3.Location = new Point(148, 59);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(58, 27);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "5x5";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            radioButton4.Location = new Point(348, 59);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(58, 27);
            radioButton4.TabIndex = 4;
            radioButton4.TabStop = true;
            radioButton4.Text = "7x7";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // userNamelabel
            // 
            userNamelabel.AutoSize = true;
            userNamelabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            userNamelabel.Location = new Point(67, 144);
            userNamelabel.Name = "userNamelabel";
            userNamelabel.Size = new Size(139, 28);
            userNamelabel.TabIndex = 5;
            userNamelabel.Text = "Введите имя";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(67, 194);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(222, 27);
            userNameTextBox.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(67, 247);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Начать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(userNameTextBox);
            Controls.Add(userNamelabel);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Name = "StartForm";
            Text = "StartForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label userNamelabel;
        public TextBox userNameTextBox;
        private Button button1;
    }
}
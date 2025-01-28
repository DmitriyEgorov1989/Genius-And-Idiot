namespace GeniyIdiotWinFormsApp
{
    partial class AddNewQuestionsForm
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
            questinLabel = new Label();
            addQuestinTextBox = new TextBox();
            answerLabel = new Label();
            addButton = new Button();
            menuStrip1 = new MenuStrip();
            stripMenuItem = new ToolStripMenuItem();
            mainMenuItem = new ToolStripMenuItem();
            exitMenuItem = new ToolStripMenuItem();
            answerNumericUpDown = new NumericUpDown();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)answerNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // questinLabel
            // 
            questinLabel.AutoSize = true;
            questinLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            questinLabel.Location = new Point(126, 41);
            questinLabel.Name = "questinLabel";
            questinLabel.Size = new Size(247, 28);
            questinLabel.TabIndex = 0;
            questinLabel.Text = "Введите новый вопрос!";
            // 
            // addQuestinTextBox
            // 
            addQuestinTextBox.Location = new Point(126, 107);
            addQuestinTextBox.Name = "addQuestinTextBox";
            addQuestinTextBox.Size = new Size(567, 27);
            addQuestinTextBox.TabIndex = 1;
            // 
            // answerLabel
            // 
            answerLabel.AutoSize = true;
            answerLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            answerLabel.Location = new Point(126, 218);
            answerLabel.Name = "answerLabel";
            answerLabel.Size = new Size(159, 28);
            answerLabel.TabIndex = 2;
            answerLabel.Text = "Введите ответ!";
            // 
            // addButton
            // 
            addButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addButton.Location = new Point(260, 333);
            addButton.Name = "addButton";
            addButton.Size = new Size(277, 57);
            addButton.TabIndex = 4;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { stripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // stripMenuItem
            // 
            stripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mainMenuItem, exitMenuItem });
            stripMenuItem.Name = "stripMenuItem";
            stripMenuItem.Size = new Size(65, 24);
            stripMenuItem.Text = "Меню";
            // 
            // mainMenuItem
            // 
            mainMenuItem.Name = "mainMenuItem";
            mainMenuItem.Size = new Size(193, 26);
            mainMenuItem.Text = "Главное меню";
            mainMenuItem.Click += MainMenuItem_Click;
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new Size(193, 26);
            exitMenuItem.Text = "Выйти";
            exitMenuItem.Click += ExitMenuItem_Click;
            // 
            // answerNumericUpDown
            // 
            answerNumericUpDown.Location = new Point(126, 275);
            answerNumericUpDown.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            answerNumericUpDown.Name = "answerNumericUpDown";
            answerNumericUpDown.Size = new Size(567, 27);
            answerNumericUpDown.TabIndex = 6;
            // 
            // AddNewQuestinsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(answerNumericUpDown);
            Controls.Add(addButton);
            Controls.Add(answerLabel);
            Controls.Add(addQuestinTextBox);
            Controls.Add(questinLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AddNewQuestinsForm";
            Text = "Добавление Вопроса";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)answerNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label questinLabel;
        private TextBox addQuestinTextBox;
        private Label answerLabel;
        private Button addButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem stripMenuItem;
        private ToolStripMenuItem mainMenuItem;
        private ToolStripMenuItem exitMenuItem;
        private NumericUpDown answerNumericUpDown;
    }
}
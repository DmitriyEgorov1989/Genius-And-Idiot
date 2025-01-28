namespace GeniyIdiotWinFormsApp
{
    partial class MenuForm
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
            startButton = new Button();
            nameTextBox = new TextBox();
            textLabel = new Label();
            welcomeLabel = new Label();
            menuStrip1 = new MenuStrip();
            stripMenuItem = new ToolStripMenuItem();
            getResultatMenuItem = new ToolStripMenuItem();
            deleteQuestinsMenuItem = new ToolStripMenuItem();
            addQuestinsMenuItem = new ToolStripMenuItem();
            exitMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            startButton.ForeColor = SystemColors.ControlText;
            startButton.Location = new Point(237, 282);
            startButton.Name = "startButton";
            startButton.Size = new Size(271, 105);
            startButton.TabIndex = 0;
            startButton.Text = "Начать Игру!";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += StartButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(237, 216);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(271, 27);
            nameTextBox.TabIndex = 1;
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.BackColor = SystemColors.Control;
            textLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textLabel.Location = new Point(263, 165);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(216, 31);
            textLabel.TabIndex = 2;
            textLabel.Text = "Введите ваше Имя!";
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.BackColor = SystemColors.Control;
            welcomeLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            welcomeLabel.ForeColor = Color.DarkBlue;
            welcomeLabel.Location = new Point(35, 54);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(712, 46);
            welcomeLabel.TabIndex = 3;
            welcomeLabel.Text = "Добро пожаловать в игру Гений и Идиот!";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { stripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(759, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // stripMenuItem
            // 
            stripMenuItem.BackColor = Color.Coral;
            stripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { getResultatMenuItem, deleteQuestinsMenuItem, addQuestinsMenuItem, exitMenuItem });
            stripMenuItem.ForeColor = Color.Blue;
            stripMenuItem.Name = "stripMenuItem";
            stripMenuItem.Size = new Size(65, 24);
            stripMenuItem.Text = "Меню";
            // 
            // getResultatMenuItem
            // 
            getResultatMenuItem.Name = "getResultatMenuItem";
            getResultatMenuItem.Size = new Size(258, 26);
            getResultatMenuItem.Text = "Посмотреть результаты";
            getResultatMenuItem.Click += GetResultatMenuItem_Click;
            // 
            // deleteQuestinsMenuItem
            // 
            deleteQuestinsMenuItem.Name = "deleteQuestinsMenuItem";
            deleteQuestinsMenuItem.Size = new Size(258, 26);
            deleteQuestinsMenuItem.Text = "Удалить вопрос";
            deleteQuestinsMenuItem.Click += DeleteQuestinsMenuItem_Click_1;
            // 
            // addQuestinsMenuItem
            // 
            addQuestinsMenuItem.Name = "addQuestinsMenuItem";
            addQuestinsMenuItem.Size = new Size(258, 26);
            addQuestinsMenuItem.Text = "Добавить вопрос";
            addQuestinsMenuItem.Click += AddQuestinsMenuItem_Click;
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new Size(258, 26);
            exitMenuItem.Text = "Выйти";
            exitMenuItem.Click += ExitMenuItem_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(759, 502);
            Controls.Add(welcomeLabel);
            Controls.Add(textLabel);
            Controls.Add(nameTextBox);
            Controls.Add(startButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuForm";
            Text = "Главное меню";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private TextBox nameTextBox;
        private Label textLabel;
        private Label welcomeLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem stripMenuItem;
        private ToolStripMenuItem getResultatMenuItem;
        private ToolStripMenuItem deleteQuestinsMenuItem;
        private ToolStripMenuItem addQuestinsMenuItem;
        private ToolStripMenuItem exitMenuItem;
    }
}
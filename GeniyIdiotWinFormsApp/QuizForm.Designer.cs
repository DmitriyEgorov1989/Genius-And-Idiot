namespace GeniyIdiotWinFormsApp
{
    partial class QuizForm
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
            components = new System.ComponentModel.Container();
            nextButton = new Button();
            questionTextLabel = new Label();
            questionNumberTextLabel = new Label();
            menuStrip1 = new MenuStrip();
            stripMenuItem = new ToolStripMenuItem();
            restartMenuItem = new ToolStripMenuItem();
            exitMenuItem = new ToolStripMenuItem();
            imageList1 = new ImageList(components);
            userAnswerNumericUpDown = new NumericUpDown();
            quiztimer = new System.Windows.Forms.Timer(components);
            timerLabel = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userAnswerNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // nextButton
            // 
            nextButton.Location = new Point(51, 266);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(244, 94);
            nextButton.TabIndex = 0;
            nextButton.Text = "Дальше";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += NextButton_Click;
            // 
            // questionTextLabel
            // 
            questionTextLabel.AutoSize = true;
            questionTextLabel.Location = new Point(51, 104);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new Size(106, 20);
            questionTextLabel.TabIndex = 2;
            questionTextLabel.Text = "текст вопроса";
            // 
            // questionNumberTextLabel
            // 
            questionNumberTextLabel.AutoSize = true;
            questionNumberTextLabel.Location = new Point(51, 51);
            questionNumberTextLabel.Name = "questionNumberTextLabel";
            questionNumberTextLabel.Size = new Size(118, 20);
            questionNumberTextLabel.TabIndex = 4;
            questionNumberTextLabel.Text = "номер вопроса";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { stripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(533, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // stripMenuItem
            // 
            stripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { restartMenuItem, exitMenuItem });
            stripMenuItem.Name = "stripMenuItem";
            stripMenuItem.Size = new Size(65, 24);
            stripMenuItem.Text = "Меню";
            // 
            // restartMenuItem
            // 
            restartMenuItem.Name = "restartMenuItem";
            restartMenuItem.Size = new Size(144, 26);
            restartMenuItem.Text = "Рестарт";
            restartMenuItem.Click += RestartMenuItem_Click;
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new Size(144, 26);
            exitMenuItem.Text = "Выход";
            exitMenuItem.Click += ExitMenuItem_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // userAnswerNumericUpDown
            // 
            userAnswerNumericUpDown.Location = new Point(51, 164);
            userAnswerNumericUpDown.Maximum = new decimal(new int[] { 1874919424, 2328306, 0, 0 });
            userAnswerNumericUpDown.Name = "userAnswerNumericUpDown";
            userAnswerNumericUpDown.Size = new Size(126, 27);
            userAnswerNumericUpDown.TabIndex = 6;
            // 
            // quiztimer
            // 
            quiztimer.Enabled = true;
            quiztimer.Interval = 1000;
            quiztimer.Tick += Quiztimer_Tick;
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            timerLabel.ForeColor = SystemColors.ActiveCaptionText;
            timerLabel.Location = new Point(320, 141);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(156, 50);
            timerLabel.TabIndex = 7;
            timerLabel.Text = "Таймер";
            // 
            // QuizForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(533, 464);
            Controls.Add(timerLabel);
            Controls.Add(userAnswerNumericUpDown);
            Controls.Add(questionNumberTextLabel);
            Controls.Add(questionTextLabel);
            Controls.Add(nextButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "QuizForm";
            Text = "Игра";
            Load += QuizForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userAnswerNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button nextButton;
        private Label questionTextLabel;
        private Label questionNumberTextLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem stripMenuItem;
        private ToolStripMenuItem restartMenuItem;
        private ToolStripMenuItem exitMenuItem;
        private ImageList imageList1;
        private NumericUpDown userAnswerNumericUpDown;
        private System.Windows.Forms.Timer quiztimer;
        private Label timerLabel;
    }
}

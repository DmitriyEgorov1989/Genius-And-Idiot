namespace GeniyIdiotWinFormsApp
{
    partial class DeleteQuestionsForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            deleteQuestionsButton = new Button();
            menuStrip1 = new MenuStrip();
            stripMenuItem = new ToolStripMenuItem();
            mainMenuItem = new ToolStripMenuItem();
            exitMenuItem = new ToolStripMenuItem();
            questionsDataGridView = new DataGridView();
            questionBindingSource = new BindingSource(components);
            answerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)questionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(205, 9);
            label1.Name = "label1";
            label1.Size = new Size(365, 20);
            label1.TabIndex = 0;
            label1.Text = "Выберите номер вопроса,который хотите удалить!";
            // 
            // deleteQuestionsButton
            // 
            deleteQuestionsButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteQuestionsButton.Location = new Point(295, 342);
            deleteQuestionsButton.Name = "deleteQuestionsButton";
            deleteQuestionsButton.Size = new Size(186, 55);
            deleteQuestionsButton.TabIndex = 2;
            deleteQuestionsButton.Text = "Удалить вопрос!";
            deleteQuestionsButton.UseVisualStyleBackColor = true;
            deleteQuestionsButton.Click += DeleteQuestionsButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { stripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(801, 28);
            menuStrip1.TabIndex = 4;
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
            mainMenuItem.Click += mainMenuItem_Click;
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new Size(193, 26);
            exitMenuItem.Text = "Выход";
            exitMenuItem.Click += ExitMenuItem_Click;
            // 
            // questionsDataGridView
            // 
            questionsDataGridView.AllowUserToAddRows = false;
            questionsDataGridView.AllowUserToOrderColumns = true;
            questionsDataGridView.AutoGenerateColumns = false;
            questionsDataGridView.BackgroundColor = SystemColors.ControlLight;
            questionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            questionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { answerDataGridViewTextBoxColumn });
            questionsDataGridView.DataSource = questionBindingSource;
            questionsDataGridView.Location = new Point(0, 32);
            questionsDataGridView.Name = "questionsDataGridView";
            questionsDataGridView.RowHeadersWidth = 51;
            questionsDataGridView.Size = new Size(810, 276);
            questionsDataGridView.TabIndex = 6;
            // 
            // questionBindingSource
            // 
            questionBindingSource.DataSource = typeof(GeniyIdiot.Common.Question);
            // 
            // answerDataGridViewTextBoxColumn
            // 
            answerDataGridViewTextBoxColumn.DataPropertyName = "Text";
            answerDataGridViewTextBoxColumn.HeaderText = "Вопросы";
            answerDataGridViewTextBoxColumn.MinimumWidth = 6;
            answerDataGridViewTextBoxColumn.Name = "answerDataGridViewTextBoxColumn";
            answerDataGridViewTextBoxColumn.Width = 750;
            // 
            // DeleteQuestionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(801, 529);
            Controls.Add(questionsDataGridView);
            Controls.Add(deleteQuestionsButton);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "DeleteQuestionsForm";
            Text = "Удаление вопроса";
            Load += DeleteQuestionsForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)questionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button deleteQuestionsButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem stripMenuItem;
        private ToolStripMenuItem mainMenuItem;
        private ToolStripMenuItem exitMenuItem;
        private DataGridView questionsDataGridView;
        private BindingSource questionBindingSource;
        private DataGridViewTextBoxColumn answerDataGridViewTextBoxColumn;
    }
}
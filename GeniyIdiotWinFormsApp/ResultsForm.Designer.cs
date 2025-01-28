namespace GeniyIdiotWinFormsApp
{
    partial class ResultsForm
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
            listViewResults = new ListView();
            columnName = new ColumnHeader();
            columnRightAnswer = new ColumnHeader();
            columnIndex = new ColumnHeader();
            menuStrip1 = new MenuStrip();
            ResultMenuItem = new ToolStripMenuItem();
            mainMenuItem = new ToolStripMenuItem();
            exitMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listViewResults
            // 
            listViewResults.Columns.AddRange(new ColumnHeader[] { columnName, columnRightAnswer, columnIndex });
            listViewResults.Location = new Point(134, 31);
            listViewResults.Name = "listViewResults";
            listViewResults.Size = new Size(505, 392);
            listViewResults.TabIndex = 0;
            listViewResults.UseCompatibleStateImageBehavior = false;
            listViewResults.View = View.Details;
            // 
            // columnName
            // 
            columnName.Text = "Имя";
            columnName.Width = 150;
            // 
            // columnRightAnswer
            // 
            columnRightAnswer.Text = "Кол-во правильных от-ов";
            columnRightAnswer.TextAlign = HorizontalAlignment.Center;
            columnRightAnswer.Width = 200;
            // 
            // columnIndex
            // 
            columnIndex.Text = "Диагноз";
            columnIndex.Width = 150;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ResultMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // ResultMenuItem
            // 
            ResultMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mainMenuItem, exitMenuItem });
            ResultMenuItem.Name = "ResultMenuItem";
            ResultMenuItem.Size = new Size(65, 24);
            ResultMenuItem.Text = "Меню";
            // 
            // mainMenuItem
            // 
            mainMenuItem.Name = "mainMenuItem";
            mainMenuItem.Size = new Size(224, 26);
            mainMenuItem.Text = "Главное меню";
            mainMenuItem.Click += MainMenuItem_Click;
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new Size(224, 26);
            exitMenuItem.Text = "Выход";
            exitMenuItem.Click += ExitMenuItem_Click;
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(listViewResults);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ResultsForm";
            Text = "Результаты игры";
            Load += ResultsForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewResults;
        private ColumnHeader columnName;
        private ColumnHeader columnRightAnswer;
        private ColumnHeader columnIndex;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ResultMenuItem;
        private ToolStripMenuItem mainMenuItem;
        private ToolStripMenuItem exitMenuItem;
    }
}
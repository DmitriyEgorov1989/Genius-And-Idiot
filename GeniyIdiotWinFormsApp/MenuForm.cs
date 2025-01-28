
using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            var rightUserName = nameTextBox.Text;

            if (string.IsNullOrEmpty(rightUserName))
            {
                MessageBox.Show("Пожалуйста,введите корректное имя пользователя!");
                nameTextBox.Clear();
                return;
            }
            for (int i = 0; i < rightUserName.Length; i++)
            {
                if (!char.IsLetter(rightUserName[i]))
                {
                    MessageBox.Show("Пожалуйста,введите корректное имя пользователя!");
                    nameTextBox.Clear();
                    return;
                }
            }
            var quizForm = new QuizForm(rightUserName);
            quizForm.ShowDialog();
        }
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void GetResultatMenuItem_Click(object sender, EventArgs e)
        {
            var resultsForm = new ResultsForm();
            resultsForm.ShowDialog();
        }
        private void DeleteQuestinsMenuItem_Click_1(object sender, EventArgs e)
        {
            var deleteQuestins = new DeleteQuestionsForm();
            deleteQuestins.ShowDialog();
        }
        private void AddQuestinsMenuItem_Click(object sender, EventArgs e)
        {
            var addNewQuestins = new AddNewQuestionsForm();
            addNewQuestins.ShowDialog();
        }
    }
}
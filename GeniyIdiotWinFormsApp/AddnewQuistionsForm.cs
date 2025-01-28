using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class AddNewQuestionsForm : Form
    {
        private QuestionStorage _questionStorage;
        private List<Question> _questions;
        public AddNewQuestionsForm()
        {
            InitializeComponent();
            _questionStorage = new QuestionStorage();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            var newQuestions = addQuestinTextBox.Text;

            if (string.IsNullOrEmpty(newQuestions))
            {
                MessageBox.Show("Пожалуйста, введите корректные данные");
            }
            else
            {
                var inputAnswer = Convert.ToInt32(answerNumericUpDown.Value);
                var question = new Question(newQuestions, inputAnswer);
                _questionStorage = new QuestionStorage();
                _questionStorage.Add(question);

                MessageBox.Show($"Вопрос: <{newQuestions}>  добавлен!");
                addQuestinTextBox.Clear();
            }
        }
        private void MainMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
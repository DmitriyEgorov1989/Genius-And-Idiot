using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class DeleteQuestionsForm : Form
    {
        private QuestionStorage _questionStorage;
        private List<Question> _questions;
        public DeleteQuestionsForm()
        {
            InitializeComponent();
            _questionStorage = new QuestionStorage();
            questionsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void DeleteQuestionsForm_Load(object sender, EventArgs e)
        {
            LoadQuestions();
        }
        private void DeleteQuestionsButton_Click(object sender, EventArgs e)
        {

            var selectedQuestion = questionsDataGridView.SelectedRows[0];
            var stringIndex = selectedQuestion.Index + 1;
            _questionStorage.Delete(_questions, stringIndex);
            MessageBox.Show($"Вопрос удален!");
            LoadQuestions();
        }
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LoadQuestions()
        {
            _questionStorage.AddBasicQuestions();
            _questions = _questionStorage.GetAll();
            questionsDataGridView.DataSource = _questions;
        }
        private void mainMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class QuizForm : Form
    {
        private List<Question> _questions;
        private Question _currentQuestion;
        private User _user = new User();
        private QuestionStorage _questionStorage;
        private int _questionNumber;
        private int _initialQuestionCount;
        private int _countDown = 10;
        private UsersResultStorage _usersResultStorage;
        public QuizForm(string name)
        {
            InitializeComponent();
            _user.Name = name;
            _usersResultStorage = new UsersResultStorage();
        }
        private void QuizForm_Load(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Игра на время ,торопитесь!", "Внимание", MessageBoxButtons.OK);

            if (result == DialogResult.OK)
            {
                StartTimer();
            }
            _questionNumber = 0;
            _questionStorage = new QuestionStorage();
            _questionStorage.AddBasicQuestions();
            _questions = _questionStorage.GetAll();
            _initialQuestionCount = _questions.Count;
            ShowNextQuestion();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            var inputAnswer = Convert.ToInt32(userAnswerNumericUpDown.Value);
            var rightAnswer = _currentQuestion.Answer;
            if (inputAnswer == rightAnswer)
            {
                _user.RightAnswerCount++;
            }
            _questions.Remove(_currentQuestion);
            if (_questions.Count == 0)
            {
                quiztimer.Stop();
                MakingDiagnosis();
                _user.RightAnswerCount = 0;
                return;
            }
            ShowNextQuestion();
        }
        private void RestartMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Quiztimer_Tick(object sender, EventArgs e)
        {
            _countDown--;
            timerLabel.Text = _countDown.ToString();
            if (_countDown == 5)
            {
                timerLabel.ForeColor = Color.Red;
            }
            if (_countDown == 0)
            {
                quiztimer.Stop();
                MessageBox.Show("Вы неуспели");

                _questions.Remove(_currentQuestion);
                if (_questions.Count == 0)
                {
                    quiztimer.Stop();
                    MakingDiagnosis();
                    _user.RightAnswerCount = 0;
                    return;
                }
                ShowNextQuestion();
            }
        }
        private void StartTimer()
        {
            _countDown = 10;
            timerLabel.Text = _countDown.ToString();
            timerLabel.ForeColor = Color.Black;
            quiztimer.Start();
        }
        private void MakingDiagnosis()
        {
            _user.Diagnosis = _usersResultStorage.GetDiagnoses(_user, _initialQuestionCount);
            MessageBox.Show($"Количество правильных ответов: {_user.RightAnswerCount}" + Environment.NewLine + $"{_user.Name},ваш диагноз: {_user.Diagnosis}");
            _usersResultStorage.Append(_user);
        }
        private void ShowNextQuestion()
        {
            StartTimer();
            var random = new Random();
            var randomIndex = random.Next(0, _questions.Count);
            _currentQuestion = _questions[randomIndex];
            questionTextLabel.Text = _currentQuestion.Text;
            _questionNumber++;
            questionNumberTextLabel.Text = "Вопрос №" + _questionNumber;
        }
    }
}
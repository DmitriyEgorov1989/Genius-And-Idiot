namespace GeniyIdiot.Common
{
    public class QuestionStorage
    {
        private readonly string _fileQuestionsAndAnswers = @"..\..\..\вопросы и ответы.json";

        public void AddBasicQuestions()
        {
            if (!File.Exists(_fileQuestionsAndAnswers))
            {
                var basicQuestionAnswer = new List<Question>
                {
                    new Question("Сколько будет 2  плюс 2 умноженное на 2?", 6),
                    new Question("Бревно нужно распилить на 10 частей,сколько надо сделать распилов?", 9),
                    new Question("На одной руке 5 пальцев,сколько пальцев на 5 руках?", 25),
                    new Question("Укол делают каждые полчаса, сколько нужно минут для трех уколов ?", 60),
                    new Question("Пять свечей горело ,две потухли.Сколько свечей осталось ?", 2),
                };
                JsonProvider.Save(_fileQuestionsAndAnswers, basicQuestionAnswer);
            }
        }
        public static void Shuffle(List<Question> questions)
        {
            Random random = new Random();

            for (int i = questions.Count - 1; i > 0; i--)
            {
                int randomIndex = random.Next(i + 1);

                var tempQuestion = questions[i];
                questions[i] = questions[randomIndex];
                questions[randomIndex] = tempQuestion;
            }
        }
        public List<Question> GetAll()
        {
            var questionAnswer = JsonProvider.Read<Question>(_fileQuestionsAndAnswers);
            return questionAnswer;
        }
        public void Add(Question question)
        {
            var questionAnswer = GetAll();
            questionAnswer.Add(question);
            JsonProvider.Save(_fileQuestionsAndAnswers, questionAnswer);
        }
        public void Delete(List<Question> questions, int deleteNumberAnswer)
        {
            var fullText = string.Empty;

            questions.RemoveAt(deleteNumberAnswer - 1);

            JsonProvider.Save(_fileQuestionsAndAnswers, questions);
        }
    }
}
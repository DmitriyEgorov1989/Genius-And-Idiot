using GeniyIdiot.Common;

namespace GeniusIdiotConsoleApp
{
    public class Program
    {
        private static int timeLeft = 10;
        private static bool timeOut = false;
        private static Timer timer;
        private static int userAnswer;
        private static void Main()
        {
            var usersResultStorage = new UsersResultStorage();
            var helpersConsoleApp = new HelpersConsoleApp();
            var user = new User();

            Console.WriteLine("Введите ваше имя!");

            user.Name = helpersConsoleApp.GetUserName();
            var questionStorage = new QuestionStorage();

            questionStorage.AddBasicQuestions();
            do
            {
                Console.WriteLine("ТЕСТ НА ВРЕМЯ,ДЛЯ ПРОДОЛЖЕНИЯ НАЖМИТЕ  <ENTER>!!!");
                Console.ReadLine();
                Thread.Sleep(100);

                var questions = questionStorage.GetAll();
                QuestionStorage.Shuffle(questions);

                for (int i = 0; i < questions.Count; i++)
                {
                    timeLeft = 10;
                    timeOut = false;
                    timer = new Timer(TimerCallback, null, 0, 1000);

                    Console.WriteLine(Environment.NewLine + $"Вопрос №{i + 1} {questions[i].Text}");
                    while (!timeOut)
                    {
                        if (Console.KeyAvailable)
                        {
                            userAnswer = helpersConsoleApp.GetUserAnswer();
                            timer.Dispose();
                            break;
                        }
                    }
                    var rightAnswer = questions[i].Answer;
                    if (userAnswer == rightAnswer && !timeOut)
                    {
                        user.RightAnswerCount++;
                    }
                    Thread.Sleep(100);
                }
                user.Diagnosis = usersResultStorage.GetDiagnoses(user, questions.Count);
                usersResultStorage.Append(user);

                Console.WriteLine($"Количество правильных ответов: {user.RightAnswerCount}" + Environment.NewLine + $"{user.Name},ваш диагноз: {user.Diagnosis}");
                user.RightAnswerCount = 0;
                var userChoice = helpersConsoleApp.IsPositiveAnswer("Хотите посмотреть все результаты?");
                if (userChoice)
                {
                    helpersConsoleApp.DisplayResultsTable();
                }
                userChoice = helpersConsoleApp.IsPositiveAnswer("Хотите добавить свой вопрос?");
                if (userChoice)
                {
                    Console.WriteLine("Введите новый вопрос!");
                    var newQuestions = string.Empty;

                    while (true)
                    {
                        newQuestions = Console.ReadLine();

                        if (string.IsNullOrEmpty(newQuestions))
                        {
                            Console.WriteLine(Environment.NewLine + "Время истекло!");
                        }
                        else
                        {
                            break;
                        }
                    }
                    Console.WriteLine("Введите новый ответ!");

                    var newAnswer = helpersConsoleApp.GetUserAnswer();
                    var question = new Question(newQuestions, newAnswer);
                    questionStorage.Add(question);
                }
                userChoice = helpersConsoleApp.IsPositiveAnswer("Хотите удалить вопрос?");
                if (userChoice)
                {
                    do
                    {
                        questions = questionStorage.GetAll();

                        for (var i = 0; i < questions.Count; i++)
                        {
                            Console.WriteLine($"Вопрос №{i + 1} {questions[i].Text}");
                        }
                        Console.WriteLine(Environment.NewLine + $"Выберите номер вопроса,который хотите удалить!");
                        var deleteNumberAnswer = helpersConsoleApp.GetUserAnswer();
                        questionStorage.Delete(questions, deleteNumberAnswer);

                    } while (helpersConsoleApp.IsPositiveAnswer("Хотите удалить еще вопрос?"));
                }

            } while (helpersConsoleApp.IsPositiveAnswer("Хотите повторить тест?"));
        }
        private static void TimerCallback(object o)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write($"У вас осталось {timeLeft} секунд!");
            }
            else
            {
                timeOut = true;
                timer.Dispose();
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.WriteLine(Environment.NewLine + "Время истекло!");
            }
        }
    }
}
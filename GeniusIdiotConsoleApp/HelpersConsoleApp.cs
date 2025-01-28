using GeniyIdiot.Common;

namespace GeniusIdiotConsoleApp
{
    public class HelpersConsoleApp
    {
        private UsersResultStorage _usersResultStorage = new UsersResultStorage();
        public string GetUserName()
        {
            var rightUserName = "";
            bool flag = true;

            while (flag)
            {
                rightUserName = Console.ReadLine();

                for (int i = 0; i < rightUserName.Length; i++)
                {
                    if (!char.IsLetter(rightUserName[i]))
                    {
                        Console.WriteLine("Пожалуйста,введите корректное имя пользователя!");
                        flag = true;
                        break;
                    }
                    flag = false;
                }
            }
            return rightUserName;
        }
        public int GetUserAnswer()
        {
            int result;

            while (true)
            {

                var inputAnswer = Console.ReadLine();

                if (int.TryParse(inputAnswer, out result))
                {
                    return result;
                }
                Console.WriteLine("Пожалуйста, введите число!");
            }
        }
        public bool IsPositiveAnswer(string question)
        {
            var userInput = "";

            while (userInput != "да" && userInput != "нет")
            {
                Console.WriteLine(question + " Ответьте Да или Нет!");
                userInput = Console.ReadLine().ToLower();
            }
            return userInput == "да";
        }
        public void DisplayResultsTable()
        {
            var users = _usersResultStorage.GetResults();

            var tableFormat = " {0,-20}|{1,-22}|{2,-12}| ";
            var nameWidth = 20;
            var indent = 4;
            var tableWidth = 58;
            Console.WriteLine();
            Console.WriteLine(String.Format(tableFormat, "Имя".PadLeft(10), "Кол-во прав-ных от-в".PadLeft(21), "Диагноз".PadLeft(9)));
            Console.WriteLine(new string('-', tableWidth));
            foreach (var user in users)
            {
                if (user.Name.Length >= nameWidth - indent)
                {
                    user.Name = user.Name.Remove(nameWidth - indent) + "...";
                }
                Console.WriteLine(String.Format(tableFormat, user.Name, user.RightAnswerCount.ToString().PadLeft(10), user.Diagnosis.PadLeft(9)));
                Console.WriteLine();
            }
        }
    }
}

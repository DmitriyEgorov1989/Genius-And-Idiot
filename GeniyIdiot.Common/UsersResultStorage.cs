namespace GeniyIdiot.Common
{
    public class UsersResultStorage
    {
        private readonly string _resultsFile = "results.json";
        public void Append(User user)
        {
            var usersResults = GetResults();
            usersResults.Add(user);
            JsonProvider.Save(_resultsFile, usersResults);
        }
        public string GetDiagnoses(User user, int questionCount)
        {
            var percentageOfCorrect = ((double)user.RightAnswerCount / questionCount) * 100;

            switch (percentageOfCorrect)
            {
                case 100: return "Гений";
                case > 80: return "Талант";
                case > 60: return "Нормальный";
                case > 40: return "Дурак";
                case > 20: return "Кретин";
            }
            return "Идиот";
        }
        public List<User> GetResults()
        {
            if (!FileProvider.FileExist(_resultsFile))
            {
                return [];
            }
            var results = JsonProvider.Read<User>(_resultsFile);
            return results;
        }
    }
}
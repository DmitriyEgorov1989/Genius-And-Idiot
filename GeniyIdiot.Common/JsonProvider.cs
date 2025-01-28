using Newtonsoft.Json;

namespace GeniyIdiot.Common
{
    public class JsonProvider
    {
        private readonly string fileQuestionsAndAnswers = @"..\..\..\вопросы и ответы.json";
        public static void Save<T>(string file, List<T> list)
        {
            var dataLine = JsonConvert.SerializeObject(list, Formatting.Indented);
            FileProvider.Write(file, dataLine);
        }
        public static List<T> Read<T>(string file)
        {
            var fileData = File.ReadAllText(file);
            var list = JsonConvert.DeserializeObject<List<T>>(fileData);

            return list;
        }
    }
}


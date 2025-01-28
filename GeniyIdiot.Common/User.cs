namespace GeniyIdiot.Common
{
    public class User
    {
        public string Name;
        public int RightAnswerCount;
        public string Diagnosis;
        public User()
        {
            Name = "Без имени";
            RightAnswerCount = 0;
            Diagnosis = "Без диагноза";
        }
    }
}
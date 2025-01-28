namespace GeniyIdiot.Common
{
    public class FileProvider
    {
        public static string Read(string file)
        {
            var fileText = string.Empty;

            using (var reader = new StreamReader(file))

            {
                fileText = reader.ReadLine();
            }
            return fileText;
        }
        public static void Write(string file, string line)
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine(line);
            }
        }
        public static void Append(string file, string addedText)
        {
            File.AppendAllText(file, addedText);
        }
        public static bool FileExist(string file)
        {
            return File.Exists(file);
        }
    }
}
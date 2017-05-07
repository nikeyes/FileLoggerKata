using System.IO;
using System.Linq;

namespace FileLoggerKata
{
    public class FileLogger : ILogger
    {
        private const string FILE_NAME = "log.txt";

        public FileLogger()
        {
            if (File.Exists(FILE_NAME))
            {
                File.Delete(FILE_NAME);
            }
        }

        public string GetFileLogName()
        {
            return FILE_NAME;
        }

        public string GetFileLogPath()
        {
           return Path.GetDirectoryName(FILE_NAME);
        }

        public string GetLastMessage()
        {
            return File.ReadLines(FILE_NAME).Last();
        }

        public int GetNumMessages()
        {
           return File.ReadLines(FILE_NAME).Count();
        }

        public bool IsFileLogExists()
        {
            return File.Exists(FILE_NAME);
        }

        public void Log(string message)
        {
            using (StreamWriter writer = new StreamWriter(FILE_NAME, append: true))
            {
                writer.WriteLine(message);
            }
            
        }
    }
}

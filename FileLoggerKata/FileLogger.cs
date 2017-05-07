using System;

namespace FileLoggerKata
{
    public class FileLogger
    {
        private String _message = String.Empty;
        
        public void Log(string v)
        {
            _message = v;
        }

        public string GetLastMessage()
        {
            return _message;
        }
    }
}
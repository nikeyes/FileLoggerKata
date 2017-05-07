using System;

namespace FileLoggerKata
{
    public class FileLogger
    {
        private String _message = String.Empty;
        
        public void Log(string message)
        {
            _message = message;
        }

        public string GetLastMessage()
        {
            return _message;
        }

        public string GetNumMessages()
        {
            throw new NotImplementedException();
        }
    }
}
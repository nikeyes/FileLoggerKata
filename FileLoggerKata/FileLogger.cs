using System;
using System.Collections.Generic;
using System.Linq;

namespace FileLoggerKata
{
    public class FileLogger
    {
        private readonly List<String> _messages = new List<String>();
        
        public void Log(string message)
        {
            _messages.Add(message);
        }

        public string GetLastMessage()
        {
            return _messages.Last();
        }

        public int GetNumMessages()
        {
            return _messages.Count;
        }
    }
}
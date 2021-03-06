﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace FileLoggerKata
{
    public class MemoryLogger: ILogger
    {
        private readonly List<String> _messages = new List<String>();
        private bool _isFileLogExists = false;
        
        public void Log(string message)
        {
            _isFileLogExists = true;
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

        public string GetFileLogName()
        {
            return "log.txt";
        }

        public string GetFileLogPath()
        {
            return @"D:\desarrollo\git\repos\FileLoggerKata\FileLoggerKata.UnitTests\bin\Debug";
        }

        public bool IsFileLogExists()
        {
            return _isFileLogExists;
        }
    }
}
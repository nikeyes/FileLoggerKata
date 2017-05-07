﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLoggerKata
{
    public interface ILogger
    {
        void Log(String message);
        String GetLastMessage();
        int GetNumMessages();
        String GetFileLogName();
        string GetFileLogPath();
        bool IsFileLogExists();
    }
}

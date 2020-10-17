using System;

namespace LogWriter
{
    partial class Program
    {
        abstract class AbstractLogWriter : ILogWriter
        {
            private string _messageConsrtuctor(string logType, string message) 
            {
                return $"{DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss+00:00")}\t{logType}\t{message}";
            }
            public abstract void WriteLog(string message);
            public void LogInfo (string message) 
            {
                WriteLog(_messageConsrtuctor("Info", message));
            }
            public void LogWarning (string message)
            {
                WriteLog(_messageConsrtuctor("Warning", message));
            }
            public void LogError(string message)
            {
                WriteLog(_messageConsrtuctor("Error", message));
            }
        }
    }
}

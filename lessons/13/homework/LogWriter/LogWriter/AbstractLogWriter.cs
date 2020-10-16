using System;

namespace LogWriter
{
    partial class Program
    {
        abstract class AbstractLogWriter : ILogWriter
        {
            private string messageConsrtuctor(string logType, string message) 
            {
                return $"{DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss+ffff")}    {logType}    {message}";
            }
            public abstract void WriteLog(string message);
            public void LogInfo (string message) 
            {
                WriteLog(messageConsrtuctor("Info", message));
            }
            public void LogWarning (string message)
            {
                WriteLog(messageConsrtuctor("Warning", message));
            }
            public void LogError(string message)
            {
                WriteLog(messageConsrtuctor("Error", message));
            }
        }
    }
}

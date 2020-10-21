using System.Globalization;

namespace LogWriter
{
    partial class Program
    {
        interface ILogWriter
        {
            void LogInfo(string message);
            void LogWarning(string message);
            void LogError(string message);
        }

        static void Main(string[] args)
        {
            /*
            var consoleLogger = new ConsoleLogWriter();
            var fileLogger = new FileLogWriter("C:\\Users\\Nastasia\\Documents\\log.txt");
            consoleLogger.LogInfo("Something for info");
            fileLogger.LogInfo("Something info to log to file");

            var multipleLogger = new MultipleLogWriter(new AbstractLogWriter[] { consoleLogger, fileLogger });
            multipleLogger.LogInfo("Info message for multipleLogger");
            multipleLogger.LogWarning("Warning message for multipleLogger");
            multipleLogger.LogError("Error message for multipleLogger");
            */
            LogWriterFactory.ToConsole.LogInfo("Info Message for console");
            LogWriterFactory.ToFile.LogWarning("Warning Message for File");

            LogWriterFactory.Both.LogWarning("Some warning message");
            LogWriterFactory.Both.LogInfo("Some info message");
            LogWriterFactory.Both.LogError("Some error message");

            
        }
    }
}

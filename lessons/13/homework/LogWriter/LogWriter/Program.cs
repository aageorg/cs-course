using System.Globalization;
using System.Net.WebSockets;

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

            var clw = LogWriterFactory.GetLogWriter<ConsoleLogWriter>();
            var flw = LogWriterFactory.GetLogWriter<FileLogWriter>("C:\\Users\\Nastasia\\Documents\\test.txt");
            AbstractLogWriter[] logWriters = new AbstractLogWriter[] { (ConsoleLogWriter)clw, (FileLogWriter)flw };
            var mlw = LogWriterFactory.GetLogWriter<MultipleLogWriter>(logWriters);

            clw.LogError("Error message for console");
            clw.LogInfo("Info message for console");
            clw.LogWarning("Warning message for console");

            flw.LogError("Error message for file");
            flw.LogInfo("Info message for file");
            flw.LogWarning("Warning message for file");

            mlw.LogError("Error message for file and console");
            mlw.LogInfo("Info message for file and console");
            mlw.LogWarning("Warning message for file and console");

        }
    }
}

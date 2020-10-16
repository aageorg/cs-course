using System;

namespace LogWriter
{
    partial class Program
    {
        class ConsoleLogWriter : AbstractLogWriter
        {
            public override void WriteLog(string message)
            {
                Console.WriteLine(message);
            }
        }
    }
}

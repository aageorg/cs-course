namespace LogWriter
{
    partial class Program
    {
        class LogWriterFactory
        {
            public static readonly FileLogWriter ToFile = (FileLogWriter)GetLogWriter<FileLogWriter>(new FileLogWriter("C:\\Users\\Nastasia\\Documents\\test.txt"));
            public static readonly ConsoleLogWriter ToConsole = (ConsoleLogWriter)GetLogWriter<ConsoleLogWriter>(new ConsoleLogWriter());
            public static readonly MultipleLogWriter Both = (MultipleLogWriter)GetLogWriter<MultipleLogWriter>(new MultipleLogWriter(new AbstractLogWriter[] { ToFile, ToConsole }));

            public static ILogWriter GetLogWriter<T>(object parameters)
                where T : ILogWriter
            {
                return (T) parameters;
            }

            private LogWriterFactory() {}
        }
    }
}

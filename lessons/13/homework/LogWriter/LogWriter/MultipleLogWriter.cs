namespace LogWriter
{
    partial class Program
    {
        class MultipleLogWriter : AbstractLogWriter
        {
            private readonly AbstractLogWriter[] _instances;
            public override void WriteLog(string message)
            {
                foreach (AbstractLogWriter instance in _instances)
                {
                    instance.WriteLog(message);
                }
            }
            public MultipleLogWriter(AbstractLogWriter[] logWriters)
            {
                _instances = logWriters;
            }
        }
    }
}

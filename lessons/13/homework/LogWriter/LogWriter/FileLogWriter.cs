using System.IO;

namespace LogWriter
{
    partial class Program
    {
        class FileLogWriter : AbstractLogWriter
        {
            private readonly string _path;
            public override void WriteLog(string message)
            {
                File.AppendAllText(_path, message+"\r\n");
            }
            public FileLogWriter(string path)
            {
                _path = path;
            }   
            
        }
    }
}

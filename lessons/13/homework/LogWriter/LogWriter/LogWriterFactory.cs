using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace LogWriter
{
    partial class Program
    {
        class LogWriterFactory 
        {
            /*
              private static readonly string _path = "C:\\Users\\Nastasia\\Documents\\test.txt";
              private static readonly Dictionary<Type, object> _parameters = new Dictionary<Type, object>  {
               { typeof(ConsoleLogWriter), null },
               { typeof(FileLogWriter), _path},
               { typeof(MultipleLogWriter), new AbstractLogWriter[] {new FileLogWriter(_path), new ConsoleLogWriter()}}
               };
             */

            public static ILogWriter GetLogWriter<T>(object parameters = null)
                where T : ILogWriter
            {
                if (parameters == null)
                {
                    return (T)Activator.CreateInstance(typeof(T));
                }
                else
                {
                    return (T) Activator.CreateInstance(typeof(T), parameters);       
                }
            }
            private LogWriterFactory()
            {
                
            }
        }
    }
}

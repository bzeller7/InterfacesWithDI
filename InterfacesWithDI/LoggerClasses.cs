using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;

namespace InterfacesWithDI
{
    interface ILogger
    {
        void Log(string data);
    }

    class FileLogger : ILogger
    {
        public void Log(string data)
        {
            //Log data to documents folder
            string path = GetFolderPath(SpecialFolder.MyDocuments);

            path = Path.Combine(path, "log.txt");

            File.AppendAllText(path, data);
        }
    }

    /// <summary>
    /// Logs information to the Console
    /// </summary>
    class ConsoleLogger : ILogger
    {
        public void Log(string data)
        {
            Console.WriteLine(data);
        }
    }
}

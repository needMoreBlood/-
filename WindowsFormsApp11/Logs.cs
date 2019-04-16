using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Logs
    {
        private string logFile = "Logs.txt";

        public void LogData(string data)
        {
            using (var sw = new StreamWriter(logFile, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(DateTime.Now + " " + data);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Data
    {
        public List<Order> Orders { get; private set; }

        private static string logFile = "Logs.txt";
        private static string orderFile = "Orders.txt";

        public Data()
        {
            Orders = new List<Order>();
            var fileStream = new FileStream(orderFile, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.Default))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    Orders.Add(new Order(line.Split('/')));
                }
            }
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
            using (var sw = new StreamWriter(orderFile, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(order);
            }
        }

        public static void LogData(string data)
        {
            using (var sw = new StreamWriter(logFile, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(DateTime.Now + " " + data);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp11
{
    public class Container
    {
        public Dictionary<string,string> Data { get; private set; } = new Dictionary<string, string>();
        public string[] Positions { get; set; }
    }
}

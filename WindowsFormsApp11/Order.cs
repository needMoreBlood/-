using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Order
    {
        public string Name { get;}
        public string Adress { get;}
        public string Telephone { get;}
        public string Email { get; set; }
        public string Discription { get; }
        public string Product { get; }

        public Order(string product, IEnumerable<string> data)
        {
            Product = product;
            var d = data.ToArray();
            Name = d[0];
            Adress = d[1];
            Telephone = d[2];
            Email = d[3];
            var disc = new StringBuilder();
            foreach (var line in data.Skip(4))
            {
                disc.Append("/");
                disc.Append(line);
            }
            Discription = disc.ToString();
        }

        public Order(string[] data)
        {
            Product = data[0];
            Name = data[1];
            Adress = data[2];
            Telephone = data[3];
            Email = data[4];
            var disc = new StringBuilder();
            foreach (var line in data.Skip(5))
            {
                disc.Append("/");
                disc.Append(line);
            }
            Discription = disc.ToString();
        }

        public override string ToString()
        {
            return Product + "/" + Name + "/" + Adress + "/" + Telephone + "/" + Email + Discription;
        }
    }
}

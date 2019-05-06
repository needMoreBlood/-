using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class User
    {
        public string Name { get;  }
        public string Adress { get;  }
        public  string Phone { get;  }
        public string Email { get; }

        public User(string name, string adress, string phone, string email)
        {
            Name = name;
            Adress = adress;
            Phone = phone;
            Email = email;
        }
    }
}

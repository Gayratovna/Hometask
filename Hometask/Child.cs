using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask
{
    public class Child
    {
        private string name = "Saida";
        private int age = 18;

        public Child(string _name, int _age)
        {
            _name = name;
            _age = age;

        }
        public string Name
        {
            get
            {
                return name;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
        }

    }
}
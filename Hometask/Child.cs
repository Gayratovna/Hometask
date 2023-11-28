using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask
{
    public class Child
    {
        private string name;
        private int age;

        public Child(string _name, int _age)
        {
            _name = name;
            _age = age;

        }
        public string Name
        {
            set
            {
                this.name = value;
            }
        }

        public int Age
        {
            set
            {
                this.age = value;
            }
        }

        public void GettAllInfo()
        {
            Console.WriteLine($"Name: {name}\n" +
                              $"Age: {age}");




        }




    }
}


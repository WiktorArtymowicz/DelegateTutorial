using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTutorial
{
    public class Person
    {
        private string _name = string.Empty;
        private int _age = 0;

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public Person()
        {

        }

        public override string ToString()
        {
            return $"Imię: {_name}, Wiek: {_age}";
        }
    }
}

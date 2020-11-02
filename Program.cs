using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTutorial
{
    class Program
    {
        public delegate bool FunctionDelegate(Person person);
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person() { Name = "Wiktor", Age = 28 });
            people.Add(new Person() { Name = "Anna", Age = 30 });
            people.Add(new Person() { Name = "Adam", Age = 5 });

            FunctionDelegate functionDelegate = new FunctionDelegate(TestBool);

            GetOlder(people, x => x.Age <= 20);

            Console.ReadLine();
        }

        public static void GetOlder(List<Person> people, FunctionDelegate functionDelegate)
        {
            
            foreach (var item in people)
            {
                if (functionDelegate(item))
                {
                    item.Age++;
                    Console.WriteLine(item.ToString());
                }
            }
        }

        public static bool TestBool(Person person)
        {
            if (person.Age > 10)
                return true;
            else
                return false;
        }
    }

}

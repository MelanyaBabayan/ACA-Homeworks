using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class Animal
    {
        string Name { get; set; }
        public Animal(string name) 
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        virtual public void Speak()
        {
            Console.WriteLine("Animal sound.");
        }
    }
}

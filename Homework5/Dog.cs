using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }
        override public void Speak()
        {
            Console.WriteLine("Woof!");
        }
    }
}

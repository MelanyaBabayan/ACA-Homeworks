using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class Cow : Animal
    {
        public Cow(string name) : base(name)
        {
        }
        public override void Speak()
        {
            Console.WriteLine("Moo!");
        }
    }
}

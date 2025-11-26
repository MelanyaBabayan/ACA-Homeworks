using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class ErrorMessage : Message
    {
        public override void Print()
        {
            Console.WriteLine("Error occurred!");
        }
    }
}

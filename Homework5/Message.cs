using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    //create base class Message
    public class Message
    {
        virtual public void Print()
        {
            Console.WriteLine("Generic message.");
        }
    }
}

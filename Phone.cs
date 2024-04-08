using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NewHomeWork
{
    internal class Phone
    {
        public int number;
        string model;
        double weight;

        public Phone()
        {
        }
        public Phone(int number)
        {
            this.number = number;
        }
        public Phone(int number, string model)
        {
            this.number = number;
            this.model = model;
        }
        public Phone(int number, string model, double weight)
        {
            this.number = number;
            this.model = model;
            this.weight = weight;
        }

        public void ReceiveCall(string name)
        {
            Console.WriteLine($"звонит : {name}");
        }

        public int  GetNumber()
        {           
            Console.WriteLine($"{number}");
            return number;
        }
        public void SendMessage(int number)
        {
            Console.WriteLine($"Send mwssage to number  {number}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHomeWork
{
    public class Therapist : Doctor
    {        
        public Therapist(string doctorName) : base(doctorName) 
        { 
        
        }
        public void Treat(string doctorName)
        {
            Console.WriteLine($"Лечит терапевт {doctorName}");
        }
    }
}

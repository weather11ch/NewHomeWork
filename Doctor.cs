using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHomeWork
{
    public class Doctor
    {
        public string doctorName;

        public enum DocSpec
        {
            surgeon,
            dentist,
            therapist
        }
        public Doctor(string doctorName) 
        {
            this.doctorName = doctorName;

        }
        public void Treat(string doctorName)
        {
            Console.WriteLine($"Лечит {doctorName}");
        }
    }
}

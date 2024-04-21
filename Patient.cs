using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHomeWork
{
    public class Patient
    {
        public String patient;
        public Patient(string patient) 
        {
            this.patient = patient;
        }
        public Patient(string patient, int planCode)
        {
            this.patient = patient;            
        }
        public void AppointTreatmentPlan(int planCode)
        {
            Console.WriteLine($"Пациенту  {patient} назначен план лечения с кодом {planCode}");
        
        }
    }
}

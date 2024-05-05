using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHomeWork
{
    public class TreatmentPlan
    {
        public int planCode;
        public TreatmentPlan(int planCode)
        {
            this.planCode = planCode;
        }
        public static void TreatmentPlanAdd(Patient patient, int planCode)
        {

            Console.WriteLine($"Пациенту {patient.patient} назнчен план лечения {planCode} ");
            patient.AppointTreatmentPlan(planCode);
        }
    }
}


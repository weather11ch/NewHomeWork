using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHomeWork
{
    internal class CreditCard
    {
        public int BillNumber { get; set; }
        public double BillSum {  get; set; }
        public CreditCard(int billnumber, double billsum ) 
        {
            this.BillNumber = billnumber;
            this.BillSum = billsum;
        }

        public void CreditCardTakeOff(int billnumber, double sum)
        {
            if (sum > BillSum) { Console.WriteLine($"on bill {BillNumber} not enouth money"); }
            else
            {
                BillSum -= sum;
                Console.WriteLine($"from {billnumber} taked off  {sum} RUB");
            }
        }
        public void CreditCardCharge(int billnumber, double sum)
        {            
            BillSum += sum;
            Console.WriteLine($"on {billnumber} charged  {sum} RUB");
        }
        public void CreditCardGetInfo()
        {
            Console.WriteLine($"Credit card {BillNumber}  have {BillSum} RUB");
        }

    }
}

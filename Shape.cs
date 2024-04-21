using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHomeWork
{
    public class Shape
    {
        public int lengthParameter1;
        public int lengthParameter2;
        public int lengthParameter3;
        public Shape(int lengthParameter1) 
        { 
            this.lengthParameter1 = lengthParameter1;
        }
        public Shape(int lengthParameter1, int lengthParameter2)
        {
            this.lengthParameter1 = lengthParameter1;
            this.lengthParameter2 = lengthParameter2;
        }
        public Shape(int lengthParameter1, int lengthParameter2, int lengthParameter3)
        {
            this.lengthParameter1 = lengthParameter1;
            this.lengthParameter2 = lengthParameter2;
            this.lengthParameter3 = lengthParameter3;
        }
    }
}

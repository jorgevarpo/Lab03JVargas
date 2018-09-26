using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0
{
   public class Student : Person
    {
        public double Average { get; set; }

        public override string GetSummary()
        {
            return base.GetSummary() + ", AVG: "+ Average;
        }
    }
}

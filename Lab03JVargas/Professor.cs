using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0
{
    public class Professor:Person
    {
        public string[] Courses { get; set; }

        public override string GetSummary()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.GetSummary());

            for (int i = 0; i < Courses.Length; i++)
            {
                sb.AppendLine(Courses[i]);
            }

            return sb.ToString();
           
        }
    }
}

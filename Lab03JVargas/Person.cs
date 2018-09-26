using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public string GetName(string nombre)
        {
            return nombre;
        }

        public virtual string GetSummary() {
            return string.Format("{0}{1}", Name, LastName);
        }

        public static string GetStaticName(string nombre)
        {
            return nombre;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Person p = new Person() {
                Name = "Juan",
                LastName = "Perez"
            };

            Student s = new Student() {
                Name = "Pedro",
                LastName = "Lopez"
            };

            Professor pro = new Professor()
            {
                Name = "Mario",
                LastName = "Bros",
                Courses = new string[] { "DAS c3" }

            };
        }

           //public static void PrintReport(Person p)
            //{
            //Console.WriteLine("-------" + p);
            //Console.WriteLine(p.GetSummary());
            //Console.WriteLine("-------");
            ///}

           // public static string PrintReport(Person p) {
           //
             //   return p.LastName + " " + p.LastName;
            //}

            //public static string PrintReport(Person p) {
             //   return p.Name + " " + p.LastName;
           // }


        
    }
}

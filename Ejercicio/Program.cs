using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Base bas = new Base();
            bas.Crear();
            //Consulta(bas);
            while (Consulta(bas)) {
            }
        }

        public static bool Consulta(Base bas)
        {
            Console.WriteLine("Ingrese id Cliente");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Monto de la compra");
            var monto = Decimal.Parse(Console.ReadLine());

            Console.WriteLine(bas.Actualizar(id, monto));
            Console.ReadKey();
            Console.WriteLine(bas.Mostrar(id));
            Console.ReadKey();

            Console.WriteLine("Consultar otro cliente? \n 1-si 2-no");
            int op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                return true;
            }
            else
            {
                return false;


            }


        }

       
    }
}

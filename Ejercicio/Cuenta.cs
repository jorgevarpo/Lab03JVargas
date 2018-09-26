using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    public class Cuenta
    {   
       public int Id { get; set; }
        public  decimal Saldo { get; set; }
       public List<string> Movimiento { get; set; }

        public virtual string Movs()
        {
            if (Movimiento.Count> 0)
            {
                StringBuilder sb = new StringBuilder();
                foreach (String i in Movimiento)
                {
                    sb.Append(i+Environment.NewLine);

                }
                return sb.ToString();

            }
            else {
                return "No hay movimientos";  
            }

        }

        public virtual bool Actualiza(int id, decimal monto)
        {
            throw new NotImplementedException();
        }

    }







}


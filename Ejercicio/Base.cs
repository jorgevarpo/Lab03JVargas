using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
   class Base
    {

        public Base() { }

        public static List<Cuenta> Movimiento = new List<Cuenta>();

        public void Crear() {
            Movimiento.Add(new Debito(1, 100));
            Movimiento.Add(new Debito(2, 100));
            Movimiento.Add(new Credito(3, 100));
            Movimiento.Add(new Credito(4, 100));
        }


        public String Actualizar(int id, decimal monto)
        {
            string respuesta= "Cliente no registrado";
            foreach (Cuenta i in Movimiento)
            {
                if (i.Id == id)
                {
                    if (i.Actualiza(id, monto))
                    {
                        respuesta= "Compra Realizada";
                    }
                    else
                    {
                        respuesta = "No tiene fondos";
                    }
                }
            }
            return respuesta;
        }

        public String Mostrar(int id)
        {
            string respuesta = "Cliente no registrado";
            foreach (Cuenta i in Movimiento)
            {
                if (i.Id == id)
                {
                    respuesta = i.Movs();
                }
            }
            return respuesta;
        }
    }
}

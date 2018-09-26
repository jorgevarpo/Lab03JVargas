using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class Credito:Cuenta
    {
        public Credito(int ids, decimal sald)
        {
            Id = ids;
            Saldo = sald;
            Movimiento = new List<string>();
        }

        public override bool Actualiza(int id , decimal monto)
        {
            if (monto > Saldo)
            {
                return false;
            }
            else
            {
                decimal saldoAct = Saldo;
                Saldo -= monto;
                Movimiento.Add("Disponible Anterior: " + saldoAct + " Credito:" + monto + " Disponible para compras: " + Saldo);
                return true;
            }
        }
    }
}

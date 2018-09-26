using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class Debito:Cuenta
    {
        public Debito(int ids, decimal sald)
        {
            Id = ids;
            Saldo = sald;
            Movimiento = new List<string>();
        }


        public override bool Actualiza(int id,decimal monto){
            if (monto > Saldo)
            {
                return false;
            }
            else
            {
                decimal saldoAct = Saldo;
                Saldo -= monto;
                Movimiento.Add( "Saldo Anterior: " + saldoAct + " Debito:" + monto + " Saldo Actual: " + Saldo);
                return true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppBilletera.Modelo
{
    public class Ingreso : IIngreso
    {
        decimal IIngreso.Ingreso(decimal saldo, decimal importe)
        {
            Decimal result=0;

            if (importe > 0) {
                result = saldo + importe;
            }
                
            if (result < 0) { result = 0; }
            return result;
        }
    }
}

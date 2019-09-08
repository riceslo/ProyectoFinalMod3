using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppBilletera.Modelo
{
    public class Egreso : IEgreso

    {
        decimal IEgreso.Egreso(decimal saldo, decimal importe)
        {
            Decimal result;

            if (saldo == 0)
            {
                result = 0;
            }
            else
            { 
            result = saldo - importe;
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppBilletera.Modelo
{
    interface IEgreso
    {
        Decimal Egreso(Decimal saldo, Decimal importe);
    }
}

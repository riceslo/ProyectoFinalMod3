using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppBilletera.Modelo
{
    interface IIngreso {

       Decimal Ingreso(decimal saldo, decimal importe); 
    }
}
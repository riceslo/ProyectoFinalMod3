using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppBilletera.Modelo
{
    public class Billetera
    {
        private static IIngreso _ingreso;
        private static IEgreso _egreso;

        private readonly static Billetera _instance = new Billetera();

        private Billetera()
        {
            _ingreso = new Ingreso();
            _egreso = new Egreso();
            Saldo = 0;
        }

        public static Billetera Instance
        {
            get
            {
                return _instance;
            }
        }

        public decimal Saldo { get; set; }

        public decimal Ingreso(decimal importe) {
            Saldo = _ingreso.Ingreso(Saldo, importe);
            return Saldo;
        }

        public decimal Egreso(decimal importe)
        {
            Saldo = _egreso.Egreso(Saldo, importe);
            return Saldo;
        }

    }
}

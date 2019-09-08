using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppBilletera.Modelo;

namespace BilleteraTest
{
    [TestClass]
    public class BileteraTest
    {
        [TestMethod]
        public void IngresoNumeroNegativoConSaldoCero()
        {
            Billetera _billetera = Billetera.Instance;

            _billetera.Saldo = 0;

            Assert.AreEqual(0, _billetera.Ingreso(-2));

        }

        [TestMethod]
        public void IngresoNumeroCeroConSaldoCero()
        {
            Billetera _billetera = Billetera.Instance;

            _billetera.Saldo = 0;

            Assert.AreEqual(0, _billetera.Ingreso(0));

        }


        [TestMethod]
        public void IngresoNumeroDiezConSaldoCero()
        {
            Billetera _billetera = Billetera.Instance;

            _billetera.Saldo = 0;

            Assert.AreEqual(10, _billetera.Ingreso(10));

        }

        [TestMethod]
        public void IngresoNumeroDiezConSaldoDiez()
        {
            Billetera _billetera = Billetera.Instance;

            _billetera.Saldo = 10;

            Assert.AreEqual(20, _billetera.Ingreso(10));

        }

        [TestMethod]
        public void EgresoNumeroNegativoConSaldoCero()
        {
            Billetera _billetera = Billetera.Instance;

            _billetera.Saldo = 0;

            Assert.AreEqual(0, _billetera.Egreso(-2));

        }

        [TestMethod]
        public void EgresoNumeroDiezConSaldoCero()
        {
            Billetera _billetera = Billetera.Instance;

            _billetera.Saldo = 0;

            Assert.AreEqual(0, _billetera.Egreso(10));

        }


        [TestMethod]
        public void EgresoNumeroCincoConSaldoDiez()
        {
            Billetera _billetera = Billetera.Instance;

            _billetera.Saldo = 10;

            Assert.AreEqual(5, _billetera.Egreso(5));

        }

    }
}

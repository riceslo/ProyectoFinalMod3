using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppBilletera.Modelo;

namespace AppBilletera
{
    public partial class Servicio : System.Web.UI.Page
    {
        public static Billetera _billetera = Billetera.Instance;

        [System.Web.Services.WebMethod]
        protected static void Ingreso(List<JSONOBJECT> jSONOBJECTS)

        {
            JSONOBJECT jSONOBJECT;
            jSONOBJECT = jSONOBJECTS[0];
            _billetera.Ingreso(jSONOBJECT.valor);
        }



        [System.Web.Services.WebMethod]
        public static List<JSONOBJECT> GetSaldo()
        {

            List<JSONOBJECT> jSONOBJECTS = new List<JSONOBJECT>();
            JSONOBJECT jSONOBJECT = new JSONOBJECT();

            jSONOBJECT.valor = _billetera.Saldo;

            jSONOBJECTS.Add(jSONOBJECT);

            return jSONOBJECTS;
        }



    }
}
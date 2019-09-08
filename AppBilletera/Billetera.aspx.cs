using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppBilletera.Modelo;

namespace AppBilletera
{
    public partial class _Billetera : Page
    {

        public static Billetera _billetera = Billetera.Instance;

        protected void Page_Load(object sender, EventArgs e)
        {
          if (IsPostBack == false)
            {
                txtEgreso.Value = "";
                txtIngreso.Value = "";
            }

            
        }

        protected void lbtIngreso_Click(object sender, EventArgs e)
        {
            spnSaldo.InnerText =  Convert.ToString( _billetera.Ingreso(Convert.ToDecimal(txtIngreso.Value)));
        }

        protected void lbtEgreso_Click(object sender, EventArgs e)
        {
            spnSaldo.InnerText = Convert.ToString(_billetera.Egreso(Convert.ToDecimal(txtEgreso.Value)));
        }


    }
}
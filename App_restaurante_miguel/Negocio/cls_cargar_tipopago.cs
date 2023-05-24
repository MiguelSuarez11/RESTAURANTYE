using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_cargar_tipopago
    {
        private DataTable dt;
        public void fnt_Cargartipopago()
        {
            cls_funciones_facturas objDt = new cls_funciones_facturas();
            objDt.fnt_CargarTipoPago();
            this.dt = objDt.getDt();
        }
        public DataTable getDt() { return this.dt; }
    }
}

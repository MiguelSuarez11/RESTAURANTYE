using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_cargar_domiciliarios
    {
        private DataTable dt;
        public void fnt_CargarDomiciliario()
        {
            cls_funciones_pedidos objDt = new cls_funciones_pedidos();
            objDt.fnt_Cargarpersonales();
            this.dt = objDt.getDt();
        }

       

        public DataTable getDt() { return this.dt; }
    
}
}

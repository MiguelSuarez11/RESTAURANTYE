using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_cargar_rol
    {
        private DataTable dt;
        public void fnt_CargarRol()
        {
            cls_funciones_personal objDt = new cls_funciones_personal();
            objDt.fnt_CargarRol();
            this.dt = objDt.getDt();
        }

        public DataTable getDt() { return this.dt; }
    }
}

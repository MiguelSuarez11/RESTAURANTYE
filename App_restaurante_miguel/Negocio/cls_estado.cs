using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Negocio
{
    public class cls_estado
    {
        private DataTable dt;
        public void fnt_CargarEstado()
        {
            cls_funciones_restaurante objDt = new cls_funciones_restaurante();
            objDt.fnt_CargarEstado();
            this.dt = objDt.getDt();
        }
        public void fnt_CargarEstado1()
        {
            cls_funciones_personal objDt = new cls_funciones_personal();
            objDt.fnt_CargarEstado();
            this.dt = objDt.getDt();
        }

        public void fnt_CargarEstado2()
        {
            cls_funciones_pedidos objDt = new cls_funciones_pedidos();
            objDt.fnt_CargarEstado();
            this.dt = objDt.getDt();
        }
        public DataTable getDt() { return this.dt; }
    }
}

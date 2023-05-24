using System.Data;
using Datos;
namespace Negocio
{
    public class cls_tipo
    {

        private DataTable dt;
        public void fnt_CargarTipo()
        {
            cls_funciones_restaurante objDt = new cls_funciones_restaurante();
            objDt.fnt_CargarTipo();
            this.dt = objDt.getDt();
        }

        public DataTable getDt() { return this.dt; }
    }
}

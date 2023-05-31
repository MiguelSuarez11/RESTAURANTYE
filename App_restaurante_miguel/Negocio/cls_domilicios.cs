using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_domilicios
    {
        //private string str_Id;
        //private string str_nombre;

        //public void fnt_Consultar2(string id)
        //{
        //    cls_Domicilios obj_Consultar = new cls_Domicilios();
        //    obj_Consultar.fnt_consultar(id);
        //    this.str_nombre = obj_Consultar.getNombre();
        //}

        //public string getNombre() { return this.str_nombre; }






        private DataTable dt;
        public void fnt_CargarDomiciliario( string id)
        {
            cls_Domicilios objDt = new cls_Domicilios();
            objDt.fnt_Cargardomi(id);
            this.dt = objDt.getDt();
        }

      


        public DataTable getDt() { return this.dt; }

    }

}

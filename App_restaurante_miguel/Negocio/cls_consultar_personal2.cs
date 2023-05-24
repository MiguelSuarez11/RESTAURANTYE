using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_consultar_personal2
    {
        private string str_Identificacion;
        private int int_estado;
        private int int_rol;

        public void fnt_Consultar2(string identificacion)
        {
           
            


                cls_funciones_personal obj_Consultar = new cls_funciones_personal();
                obj_Consultar.fnt_consultar2(identificacion);
                this.int_estado = obj_Consultar.getEstado();
                this.int_rol = obj_Consultar.getRol();





        }


        public int getEstado() { return this.int_estado; }
        public int getRol() { return this.int_rol; }
       

    }


}

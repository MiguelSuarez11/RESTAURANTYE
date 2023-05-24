using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_actualizar_personal2
    {
        private string str_Identificacion;
        private int int_estado;
        private int int_rol;
     


        public cls_actualizar_personal2(

            string str_Identificacion, int int_estado , int int_rol)
        {
            this.str_Identificacion = str_Identificacion;
            this.int_estado = int_estado;
            this.int_rol = int_rol;
          
            {
                cls_funciones_personal obj_Guardar = new cls_funciones_personal();
                obj_Guardar.fnt_Actualizar2(str_Identificacion, int_estado , int_rol);
              

            }



        }
        
    }
}


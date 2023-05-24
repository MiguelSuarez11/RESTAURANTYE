using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_actualizar_personal
    {
        private string str_Identificacion;
        private string str_nombre;
        private string str_contacto;
        private string str_correo;
        private string str_msn;




        public cls_actualizar_personal(

            string str_Identificacion,
            string str_nombre,
            string str_contacto,
            string str_correo)
        {
            this.str_Identificacion = str_Identificacion;
            this.str_nombre = str_nombre;
            this.str_contacto = str_contacto;
            this.str_correo = str_correo;
            if (str_Identificacion == "" || str_nombre == "" || str_contacto == "" || str_correo == "")
            {
                str_msn = "Debe ingresar toda la unformacion requerida";
            }
            else
            {
                cls_funciones_personal obj_Guardar = new cls_funciones_personal();
                obj_Guardar.fnt_Actualizar(str_Identificacion, str_nombre, str_contacto, str_correo );
                str_msn = "  la persona " + str_nombre + "  ha sido actualizado";

            }



        }
        public string getMsn() { return str_msn; }
    }

}

using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_agregar_personal
    {

        private string str_Identificacion;
        private string str_nombre;
        private string str_contacto;
        private string str_correo;
        private string str_msn;
       



        public cls_agregar_personal(

            string str_identificacion,
            string str_nombre,
            string str_contacto,
            string str_correo )
        {

            this.str_Identificacion = str_identificacion;
            this.str_nombre = str_nombre;
            this.str_contacto = str_contacto;
            this.str_correo = str_correo;
            {

                {
                    cls_funciones_personal obj_Guardar_personal = new cls_funciones_personal();

                    obj_Guardar_personal.fnt_Guardar(str_identificacion, str_nombre, str_contacto, str_correo );


                }
            }


        }
       


        public string getMsn() { return str_msn; }

    }
}

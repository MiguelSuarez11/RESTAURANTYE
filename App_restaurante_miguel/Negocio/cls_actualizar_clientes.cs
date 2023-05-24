using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_actualizar_clientes
    {
        private string str_Identificacion;
        private string str_nombre;
        private string str_contacto;
        private string str_direccion;
        private string str_msn;




        public cls_actualizar_clientes(

            string str_Identificacion,
            string str_nombre,
            string str_contacto,
            string str_direccion)
        {
            this.str_direccion = str_direccion;
            this.str_nombre = str_nombre;
            this.str_contacto = str_contacto;
            this.str_direccion = str_direccion;
            if (str_Identificacion == "" || str_nombre == "" || str_contacto == "" || str_direccion == "")
            {
                str_msn = "Debe ingresar toda la unformacion requerida";
            }
            else
            {
                cls_funciones_clientes obj_Guardar = new cls_funciones_clientes();
                obj_Guardar.fnt_Actualizar(str_Identificacion, str_nombre, str_contacto, str_direccion);
                str_msn = "  El Cliente " + str_nombre + "  ha sido actualizado";

            }



        }
        public string getMsn() { return str_msn; }
    }
    }


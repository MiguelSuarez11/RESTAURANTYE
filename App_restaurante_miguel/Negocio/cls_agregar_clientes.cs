using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_agregar_clientes
    {

        private string str_Identificacion;
        private string str_nombre;
        private string str_contacto;
        private string str_direccion;
        private string str_msn;




        public cls_agregar_clientes(

            string str_identificacion,
            string str_nombre,
            string str_contacto,
            string str_direccion)
        {

            this.str_direccion = str_direccion;
            this.str_nombre = str_nombre;
            this.str_contacto = str_contacto;
            this.str_direccion = str_direccion;
            {

                {
                    cls_funciones_clientes obj_Guardar_clientes = new cls_funciones_clientes();

                    obj_Guardar_clientes.fnt_Guardar(str_identificacion, str_nombre, str_contacto, str_direccion);


                }
            }


        }



        public string getMsn() { return str_msn; }



    }
}

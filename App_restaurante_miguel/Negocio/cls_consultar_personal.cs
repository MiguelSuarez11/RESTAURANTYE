using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_consultar_personal
    {
        private string str_Identificacion;
        private string str_nombre;
        private string str_contacto;
        private string str_correo;
        private string str_msn;
      

        public void fnt_Consultar(string identificacion)
        {
            if (str_Identificacion == "" || str_nombre == "" || str_contacto == "" || str_correo == "")
            {
                str_msn = "Debe ingresar toda la unformacion requerida";
            }




            else
            {


                cls_funciones_personal obj_Consultar = new cls_funciones_personal();
                obj_Consultar.fnt_consultar(identificacion);
                this.str_nombre = obj_Consultar.getNombre();
                this.str_contacto = obj_Consultar.getContacto();
                this.str_correo = obj_Consultar.getCorreo();
               

            }


        }



        public string getNombre() { return this.str_nombre; }
        public string getContacto() { return this.str_contacto; }
        public string getCorreo() { return this.str_correo; }
        public string getMsn() { return str_msn; }
    }
}

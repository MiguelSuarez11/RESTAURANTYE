using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_traer
    {
        private string str_rol;
        private string str_mensaje;

        public cls_traer()
        {

            Datos.cls_login obj_login = new Datos.cls_login();
            this.str_rol = obj_login.getRol();
            this.str_mensaje = obj_login.getMsn();
        }




       
        public string getRol() { return str_rol; }
        public string getMsn() { return str_mensaje; }
    }
    }




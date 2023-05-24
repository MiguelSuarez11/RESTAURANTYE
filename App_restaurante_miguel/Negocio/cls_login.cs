using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_login
    {
        private string str_nombre;
        private string str_estado;
        private string str_rol;
        private string str_msn;

        public cls_login(string user, string password)
        {
            if (user == "" || password == "")
            {
                this.str_msn = "Ingrese la informcaion requerida";
            }
            else
            {
                Datos.cls_login obj_login = new Datos.cls_login();
                obj_login.fnt_ConsultarU(user, password);
                this.str_estado = obj_login.getEstado();
                this.str_nombre = obj_login.getNombre();
                this.str_rol = obj_login.getRol();
                this.str_msn = obj_login.getMsn();
            }
        


 

        }
        public string getNombre() { return str_nombre; }
        public string getEstado() { return str_estado; }
        public string getRol() { return str_rol; }
        public string getMsn() { return str_msn; }

    }
}

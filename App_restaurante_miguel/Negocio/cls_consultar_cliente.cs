using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_consultar_cliente
    {
        private string str_Identificacion;
        private string str_nombre;
        private string str_contacto;
        private string str_direccion;
        private string str_msn;

        public void fnt_Consultar(string identificacion)
        {
            if (str_Identificacion == "" || str_nombre == "" || str_contacto == "" || str_direccion == "")
            {
                this.str_msn = "Ingrese la informcaion requerida";
            

            }
            else
            {


                cls_funciones_clientes obj_Consultar = new cls_funciones_clientes();
                obj_Consultar.fnt_consultar(identificacion);
                this.str_nombre = obj_Consultar.getNombre();
                this.str_contacto = obj_Consultar.getContacto();
                this.str_direccion = obj_Consultar.getDireccion();
                this.str_msn = obj_Consultar.getMsn();
            }
        }

       

        public string getNombre() { return this.str_nombre; }
        public string getContacto() { return this.str_contacto; }
        public string getDireccion() { return this.str_direccion; }

        public string getMsn() { return str_msn; }
    }
}

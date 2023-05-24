using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_consultar_facturas
    {
        private string str_identificacion;
        private int int_N_pedido;
        private string str_mensaje;


        public void fnt_Consultar_pedido(string str_identificacion)
        {


            if (str_identificacion == "")
            {
                str_mensaje = "Debe ingresar toda la unformacion requerida";
            }
            else
            {


                cls_funciones_facturas obj_Consultar = new cls_funciones_facturas();
                obj_Consultar.fnt_consultar(str_identificacion);
                this.int_N_pedido = obj_Consultar.getN_pedido();
                this.str_mensaje = obj_Consultar.getMensaje();
                
            }
        }
        public int getN_pedido() { return this.int_N_pedido; }
        public string getMensaje() { return str_mensaje; }
    }
}

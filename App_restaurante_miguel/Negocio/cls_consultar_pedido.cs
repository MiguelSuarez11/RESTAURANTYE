using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_consultar_pedido
    {
        private string str_Identificacion;
        private double dbl_valor;
        private int int_estado;
        private string str_msn;


        public void fnt_Consultar_pedido(string identificacion)
        {


            if (str_Identificacion == "" )
            {
                str_msn = "Debe ingresar toda la unformacion requerida";
            }
            else
            {


                cls_funciones_pedidos obj_Consultar = new cls_funciones_pedidos();
                obj_Consultar.fnt_consultar(identificacion);
                this.dbl_valor = obj_Consultar.getValor();
                this.int_estado = obj_Consultar.getEstado();
            }




        }

        public double getValor() { return dbl_valor; }
        public int getEstado() { return this.int_estado; }
       


    }
}

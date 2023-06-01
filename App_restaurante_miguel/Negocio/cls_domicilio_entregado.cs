using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_domicilio_entregado
    {
        private string codigo;
        private int pedido;
        private string str_msn;
        public cls_domicilio_entregado(
            string codigo, int pedido)
        {
            this.codigo = codigo;
            this.pedido = pedido;
            {
                cls_Domicilios domiciolios = new cls_Domicilios();
                domiciolios.fnt_entregado(codigo, pedido);
                str_msn = "Pedido entregado con exito";
            }
        }

        public string getMsn() { return str_msn; }
    }
}

using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_seleccionar_dom
    {
        private string codigo;
        private int pedido;
        private string str_msn;
        public cls_seleccionar_dom(
            string codigo, int pedido)
        {
            this.codigo = codigo;
            this.pedido = pedido;
        {
                cls_Domicilios domiciolios = new cls_Domicilios();
                domiciolios.fnt_Actualizar(codigo, pedido);
                str_msn = "  El Pedido  ha sido seleccionado";
            }
        }

        public string getMsn() { return str_msn; }

    }
}

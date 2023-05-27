using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_seleccionar_domicilio
    {
        private string id;
        private int pedido;

        public cls_seleccionar_domicilio(

       string id, 
       int pedido)
        {
            this.id = id;
            this.pedido = pedido;
         
            {
                cls_Domicilios obj_Guardar = new cls_Domicilios();
                obj_Guardar.fnt_guardarseleccion(id,pedido);
             

            }



        }
    }
}

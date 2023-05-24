using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_agregar_pago
    {
        private int tipopago;

        public void fnt_registrar_pago( int tipopago)
        {
            cls_funciones_facturas obj_pago = new cls_funciones_facturas();
            obj_pago.fnt_Guardar2(tipopago);
           
        }

    }
}

using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_facturacion
    {
        private int int_ultima;

        public void fnt_Facturar(string id,  double valor , string id_usuario , string id_domi)
        {
            cls_funciones_pedidos obj_Factura = new cls_funciones_pedidos();
            obj_Factura.fnt_Registrar_Enc_Pedido(id, valor , id_usuario , id_domi);
            this.int_ultima = obj_Factura.getUltimoPedido();
        }
        public void fnt_det_pedido(int no_ped, double valor, int cant , int cod_ped)
        {
            cls_funciones_pedidos obj_facturar = new cls_funciones_pedidos();
            obj_facturar.fnt_registrar_Det_pedido(no_ped, valor, cant , cod_ped);
        }

        public void fnt_registrar_factura(int no_ped, double subtotal, double iva , double total , int tipopago)
        {
            cls_funciones_pedidos obj_facturas = new cls_funciones_pedidos();
            obj_facturas.fnt_Registrar_Factura(no_ped, subtotal, iva, total , tipopago);
        }
        public int getUltimoPedido() { return this.int_ultima; }
    }
}

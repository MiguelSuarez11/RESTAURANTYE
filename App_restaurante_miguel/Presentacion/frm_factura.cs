using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frm_factura : Form
    {
        public frm_factura()
        {
            InitializeComponent();
            fnt_Cargartipopago();
        }

        private void fnt_consultar(string identificacion)

        {


            cls_consultar_facturas obj_Consultar = new cls_consultar_facturas();

            {
                obj_Consultar.fnt_Consultar_pedido(identificacion);
                this.txt_N_pedido.Text = Convert.ToString(obj_Consultar.getN_pedido());
                lbl_mensaje.Text = obj_Consultar.getMensaje();
            }
            lbl_mensaje.Text = obj_Consultar.getMensaje();

        }

        private void fnt_Cargartipopago()
        {
            cls_cargar_tipopago objDt = new cls_cargar_tipopago();
            objDt.fnt_Cargartipopago();
            cbx_tipopago.ValueMember = "PKCodigo";
            cbx_tipopago.DisplayMember = "Nombre";
            cbx_tipopago.DataSource = objDt.getDt();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (cbx_tipopago.Text == "")
            {
                MessageBox.Show("Debe ingresar un metodo de pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                cls_agregar_pago obj_pago = new cls_agregar_pago();
                obj_pago.fnt_registrar_pago( cbx_tipopago.SelectedIndex + 1);
        } 
    }

        private void txt_identificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) || (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)))
            {

                fnt_consultar(txt_identificacion.Text);
               
                e.Handled = true;
                return;

                
            }
        }
    
    
    
    }
}

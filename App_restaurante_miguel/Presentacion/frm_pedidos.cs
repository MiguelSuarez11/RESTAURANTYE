using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.CodeDom;

namespace Presentacion
{
    public partial class frm_pedidos : Form
    {
        public frm_pedidos()
        {
            InitializeComponent();
            //fnt_CargarEstado();
            fnt_Cargartipopago();
        

    }






        //private void fnt_CargarEstado()
        //{
        //    cls_estado objDt = new cls_estado();
        //    objDt.fnt_CargarEstado2();
        //    cbx_estado.ValueMember = "PKCodigo";
        //    cbx_estado.DisplayMember = "Descripcion";
        //    cbx_estado.DataSource = objDt.getDt();
        //}


        private void fnt_nuevo() 
        {
            txt_identificacion.Focus();
            txt_identificacion.Clear();
            txt_nombre.Clear();
            txt_direccion.Clear();
            txt_contacto.Clear();
            txt_codigo.Clear();
            txt_nombre_plato.Clear();
            txt_ingredientes.Clear();
            txt_valorU.Clear();
            txt_Cantidad.Clear();
            this.dgvLista.DataSource = null;
            this.dgvLista.Rows.Clear();
        }

        private void fnt_consultar(string identificacion)

        {

            
            cls_consultar_cliente obj_Consultar = new cls_consultar_cliente();
          
            {
                obj_Consultar.fnt_Consultar(identificacion);
                txt_nombre.Text = obj_Consultar.getNombre();
                txt_direccion.Text = obj_Consultar.getDireccion();
                txt_contacto.Text = obj_Consultar.getContacto();
                lbl_mensaje.Text = obj_Consultar.getMsn();
            }
            lbl_mensaje.Text = obj_Consultar.getMsn();
          
        }

       

        //private void fnt_consultar2(string identificacion)

        //{
        //    txt_identificacion.Enabled = false;
        //    cls_consultar_pedido obj_Consultar = new cls_consultar_pedido();
        //    obj_Consultar.fnt_Consultar_pedido(identificacion);
        //    Convert.ToDouble (obj_Consultar.getValor());
           
        //    cbx_estado.SelectedIndex = obj_Consultar.getEstado() - 1;
        //}
        private void btn_consultar_Click(object sender, EventArgs e)
        {

        }

        private void txt_identificacion_KeyPress(object sender, KeyPressEventArgs e)
        {

           
            if (e.KeyChar == Convert.ToChar(Keys.Enter) || (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)))
            {
             
                fnt_consultar(txt_identificacion.Text);
                txt_nombre.Visible = true;
                txt_direccion.Visible = true;
                txt_contacto.Visible = true;
                e.Handled = true;
                return;
               // if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {

                  
                }
            }
        }
        private void fnt_login()
        {
          cls_traer rol = new cls_traer();
            if (rol.getRol() == "Cajero")
            {
                frm_cajero obj_ventas = new frm_cajero();
                this.Hide();
            }
            if (rol.getRol() == "Administrador")
            {
                frm_cajero obj_ventas = new frm_cajero();
                this.Hide();
            }

        }

            private void pictureBox4_Click(object sender, EventArgs e)
        {
                fnt_login();     
              
               
            
        }

        private void txt_valor_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cls_connsultar_plato obj_Consultar = new cls_connsultar_plato();
                obj_Consultar.fnt_Consultar(txt_codigo.Text);
                txt_nombre_plato.Text = obj_Consultar.getNombre();
                txt_ingredientes.Text = obj_Consultar.getIngredientes();
                txt_valorU.Text = obj_Consultar.getValor();
                if (obj_Consultar.getMensaje() != "")
                {
                    MessageBox.Show("" + obj_Consultar.getMensaje(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private void fnt_CalcularSubtotal()
        {
            double suma = 0;
            for (int i = 0; i < dgvLista.RowCount; i++)
            {
                suma += Convert.ToDouble(dgvLista.Rows[i].Cells[2].Value) *
                    Convert.ToInt32(dgvLista.Rows[i].Cells[3].Value);
            }
            lbl_Subtotal.Text = Convert.ToString(suma);
            lbl_Iva.Text = Convert.ToString(suma * 0.19);
            lbl_Total.Text = Convert.ToString(Convert.ToDouble(lbl_Subtotal.Text) +
                Convert.ToDouble(lbl_Iva.Text));
        }




        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "" || txt_Cantidad.Text == "")
            {
                MessageBox.Show("Debe ingresar codigo y cantidad del producto", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean sw = false;
                int posi = 0;
                for (int i = 0; i < dgvLista.RowCount; i++)
                {
                    if (txt_codigo.Text == Convert.ToString(dgvLista.Rows[i].Cells[0].Value))
                    {
                        posi = i;
                        sw = true;
                        break;
                    }
                }
                if (sw == true)
                {
                    int cant = Convert.ToInt16(dgvLista.Rows[posi].Cells[3].Value);
                    int new_cant = cant + Convert.ToInt16(txt_Cantidad.Text);
                    dgvLista.Rows[posi].Cells[3].Value = new_cant;
                    fnt_CalcularSubtotal();
                }

                else
                {
                    DataGridViewRow file = new DataGridViewRow();
                    file.CreateCells(dgvLista);

                    file.Cells[0].Value = txt_codigo.Text;
                    file.Cells[1].Value = txt_nombre_plato.Text;
                    file.Cells[2].Value = txt_valorU.Text;
                    file.Cells[3].Value = txt_Cantidad.Text;
                    file.Cells[4].Value = (float.Parse(txt_valorU.Text) * float.Parse(txt_Cantidad.Text)).ToString();
                    file.Cells[5].Value = lbl_Subtotal.Text;
                    file.Cells[6].Value = lbl_Iva.Text;
                    dgvLista.Rows.Add(file);
                   
                    fnt_CalcularSubtotal();
                }
            }
        }






        private void fnt_Cargartipopago()
        {
            cls_cargar_tipopago objDt = new cls_cargar_tipopago();
            objDt.fnt_Cargartipopago();
            cbx_tipopago.ValueMember = "PKCodigo";
            cbx_tipopago.DisplayMember = "Nombre";
            cbx_tipopago.DataSource = objDt.getDt();
        }





        private void imprimir_PrintPage(object sender, PrintPageEventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {

            if (txt_identificacion.Text == "" || txt_nombre.Text == "" || txt_direccion.Text == "")
            {
                MessageBox.Show("Debe ingresar los valores requeridos", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               


                cls_facturacion obj_Facturar = new cls_facturacion();
                for (int i = 0; i < dgvLista.RowCount; i++)
                {
                    ///////////////////// FACTURA
                   

                    /////////////////////////// PEDIDO
                    obj_Facturar.fnt_Facturar(txt_identificacion.Text,
                   Convert.ToDouble(dgvLista.Rows[i].Cells[3].Value));
                   ///////////// DETALLE DE PEDIDO
                    obj_Facturar.fnt_det_pedido(
                        Convert.ToInt32(lbl_pedido.Text = Convert.ToString(obj_Facturar.getUltimoPedido())),
                         Convert.ToDouble(dgvLista.Rows[i].Cells[4].Value),
                          Convert.ToInt32(dgvLista.Rows[i].Cells[3].Value),
                         Convert.ToInt32(dgvLista.Rows[i].Cells[0].Value));
                    lbl_pedido.Text = Convert.ToString(obj_Facturar.getUltimoPedido());


                    obj_Facturar.fnt_registrar_factura(
                    Convert.ToInt32(lbl_pedido.Text = Convert.ToString(obj_Facturar.getUltimoPedido())),
                   Convert.ToInt32(lbl_Subtotal.Text),
                       Convert.ToInt32(lbl_Iva.Text),
                       Convert.ToInt32(lbl_Total.Text),
                       cbx_tipopago.SelectedIndex + 1);
                    lbl_pedido.Text = Convert.ToString(obj_Facturar.getUltimoPedido());

                    MessageBox.Show("Pedido registrado con exito", "PEDIDO EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            
     
            ///////////////////////////// crear factura
            clsFunciones.CreaTicket Ticket1 = new clsFunciones.CreaTicket();

            Ticket1.TextoCentro("Restaurante el punto del sabor "); //imprime una linea de descripcion
            Ticket1.TextoCentro("**********************************");

            Ticket1.TextoIzquierda("");
            Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
            Ticket1.TextoIzquierda("No Fac: 0120102");
            Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda("Le Atendio: xxxx");
            Ticket1.TextoIzquierda("");
            clsFunciones.CreaTicket.LineasGuion();

            clsFunciones.CreaTicket.EncabezadoVenta();
            clsFunciones.CreaTicket.LineasGuion();
            foreach (DataGridViewRow r in dgvLista.Rows)
            {
                // PROD                                            //PrECIO                                    CANT                                   TOTAL
                Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[2].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
            }


            clsFunciones.CreaTicket.LineasGuion();
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Total", double.Parse(lbl_Total.Text)); // imprime linea con total
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Iva:", double.Parse(lbl_Iva.Text));
            Ticket1.AgregaTotales("Subtotal", double.Parse(lbl_Subtotal.Text));


            // Ticket1.LineasTotales(); // imprime linea 

            Ticket1.TextoIzquierda(" ");
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoCentro("*     Gracias por preferirnos    *");

            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoIzquierda(" ");
            string impresora = "Microsoft XPS Document Writer";
            Ticket1.ImprimirTiket(impresora);

            MessageBox.Show("Gracias por preferirnos");

          
        }

       

        private void btn_registrar_Click_1(object sender, EventArgs e)
        {

            if (txt_identificacion.Text == "" || txt_nombre.Text == "" || txt_direccion.Text == "")
            {
                MessageBox.Show("Debe ingresar los valores requeridos", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {



                cls_facturacion obj_Facturar = new cls_facturacion();
                for (int i = 0; i < dgvLista.RowCount; i++)
                {
                    obj_Facturar.fnt_Facturar(txt_identificacion.Text,
                   Convert.ToDouble(dgvLista.Rows[i].Cells[3].Value));
                    obj_Facturar.fnt_det_pedido(
                        Convert.ToInt16(lbl_pedido.Text) + 1,
                         Convert.ToDouble(dgvLista.Rows[i].Cells[3].Value),
                          Convert.ToInt16(dgvLista.Rows[i].Cells[4].Value),
                         Convert.ToInt16(dgvLista.Rows[i].Cells[0].Value));
                    lbl_pedido.Text = Convert.ToString(obj_Facturar.getUltimoPedido());

                    MessageBox.Show("Pedido registrado con exito", "PEDIDO EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_nuevo_Click_1(object sender, EventArgs e)
        {
            fnt_nuevo();
        }

        private void btn_facturar_Click(object sender, EventArgs e)
        {
            clsFunciones.CreaTicket Ticket1 = new clsFunciones.CreaTicket();

            Ticket1.TextoCentro("Restaurante el punto del sabor "); //imprime una linea de descripcion
            Ticket1.TextoCentro("**********************************");

            Ticket1.TextoIzquierda("");
            Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
            Ticket1.TextoIzquierda("No Fac: 0120102");
            Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda("Le Atendio: xxxx");
            Ticket1.TextoIzquierda("");
            clsFunciones.CreaTicket.LineasGuion();

            clsFunciones.CreaTicket.EncabezadoVenta();
            clsFunciones.CreaTicket.LineasGuion();
            foreach (DataGridViewRow r in dgvLista.Rows)
            {
                // PROD                                            //PrECIO                                    CANT                                   TOTAL
                Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[2].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
            }


            clsFunciones.CreaTicket.LineasGuion();
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Total", double.Parse(lbl_Total.Text)); // imprime linea con total
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Iva:", double.Parse(lbl_Iva.Text));
            Ticket1.AgregaTotales("Subtotal", double.Parse(lbl_Subtotal.Text));


            // Ticket1.LineasTotales(); // imprime linea 

            Ticket1.TextoIzquierda(" ");
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoCentro("*     Gracias por preferirnos    *");

            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoIzquierda(" ");
            string impresora = "Microsoft XPS Document Writer";
            Ticket1.ImprimirTiket(impresora);

            MessageBox.Show("Gracias por preferirnos");


        }
    }
}

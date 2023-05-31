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
    public partial class reporte : Form
    {
        public reporte()
        {
            InitializeComponent();
        }

        private void reporte_Load(object sender, EventArgs e)
        {

        }

        private void fnt_cargarDomicilios()
        {
            cls_domilicios objDt = new cls_domilicios();
            objDt.fnt_CargarDomiciliario(txt_identificacion.Text);
            cbx_asignados.ValueMember = "Pedido";
            cbx_asignados.DisplayMember = "Pedido";
            cbx_asignados.DataSource = objDt.getDt();
        }


        //private void fnt_consultar(string identificacion)

        //{
        //    cls_validar_personal obj_validar = new cls_validar_personal();
        //    if (obj_validar.fnt_validar_personal(txt_identificacion.Text) == false)
        //    {
        //        MessageBox.Show("Esta persona no se encuentra registrado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        //    }
        //    else
        //    {
        //        cls_domilicios obj_Consultar = new cls_domilicios();
        //        obj_Consultar.fnt_Consultar2(identificacion);
        //        cbx_asignados.Text = obj_Consultar.getNombre();
               
        //    }

        //}


        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_identificacion_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                cls_validar_personal obj_validar = new cls_validar_personal();
                if (obj_validar.fnt_validar_personal(txt_identificacion.Text) == false)
                {
                    MessageBox.Show("Esta persona no se encuentra registrada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (txt_identificacion.Text == "")
                {

                    MessageBox.Show("Ingrese el criterio de busqueda");
                }
                else

                    fnt_cargarDomicilios();
            }
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            cls_seleccionar_dom domicilios = new cls_seleccionar_dom
                (
                 txt_identificacion.Text,
                 Convert.ToInt16(cbx_asignados.SelectedValue));
            MessageBox.Show("" + domicilios.getMsn());

        }
    }
}

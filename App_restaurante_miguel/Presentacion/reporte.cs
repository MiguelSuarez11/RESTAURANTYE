using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class reporte : Form
    {
        public reporte()
        {
            InitializeComponent();
            fnt_limpiar();

            fnt_cargarDomicilios();


        }


        private void reporte_Load(object sender, EventArgs e)
        {
            fnt_cargarDomicilios();
        }

        private void fnt_cargarDomicilios()
        {
          

            cls_domilicios objDt = new cls_domilicios();
            objDt.fnt_CargarDomiciliario(lbl_domi.Text);
            dtg_pedidos.DataSource = objDt.getDt();
            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(dtg_pedidos);

          
            
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

      
        private void fnt_limpiar() 
        {
           
            
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //cls_domicilio_entregado domicilios = new cls_domicilio_entregado
            //   (
            //    txt_identificacion.Text,
            //    Convert.ToInt16(cbx_asignados.SelectedValue));
            //MessageBox.Show("" + domicilios.getMsn());
            //fnt_limpiar();


        }

        private void btn_seleccionar_Click_1(object sender, EventArgs e)
        {

          

            //cls_seleccionar_dom domicilios = new cls_seleccionar_dom
            //    (
            //     txt_identificacion.Text,
            //     Convert.ToInt16(cbx_asignados.SelectedValue));
            //MessageBox.Show("" + domicilios.getMsn());
            //fnt_limpiar();
        }


        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();



        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

      
    }
}

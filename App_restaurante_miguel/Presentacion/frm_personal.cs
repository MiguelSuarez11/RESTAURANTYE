using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frm_personal : Form
    {
        public frm_personal()
        {
            InitializeComponent();
            txt_identificacion.Enabled = true;
            fnt_CargarRol();
            fnt_CargarEstado();
        }
        private void fnt_nuevo()
        {
            txt_identificacion.Clear();
            txt_contacto.Clear();
            txt_correo.Clear();
            txt_Nombre.Clear();
            txt_identificacion.Enabled = true;
            txt_identificacion.Focus();
        }

        private void fnt_CargarEstado()
        {
            cls_estado objDt = new cls_estado();
            objDt.fnt_CargarEstado1();
            cbx_estado.ValueMember = "PKCodigo";
            cbx_estado.DisplayMember = "Descripcion";
            cbx_estado.DataSource = objDt.getDt();
        }
        private void fnt_CargarRol()
        {
            cls_cargar_rol objDt = new cls_cargar_rol();
            objDt.fnt_CargarRol();
            cbx_rol.ValueMember = "PKCodigo";
            cbx_rol.DisplayMember = "Nombre";
            cbx_rol.DataSource = objDt.getDt();
        }


        //private void btn_nuevo_Click(object sender, EventArgs e)
        //{
        //    fnt_nuevo();
        //}

        //private void btn_Guardar_Click(object sender, EventArgs e)
        //{
        //    MemoryStream ms = new MemoryStream();
        //    if (txt_identificacion.Text == "" || txt_Nombre.Text == "" || txt_contacto.Text == "" || txt_correo.Text == "")
        //    {
        //        MessageBox.Show("Debe ingresar toda la unformacion requerida");
        //    }

        //    if (validarEmail(txt_correo.Text) == false)
        //    {
        //        MessageBox.Show("Direccion de correo no valida");
        //    }
        //    else
        //    {
        //        cls_validar_personal obj_validar = new cls_validar_personal();
        //        if (obj_validar.fnt_validar_personal(txt_identificacion.Text) == true)
        //        {
        //            MessageBox.Show("Este Clientes ya se encuentra registrado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        //        }
        //        else
        //        {

        //            {
        //                cls_agregar_personal objAgregarPersonal = new cls_agregar_personal(
        //                  txt_identificacion.Text,
        //                  txt_Nombre.Text,
        //                  txt_contacto.Text,
        //                  txt_correo.Text);


        //            }
        //        }
        //    }
        //    {
        //        cls_agregar_personal2 objAgregarPersonal2 = new cls_agregar_personal2(
        //           txt_identificacion.Text,
        //           txt_identificacion.Text,
        //           txt_identificacion.Text,
        //           cbx_estado.SelectedIndex + 1,
        //           cbx_rol.SelectedIndex + 1);
        //        MessageBox.Show(" se ha  Registrado con exito");
        //        fnt_nuevo();
        //    }
        //}

        private void fnt_consultar(string identificacion)

        {
            cls_validar_personal obj_validar = new cls_validar_personal();
            if (obj_validar.fnt_validar_personal(txt_identificacion.Text) == false)
            {
                MessageBox.Show("Esta persona no se encuentra registrado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
                txt_identificacion.Enabled = false;
            cls_consultar_personal obj_Consultar = new cls_consultar_personal();
            obj_Consultar.fnt_Consultar(identificacion);
            txt_Nombre.Text = obj_Consultar.getNombre();
            txt_contacto.Text = obj_Consultar.getContacto();
            txt_correo.Text = obj_Consultar.getCorreo();


        }

        private void fnt_consultar2(string identificacion)

        {
            cls_consultar_personal2 obj_Consultar = new cls_consultar_personal2();
            obj_Consultar.fnt_Consultar2(identificacion);
            cbx_estado.SelectedIndex = obj_Consultar.getEstado() - 1;
            cbx_rol.SelectedIndex = obj_Consultar.getRol() - 1;

        }


        //private void btn_consultar_Click(object sender, EventArgs e)
        //{
        //    cls_validar_personal obj_validar = new cls_validar_personal();
        //    if (obj_validar.fnt_validar_personal(txt_identificacion.Text) == false)
        //    {
        //        MessageBox.Show("Esta persona no se encuentra registrada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        fnt_nuevo();
        //    }

        //    if (txt_identificacion.Text == "")
        //    {

        //        MessageBox.Show("Ingrese el criterio de busqueda");
        //    }
        //    else
        //        fnt_consultar2(txt_identificacion.Text);
        //    fnt_consultar(txt_identificacion.Text);
        //}

        //private void btn_actualizar_Click(object sender, EventArgs e)
        //{
        //    cls_actualizar_personal objActulizarPersonal = new cls_actualizar_personal(

        //      txt_identificacion.Text,
        //     txt_Nombre.Text,
        //     txt_contacto.Text,
        //     txt_correo.Text);
        //    MessageBox.Show("" + objActulizarPersonal.getMsn());





        //    cls_actualizar_personal2 objActulizarPersonal2 = new cls_actualizar_personal2(

        //      txt_identificacion.Text,
        //      cbx_estado.SelectedIndex + 1,
        //      cbx_rol.SelectedIndex + 1);
        //    fnt_nuevo();

        //}

        private void txt_identificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_contacto_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        public static bool validarEmail(string pCorreo)
        {
            return pCorreo != null && Regex.IsMatch(pCorreo,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private void txt_correo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fnt_nuevo();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            if (txt_identificacion.Text == "" || txt_Nombre.Text == "" || txt_contacto.Text == "" || txt_correo.Text == "")
            {
                MessageBox.Show("Debe ingresar toda la unformacion requerida");
            }

            if (validarEmail(txt_correo.Text) == false)
            {
                MessageBox.Show("Direccion de correo no valida");
            }
            else
            {
                cls_validar_personal obj_validar = new cls_validar_personal();
                if (obj_validar.fnt_validar_personal(txt_identificacion.Text) == true)
                {
                    MessageBox.Show("Este Clientes ya se encuentra registrado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {

                    {
                        cls_agregar_personal objAgregarPersonal = new cls_agregar_personal(
                          txt_identificacion.Text,
                          txt_Nombre.Text,
                          txt_contacto.Text,
                          txt_correo.Text);


                    }
                }
            }
            {
                cls_agregar_personal2 objAgregarPersonal2 = new cls_agregar_personal2(
                   txt_identificacion.Text,
                   txt_identificacion.Text,
                   txt_identificacion.Text,
                   cbx_estado.SelectedIndex + 1,
                   cbx_rol.SelectedIndex + 1);
                MessageBox.Show(" se ha  Registrado con exito");
                fnt_nuevo();
            }
        }

        private void btn_consultar_Click_1(object sender, EventArgs e)
        {
            cls_validar_personal obj_validar = new cls_validar_personal();
            if (obj_validar.fnt_validar_personal(txt_identificacion.Text) == false)
            {
                MessageBox.Show("Esta persona no se encuentra registrada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fnt_nuevo();
            }

            if (txt_identificacion.Text == "")
            {

                MessageBox.Show("Ingrese el criterio de busqueda");
            }
            else
                fnt_consultar2(txt_identificacion.Text);
            fnt_consultar(txt_identificacion.Text);
        }

        private void btn_actualizar_Click_1(object sender, EventArgs e)
        {
            cls_actualizar_personal objActulizarPersonal = new cls_actualizar_personal(

           txt_identificacion.Text,
          txt_Nombre.Text,
          txt_contacto.Text,
          txt_correo.Text);
            MessageBox.Show("" + objActulizarPersonal.getMsn());





            cls_actualizar_personal2 objActulizarPersonal2 = new cls_actualizar_personal2(

              txt_identificacion.Text,
              cbx_estado.SelectedIndex + 1,
              cbx_rol.SelectedIndex + 1);
            fnt_nuevo();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cerarr_Click(object sender, EventArgs e)
        {
            Visible = false;
            frm_login obj_Login = new frm_login();
            obj_Login.Visible = true;
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
    

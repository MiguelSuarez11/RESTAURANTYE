using Negocio;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frm_platos : Form
    {
        string ruta_directorio_Raiz;
        public frm_platos()
        {
           
            InitializeComponent();
            txt_Codigo.Enabled = true;
            ruta_directorio_Raiz = Path.Combine(Application.StartupPath + "\\imagenes");
            fnt_Nuevo();
            fnt_CargarTipo();
            fnt_CargarEstado();
        }
        private void fnt_CargarEstado()
        {
            cls_estado objDt = new cls_estado();
            objDt.fnt_CargarEstado();
            cbx_estado.ValueMember = "PKCodigo";
            cbx_estado.DisplayMember = "Descripcion";
            cbx_estado.DataSource = objDt.getDt();
        }

        private void fnt_CargarTipo()
        {
            cls_tipo objDt = new cls_tipo();
            objDt.fnt_CargarTipo();
            cbx_Tipo.ValueMember = "PKCodigo";
            cbx_Tipo.DisplayMember = "Nombre";
            cbx_Tipo.DataSource = objDt.getDt();
        }

    
        private void fnt_Nuevo()
        { 
            txt_Codigo.Clear();
            txt_Ingredientes.Clear();
            txt_Nombre.Clear();
            txt_Valor.Clear();
            txt_Codigo.Focus();
            txt_Codigo.Enabled = true;
            ptb_foto.Image = Image.FromFile(ruta_directorio_Raiz + "\\plato.png");
        }
        private void btn_nuevo_Click(object sender, System.EventArgs e)
        {
            fnt_Nuevo();
        }


        private void fnt_consultar(string Codigo)

        {
            cls_validar_platos obj_validar = new cls_validar_platos();
            if (obj_validar.fnt_validar(txt_Codigo.Text) == false)
            {
                MessageBox.Show("Este Plato no se encuentra registrado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              
            }
            else
                txt_Codigo.Enabled = false;
                cls_connsultar_plato obj_Consultar = new cls_connsultar_plato();
                obj_Consultar.fnt_Consultar(Codigo);
                ptb_foto.Image = obj_Consultar.getBmp();
                txt_Nombre.Text = obj_Consultar.getNombre();
                txt_Ingredientes.Text = obj_Consultar.getIngredientes();
                txt_Valor.Text = obj_Consultar.getValor();
                cbx_Tipo.SelectedIndex = obj_Consultar.getTipo() - 1;
                cbx_estado.SelectedIndex = obj_Consultar.getEstado() - 1;
           
            }
        
        private void btn_consultar_Click(object sender, System.EventArgs e)
        {
            if (txt_Codigo.Text == "")
            {
                MessageBox.Show("Ingrese el criterio de busqueda");           
            }else

            fnt_consultar(txt_Codigo.Text);
        }

        private void btn_actualizar_Click(object sender, System.EventArgs e)
        {
            
            cls_Actualizar_plato objActulizarPlato = new cls_Actualizar_plato(
                txt_Codigo.Text,
                txt_Nombre.Text,
                txt_Ingredientes.Text,
                txt_Valor.Text,
                cbx_Tipo.SelectedIndex + 1,
                cbx_estado.SelectedIndex + 1);
            MessageBox.Show("" + objActulizarPlato.getMsn());

          
        }

        private void ptb_foto_Click(object sender, System.EventArgs e)
        {
            try
            {
                ruta_directorio_Raiz = Path.Combine(Application.StartupPath + "\\imagenes");
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "Archivo JPG |*.jpg";

                if (file.ShowDialog() == DialogResult.OK)
                {
                    ptb_foto.Image = Image.FromFile(file.FileName);
                }

            }
            catch { }
        }

        private void txt_Codigo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Ingredientes_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormPrincipal f1 = new FormPrincipal();
            f1.Show();
            this.Hide();
        }

        private void btn_nuevo_Click_1(object sender, EventArgs e)
        {
            fnt_Nuevo();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {

            MemoryStream ms = new MemoryStream();
            if (txt_Codigo.Text == "" || txt_Nombre.Text == "" || txt_Ingredientes.Text == "" || txt_Valor.Text == "")
            {
                MessageBox.Show("Debe ingresar toda la unformacion requerida");
            }

            else

          if (ptb_foto.Image == null)
            {
                MessageBox.Show("Debe agregar una imagen de referencia");
            }
            else
            {
                cls_validar_platos obj_validar = new cls_validar_platos();
                if (obj_validar.fnt_validar(txt_Codigo.Text) == true)
                {
                    MessageBox.Show("Este Plato ya se encuentra Registrado");
                }
                else

                    ptb_foto.Image.Save(ms, ImageFormat.Jpeg);
                byte[] aByte = ms.ToArray();

                cls_agregar_platos objAgregarCandidato = new cls_agregar_platos(
                    txt_Codigo.Text,
                    txt_Nombre.Text,
                    txt_Ingredientes.Text,
                    txt_Valor.Text,
                    cbx_Tipo.SelectedIndex + 1,
                    cbx_estado.SelectedIndex + 1, aByte);
                MessageBox.Show("Este Plato se ha  Registrado con exito");

              
                fnt_Nuevo();
            }
        }

        private void btn_consultar_Click_1(object sender, EventArgs e)
        {

            if (txt_Codigo.Text == "")
            {
                MessageBox.Show("Ingrese el criterio de busqueda");
            }
            else

                fnt_consultar(txt_Codigo.Text);
        }

        private void btn_actualizar_Click_1(object sender, EventArgs e)
        {

            cls_Actualizar_plato objActulizarPlato = new cls_Actualizar_plato(
                txt_Codigo.Text,
                txt_Nombre.Text,
                txt_Ingredientes.Text,
                txt_Valor.Text,
                cbx_Tipo.SelectedIndex + 1,
                cbx_estado.SelectedIndex + 1);
            MessageBox.Show("" + objActulizarPlato.getMsn());

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FormPrincipal f1 = new FormPrincipal();
            f1.Show();
            this.Hide();
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

using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }


        private void fnt_login(string user, string password)
        {
          
            
                cls_login obj_login = new cls_login(user, password);
                if (obj_login.getRol() == "Administrador")
                {
                    FormPrincipal obj_admin = new FormPrincipal();
                    this.Hide();
                    obj_admin.Visible = true;
                    obj_login.getNombre();
                    obj_admin.lbl_encargado.Text = obj_login.getNombre();
                    obj_admin.lbl_estado.Text = obj_login.getEstado();
                    obj_admin.lbl_rol.Text = obj_login.getRol();
                    Visible = false;
                }
            if (obj_login.getRol() == "Cajero")
            {
                frm_cajero obj_ventas = new frm_cajero();
                obj_ventas.Visible = true;
                obj_ventas.lbl_encargado.Text = obj_login.getNombre();
                obj_ventas.lbl_estado.Text = obj_login.getEstado();
                obj_ventas.lbl_rol.Text = obj_login.getRol();
                Visible = false;
            }
            //if (obj_login.getRol() == "Inventario")
            {
                //frm_Inventario obj_inventario = new frm_Inventario();
                //obj_inventario.Visible = true;
                //obj_inventario.lbl_Encargado.Text = obj_Login.getNombre();
                //obj_inventario.lbl_Estado.Text = obj_Login.getEstado();
              //  obj_inventario.lbl_Rol.Text = obj_Login.getRol();
                Visible = false;
            }
            //lbl_Mensaje.ForeColor = Color.Red;
            //lbl_Mensaje.Text = obj_Login.getMsn();
            //lbl_Mensaje.Visible = true;
            lbl_mensaje.Text = obj_login.getMsn();
            

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
              fnt_login(txt_usuario.Text, txt_contraseña.Text);

            }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
    }

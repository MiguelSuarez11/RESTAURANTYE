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
                    obj_admin.lbl_usuario.Text = txt_usuario.Text;
                    obj_admin.lbl__contraseña.Text = txt_contraseña.Text;
                this.Hide();
                Visible = false;
                }
            if (obj_login.getRol() == "Cajero")
            {
                frm_cajero obj_ventas = new frm_cajero();
                
                obj_ventas.Visible = true;
                obj_ventas.lbl_encargado.Text = obj_login.getNombre();
                obj_ventas.lbl_estado.Text = obj_login.getEstado();
                obj_ventas.lbl_rol.Text = obj_login.getRol();
                obj_ventas.lbl_usuario.Text= txt_usuario.Text;
                obj_ventas.lbl__contraseña.Text = txt_contraseña.Text;
                Visible = false;
            }
            if (obj_login.getRol() == "Domiciliario")
            {
                reporte obj_inventario = new reporte();
                obj_inventario.Visible = true;
                obj_inventario.lbl_encargado.Text = obj_login.getNombre();
                obj_inventario.lbl_estado.Text = obj_login.getEstado();
                obj_inventario.lbl_rol.Text = obj_login.getRol();
                Visible = false;
            }
           
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

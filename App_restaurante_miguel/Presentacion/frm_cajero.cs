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
    public partial class frm_cajero : Form
    {
        public frm_cajero()
        {
            InitializeComponent();
        }






        private void fnt_login(string user, string password)
        {


            cls_login obj_login = new cls_login(user, password);
            if (obj_login.getRol() == "Cajero")
            {
                frm_pedidos obj_admin = new frm_pedidos();
                this.Hide();
                obj_admin.Visible = true;
                obj_login.getNombre();
                obj_admin.lbl_encargado.Text = obj_login.getNombre();
                obj_admin.lbl_estado.Text = obj_login.getEstado();
                obj_admin.lbl_rol.Text = obj_login.getRol();
                obj_admin.lbl_usuario.Text = lbl_usuario.Text;
                obj_admin.lbl__contraseña.Text = lbl__contraseña.Text;
                this.Hide();
                Visible = false;
            }


        }




        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            fnt_login(lbl_usuario.Text, lbl__contraseña.Text);
            this.Hide();

        }


        private void fnt_pasar(string user, string password)
        {


            cls_login obj_login = new cls_login(user, password);
            if (obj_login.getRol() == "Cajero")
            {
                frm_clientes obj_admin = new frm_clientes();
                this.Hide();
                obj_admin.Visible = true;
                obj_login.getNombre();
                obj_admin.lbl_encargado.Text = obj_login.getNombre();
                obj_admin.lbl_estado.Text = obj_login.getEstado();
                obj_admin.lbl_rol.Text = obj_login.getRol();
                obj_admin.lbl_usuario.Text = lbl_usuario.Text;
                obj_admin.lbl__contraseña.Text = lbl__contraseña.Text;
                this.Hide();
                Visible = false;
            }


        }


        private void btn_clientes_Click(object sender, EventArgs e)
        {
            fnt_pasar(lbl_usuario.Text, lbl__contraseña.Text);
            this.Hide();
        }

        private void btn_Cerarr_Click(object sender, EventArgs e)
        {
            Visible = false;
            frm_login obj_Login = new frm_login();
            obj_Login.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Visible = false;
            frm_login obj_Login = new frm_login();
            obj_Login.Visible = true;
            this.Hide();
        }
    }
}

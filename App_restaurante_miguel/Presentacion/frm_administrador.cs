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
    public partial class frm_administrador : Form
    {
        public frm_administrador()
        {
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            frm_clientes f1 = new frm_clientes();
            f1.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
            frm_platos f1 = new frm_platos();
            f1.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frm_personal f1 = new frm_personal();
            f1.Show();
            this.Hide();
        }

        private void btn_Cerarr_Click(object sender, EventArgs e)
        {
            Visible = false;
            frm_login obj_Login = new frm_login();
            obj_Login.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frm_pedidos f1 = new frm_pedidos();
            f1.Show();
            this.Hide();
        }
    }
}

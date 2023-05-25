namespace Presentacion
{
    partial class frm_factura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_factura));
            this.txt_identificacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.PictureBox();
            this.lbl_mensaje = new System.Windows.Forms.Label();
            this.txt_N_pedido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_tipopago = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Guardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_identificacion
            // 
            this.txt_identificacion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_identificacion.Location = new System.Drawing.Point(212, 64);
            this.txt_identificacion.MaxLength = 10;
            this.txt_identificacion.Name = "txt_identificacion";
            this.txt_identificacion.Size = new System.Drawing.Size(174, 29);
            this.txt_identificacion.TabIndex = 40;
            this.txt_identificacion.Visible = false;
            this.txt_identificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_identificacion_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 39;
            this.label1.Text = "Identificacion:";
            this.label1.Visible = false;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.Image")));
            this.btn_Guardar.Location = new System.Drawing.Point(198, 214);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(58, 60);
            this.btn_Guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Guardar.TabIndex = 51;
            this.btn_Guardar.TabStop = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // lbl_mensaje
            // 
            this.lbl_mensaje.AutoSize = true;
            this.lbl_mensaje.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_mensaje.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mensaje.Location = new System.Drawing.Point(82, 214);
            this.lbl_mensaje.Name = "lbl_mensaje";
            this.lbl_mensaje.Size = new System.Drawing.Size(74, 21);
            this.lbl_mensaje.TabIndex = 74;
            this.lbl_mensaje.Text = "Mensaje";
            // 
            // txt_N_pedido
            // 
            this.txt_N_pedido.Enabled = false;
            this.txt_N_pedido.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_N_pedido.Location = new System.Drawing.Point(212, 109);
            this.txt_N_pedido.MaxLength = 10;
            this.txt_N_pedido.Name = "txt_N_pedido";
            this.txt_N_pedido.Size = new System.Drawing.Size(174, 29);
            this.txt_N_pedido.TabIndex = 76;
            this.txt_N_pedido.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 75;
            this.label2.Text = "N pedido:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 77;
            this.label3.Text = "Tipo Pago:";
            // 
            // cbx_tipopago
            // 
            this.cbx_tipopago.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_tipopago.FormattingEnabled = true;
            this.cbx_tipopago.Location = new System.Drawing.Point(212, 157);
            this.cbx_tipopago.Name = "cbx_tipopago";
            this.cbx_tipopago.Size = new System.Drawing.Size(174, 29);
            this.cbx_tipopago.TabIndex = 78;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(625, 454);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // frm_factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 278);
            this.Controls.Add(this.cbx_tipopago);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_N_pedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_mensaje);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.txt_identificacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_factura";
            this.Text = "frm_factura";
            ((System.ComponentModel.ISupportInitialize)(this.btn_Guardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_identificacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_Guardar;
        private System.Windows.Forms.Label lbl_mensaje;
        private System.Windows.Forms.TextBox txt_N_pedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_tipopago;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
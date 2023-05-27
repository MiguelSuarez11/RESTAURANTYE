namespace Presentacion
{
    partial class reporte
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
            this.label9 = new System.Windows.Forms.Label();
            this.txt_identificacion = new System.Windows.Forms.TextBox();
            this.lbl_identificacion = new System.Windows.Forms.Label();
            this.cbx_asignados = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(268, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 14);
            this.label9.TabIndex = 96;
            this.label9.Text = "<Enter>";
            // 
            // txt_identificacion
            // 
            this.txt_identificacion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_identificacion.Location = new System.Drawing.Point(149, 50);
            this.txt_identificacion.MaxLength = 10;
            this.txt_identificacion.Name = "txt_identificacion";
            this.txt_identificacion.Size = new System.Drawing.Size(174, 29);
            this.txt_identificacion.TabIndex = 95;
            this.txt_identificacion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_identificacion_KeyUp);
            // 
            // lbl_identificacion
            // 
            this.lbl_identificacion.AutoSize = true;
            this.lbl_identificacion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_identificacion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_identificacion.Location = new System.Drawing.Point(33, 53);
            this.lbl_identificacion.Name = "lbl_identificacion";
            this.lbl_identificacion.Size = new System.Drawing.Size(115, 21);
            this.lbl_identificacion.TabIndex = 94;
            this.lbl_identificacion.Text = "Identificacion:";
            // 
            // cbx_asignados
            // 
            this.cbx_asignados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_asignados.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_asignados.FormattingEnabled = true;
            this.cbx_asignados.Location = new System.Drawing.Point(149, 104);
            this.cbx_asignados.Name = "cbx_asignados";
            this.cbx_asignados.Size = new System.Drawing.Size(174, 29);
            this.cbx_asignados.TabIndex = 110;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(26, 107);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(122, 21);
            this.label17.TabIndex = 109;
            this.label17.Text = "No.Domicilios:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_seleccionar);
            this.panel1.Controls.Add(this.txt_identificacion);
            this.panel1.Controls.Add(this.lbl_identificacion);
            this.panel1.Controls.Add(this.cbx_asignados);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Location = new System.Drawing.Point(88, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 401);
            this.panel1.TabIndex = 112;
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Location = new System.Drawing.Point(181, 211);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(75, 23);
            this.btn_seleccionar.TabIndex = 111;
            this.btn_seleccionar.Text = "seleccionar";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 444);
            this.Controls.Add(this.panel1);
            this.Name = "reporte";
            this.Text = "reporte";
            this.Load += new System.EventHandler(this.reporte_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_identificacion;
        private System.Windows.Forms.Label lbl_identificacion;
        private System.Windows.Forms.ComboBox cbx_asignados;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_seleccionar;
    }
}
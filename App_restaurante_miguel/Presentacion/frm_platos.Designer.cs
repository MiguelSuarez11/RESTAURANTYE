namespace Presentacion
{
    partial class frm_platos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_platos));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Ingredientes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_Tipo = new System.Windows.Forms.ComboBox();
            this.cbx_estado = new System.Windows.Forms.ComboBox();
            this.ptb_foto = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Cerarr = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_foto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btn_Cerarr);
            this.panelMenu.Controls.Add(this.btn_nuevo);
            this.panelMenu.Controls.Add(this.btn_registrar);
            this.panelMenu.Controls.Add(this.btn_actualizar);
            this.panelMenu.Controls.Add(this.btn_consultar);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 32);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(188, 546);
            this.panelMenu.TabIndex = 61;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btn_nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_nuevo.Image = global::Presentacion.Properties.Resources.feijoada__1_;
            this.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevo.Location = new System.Drawing.Point(0, 99);
            this.btn_nuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(188, 40);
            this.btn_nuevo.TabIndex = 0;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click_1);
            // 
            // btn_registrar
            // 
            this.btn_registrar.FlatAppearance.BorderSize = 0;
            this.btn_registrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btn_registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_registrar.Image = global::Presentacion.Properties.Resources.cliente;
            this.btn_registrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_registrar.Location = new System.Drawing.Point(2, 143);
            this.btn_registrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(188, 40);
            this.btn_registrar.TabIndex = 1;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.FlatAppearance.BorderSize = 0;
            this.btn_actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btn_actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_actualizar.Image = global::Presentacion.Properties.Resources.facturas_de_dinero;
            this.btn_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_actualizar.Location = new System.Drawing.Point(2, 231);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(188, 40);
            this.btn_actualizar.TabIndex = 3;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click_1);
            // 
            // btn_consultar
            // 
            this.btn_consultar.FlatAppearance.BorderSize = 0;
            this.btn_consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btn_consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_consultar.Image = global::Presentacion.Properties.Resources.hacer_un_pedido;
            this.btn_consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_consultar.Location = new System.Drawing.Point(2, 187);
            this.btn_consultar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(188, 40);
            this.btn_consultar.TabIndex = 2;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click_1);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.panelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.panelBarraTitulo.Controls.Add(this.btnMaximizar);
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Controls.Add(this.btnRestaurar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(900, 32);
            this.panelBarraTitulo.TabIndex = 60;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(846, 9);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(12, 13);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(862, 9);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(12, 13);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(878, 9);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(12, 13);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(862, 9);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(12, 13);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(159, 106);
            this.txt_Nombre.MaxLength = 40;
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(296, 29);
            this.txt_Nombre.TabIndex = 18;
            this.txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Codigo:";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Codigo.Location = new System.Drawing.Point(159, 71);
            this.txt_Codigo.MaxLength = 15;
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(296, 29);
            this.txt_Codigo.TabIndex = 16;
            this.txt_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Codigo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ingredientes:";
            // 
            // txt_Ingredientes
            // 
            this.txt_Ingredientes.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ingredientes.Location = new System.Drawing.Point(159, 144);
            this.txt_Ingredientes.MaxLength = 5000;
            this.txt_Ingredientes.Multiline = true;
            this.txt_Ingredientes.Name = "txt_Ingredientes";
            this.txt_Ingredientes.Size = new System.Drawing.Size(296, 95);
            this.txt_Ingredientes.TabIndex = 20;
            this.txt_Ingredientes.TextChanged += new System.EventHandler(this.txt_Ingredientes_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Valor:";
            // 
            // txt_Valor
            // 
            this.txt_Valor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Valor.Location = new System.Drawing.Point(159, 245);
            this.txt_Valor.MaxLength = 12;
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(296, 29);
            this.txt_Valor.TabIndex = 22;
            this.txt_Valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Valor_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(104, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tipo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "Estado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(160, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 38);
            this.label7.TabIndex = 0;
            this.label7.Text = "Menu de platos";
            // 
            // cbx_Tipo
            // 
            this.cbx_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Tipo.FormattingEnabled = true;
            this.cbx_Tipo.Location = new System.Drawing.Point(159, 279);
            this.cbx_Tipo.Name = "cbx_Tipo";
            this.cbx_Tipo.Size = new System.Drawing.Size(296, 32);
            this.cbx_Tipo.TabIndex = 28;
            // 
            // cbx_estado
            // 
            this.cbx_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_estado.FormattingEnabled = true;
            this.cbx_estado.Location = new System.Drawing.Point(159, 318);
            this.cbx_estado.Name = "cbx_estado";
            this.cbx_estado.Size = new System.Drawing.Size(296, 32);
            this.cbx_estado.TabIndex = 32;
            // 
            // ptb_foto
            // 
            this.ptb_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb_foto.Location = new System.Drawing.Point(489, 71);
            this.ptb_foto.Name = "ptb_foto";
            this.ptb_foto.Size = new System.Drawing.Size(123, 144);
            this.ptb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptb_foto.TabIndex = 37;
            this.ptb_foto.TabStop = false;
            this.ptb_foto.Click += new System.EventHandler(this.ptb_foto_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.ptb_foto);
            this.panel1.Controls.Add(this.cbx_estado);
            this.panel1.Controls.Add(this.cbx_Tipo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_Valor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_Ingredientes);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Codigo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_Nombre);
            this.panel1.Location = new System.Drawing.Point(195, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 491);
            this.panel1.TabIndex = 0;
            // 
            // btn_Cerarr
            // 
            this.btn_Cerarr.BackColor = System.Drawing.Color.Red;
            this.btn_Cerarr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cerarr.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Cerarr.Location = new System.Drawing.Point(3, 515);
            this.btn_Cerarr.Name = "btn_Cerarr";
            this.btn_Cerarr.Size = new System.Drawing.Size(105, 28);
            this.btn_Cerarr.TabIndex = 71;
            this.btn_Cerarr.Text = "Cerrar sesión";
            this.btn_Cerarr.UseVisualStyleBackColor = false;
            this.btn_Cerarr.Click += new System.EventHandler(this.btn_Cerarr_Click);
            // 
            // frm_platos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 578);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_platos";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_foto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Ingredientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_Tipo;
        private System.Windows.Forms.ComboBox cbx_estado;
        private System.Windows.Forms.PictureBox ptb_foto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Cerarr;
    }
}


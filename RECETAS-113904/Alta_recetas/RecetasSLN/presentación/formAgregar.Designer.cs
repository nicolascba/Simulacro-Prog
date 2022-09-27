namespace RecetasSLN.presentación
{
    partial class formAgregar
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCheff = new System.Windows.Forms.TextBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.cboIngredientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReceta = new System.Windows.Forms.DataGridView();
            this.IDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIngrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNro = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIngre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(96, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(402, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtCheff
            // 
            this.txtCheff.Location = new System.Drawing.Point(96, 86);
            this.txtCheff.Name = "txtCheff";
            this.txtCheff.Size = new System.Drawing.Size(402, 20);
            this.txtCheff.TabIndex = 1;
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(96, 124);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(121, 21);
            this.cboTipo.TabIndex = 2;
            // 
            // cboIngredientes
            // 
            this.cboIngredientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIngredientes.FormattingEnabled = true;
            this.cboIngredientes.Location = new System.Drawing.Point(32, 185);
            this.cboIngredientes.Name = "cboIngredientes";
            this.cboIngredientes.Size = new System.Drawing.Size(276, 21);
            this.cboIngredientes.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // dgvReceta
            // 
            this.dgvReceta.AllowUserToAddRows = false;
            this.dgvReceta.AllowUserToDeleteRows = false;
            this.dgvReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCol,
            this.colIngrediente,
            this.colCantidad,
            this.Accion});
            this.dgvReceta.Location = new System.Drawing.Point(32, 227);
            this.dgvReceta.Name = "dgvReceta";
            this.dgvReceta.ReadOnly = true;
            this.dgvReceta.Size = new System.Drawing.Size(518, 150);
            this.dgvReceta.TabIndex = 5;
            this.dgvReceta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceta_CellContentClick);
            // 
            // IDCol
            // 
            this.IDCol.HeaderText = "ID";
            this.IDCol.Name = "IDCol";
            this.IDCol.ReadOnly = true;
            this.IDCol.Visible = false;
            // 
            // colIngrediente
            // 
            this.colIngrediente.HeaderText = "Ingrediente";
            this.colIngrediente.Name = "colIngrediente";
            this.colIngrediente.ReadOnly = true;
            this.colIngrediente.Width = 275;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            // 
            // Accion
            // 
            this.Accion.HeaderText = "Acciones";
            this.Accion.Name = "Accion";
            this.Accion.ReadOnly = true;
            this.Accion.Text = "Quitar";
            this.Accion.UseColumnTextForButtonValue = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(466, 183);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cheff";
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNro.Location = new System.Drawing.Point(28, 9);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(0, 20);
            this.lblNro.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo de Receta";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(329, 185);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(103, 20);
            this.txtCantidad.TabIndex = 10;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(194, 406);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(294, 406);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total de Ingredientes: ";
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(329, 146);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(103, 20);
            this.txtUnidad.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Unidad de medida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cantidad";
            // 
            // txtIngre
            // 
            this.txtIngre.Enabled = false;
            this.txtIngre.Location = new System.Drawing.Point(504, 387);
            this.txtIngre.Name = "txtIngre";
            this.txtIngre.Size = new System.Drawing.Size(37, 20);
            this.txtIngre.TabIndex = 17;
            // 
            // formAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 432);
            this.Controls.Add(this.txtIngre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUnidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvReceta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboIngredientes);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.txtCheff);
            this.Controls.Add(this.txtNombre);
            this.Name = "formAgregar";
            this.Text = "formAgregar";
            this.Load += new System.EventHandler(this.formAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCheff;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.ComboBox cboIngredientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReceta;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIngrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewButtonColumn Accion;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIngre;
    }
}
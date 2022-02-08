﻿namespace Alumvix.View
{
    partial class ClienteView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteView));
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.btnDetalleCliente = new System.Windows.Forms.Button();
            this.txtFiltrarCliente = new System.Windows.Forms.TextBox();
            this.btnActualizarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnGastosInternos = new System.Windows.Forms.Button();
            this.lblTituloClientes = new System.Windows.Forms.Label();
            this.btnIngresarCliente = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Location = new System.Drawing.Point(11, 123);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClientes.Size = new System.Drawing.Size(1008, 249);
            this.dataGridClientes.TabIndex = 0;
            // 
            // btnDetalleCliente
            // 
            this.btnDetalleCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalleCliente.Location = new System.Drawing.Point(778, 75);
            this.btnDetalleCliente.Name = "btnDetalleCliente";
            this.btnDetalleCliente.Size = new System.Drawing.Size(88, 35);
            this.btnDetalleCliente.TabIndex = 2;
            this.btnDetalleCliente.Text = "Detalle";
            this.btnDetalleCliente.UseVisualStyleBackColor = true;
            // 
            // txtFiltrarCliente
            // 
            this.txtFiltrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarCliente.Location = new System.Drawing.Point(12, 83);
            this.txtFiltrarCliente.Multiline = true;
            this.txtFiltrarCliente.Name = "txtFiltrarCliente";
            this.txtFiltrarCliente.Size = new System.Drawing.Size(247, 29);
            this.txtFiltrarCliente.TabIndex = 3;
            // 
            // btnActualizarCliente
            // 
            this.btnActualizarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizarCliente.FlatAppearance.BorderSize = 0;
            this.btnActualizarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarCliente.Image")));
            this.btnActualizarCliente.Location = new System.Drawing.Point(880, 75);
            this.btnActualizarCliente.Name = "btnActualizarCliente";
            this.btnActualizarCliente.Size = new System.Drawing.Size(30, 35);
            this.btnActualizarCliente.TabIndex = 35;
            this.btnActualizarCliente.UseVisualStyleBackColor = false;
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarCliente.FlatAppearance.BorderSize = 0;
            this.btnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarCliente.Image")));
            this.btnEliminarCliente.Location = new System.Drawing.Point(925, 74);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(30, 35);
            this.btnEliminarCliente.TabIndex = 36;
            this.btnEliminarCliente.UseVisualStyleBackColor = false;
            // 
            // btnReporte
            // 
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Location = new System.Drawing.Point(20, 394);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(102, 34);
            this.btnReporte.TabIndex = 37;
            this.btnReporte.Text = "Reportes";
            this.btnReporte.UseVisualStyleBackColor = true;
            // 
            // btnGastosInternos
            // 
            this.btnGastosInternos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGastosInternos.Location = new System.Drawing.Point(149, 394);
            this.btnGastosInternos.Name = "btnGastosInternos";
            this.btnGastosInternos.Size = new System.Drawing.Size(176, 34);
            this.btnGastosInternos.TabIndex = 38;
            this.btnGastosInternos.Text = "Gastos Internos";
            this.btnGastosInternos.UseVisualStyleBackColor = true;
            // 
            // lblTituloClientes
            // 
            this.lblTituloClientes.AutoSize = true;
            this.lblTituloClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloClientes.Location = new System.Drawing.Point(431, 19);
            this.lblTituloClientes.Name = "lblTituloClientes";
            this.lblTituloClientes.Size = new System.Drawing.Size(156, 31);
            this.lblTituloClientes.TabIndex = 39;
            this.lblTituloClientes.Text = "CLIENTES";
            // 
            // btnIngresarCliente
            // 
            this.btnIngresarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresarCliente.FlatAppearance.BorderSize = 0;
            this.btnIngresarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresarCliente.Image")));
            this.btnIngresarCliente.Location = new System.Drawing.Point(964, 72);
            this.btnIngresarCliente.Name = "btnIngresarCliente";
            this.btnIngresarCliente.Size = new System.Drawing.Size(46, 40);
            this.btnIngresarCliente.TabIndex = 41;
            this.btnIngresarCliente.UseVisualStyleBackColor = false;
            // 
            // btnProveedores
            // 
            this.btnProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.Location = new System.Drawing.Point(352, 394);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(142, 34);
            this.btnProveedores.TabIndex = 42;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            // 
            // ClienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 450);
            this.Controls.Add(this.btnProveedores);
            this.Controls.Add(this.btnIngresarCliente);
            this.Controls.Add(this.lblTituloClientes);
            this.Controls.Add(this.btnGastosInternos);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnActualizarCliente);
            this.Controls.Add(this.txtFiltrarCliente);
            this.Controls.Add(this.btnDetalleCliente);
            this.Controls.Add(this.dataGridClientes);
            this.Name = "ClienteView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridClientes;
        public System.Windows.Forms.Button btnDetalleCliente;
        public System.Windows.Forms.TextBox txtFiltrarCliente;
        public System.Windows.Forms.Button btnActualizarCliente;
        public System.Windows.Forms.Button btnEliminarCliente;
        public System.Windows.Forms.Button btnReporte;
        public System.Windows.Forms.Button btnGastosInternos;
        private System.Windows.Forms.Label lblTituloClientes;
        public System.Windows.Forms.Button btnIngresarCliente;
        public System.Windows.Forms.Button btnProveedores;
    }
}
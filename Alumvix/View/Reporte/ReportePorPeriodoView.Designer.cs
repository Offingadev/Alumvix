﻿namespace Alumvix.View.Reporte
{
    partial class ReportePorPeriodoView
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
            this.lblFechaFinalReporte = new System.Windows.Forms.Label();
            this.lblFechaInicioReporte = new System.Windows.Forms.Label();
            this.dtpFechaInicioReporte = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinalReporte = new System.Windows.Forms.DateTimePicker();
            this.lblTituloReportePorPeriodo = new System.Windows.Forms.Label();
            this.lstvCuentasPorPeriodo = new System.Windows.Forms.ListView();
            this.columnaTotalVentas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaTotalGastos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaUtilidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnConsultarReportePorPeriodo = new System.Windows.Forms.Button();
            this.lstvGastosTotalesPorPeriodo = new System.Windows.Forms.ListView();
            this.columnaTipoGastoPeriodo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaTotalGasto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDetalleGastosPorPeriodo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFechaFinalReporte
            // 
            this.lblFechaFinalReporte.AutoSize = true;
            this.lblFechaFinalReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinalReporte.Location = new System.Drawing.Point(522, 83);
            this.lblFechaFinalReporte.Name = "lblFechaFinalReporte";
            this.lblFechaFinalReporte.Size = new System.Drawing.Size(127, 24);
            this.lblFechaFinalReporte.TabIndex = 53;
            this.lblFechaFinalReporte.Text = "Fecha Final:";
            // 
            // lblFechaInicioReporte
            // 
            this.lblFechaInicioReporte.AutoSize = true;
            this.lblFechaInicioReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicioReporte.Location = new System.Drawing.Point(245, 83);
            this.lblFechaInicioReporte.Name = "lblFechaInicioReporte";
            this.lblFechaInicioReporte.Size = new System.Drawing.Size(135, 24);
            this.lblFechaInicioReporte.TabIndex = 52;
            this.lblFechaInicioReporte.Text = "Fecha Inicial:";
            // 
            // dtpFechaInicioReporte
            // 
            this.dtpFechaInicioReporte.CustomFormat = "yyyy/MM/dd";
            this.dtpFechaInicioReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicioReporte.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicioReporte.Location = new System.Drawing.Point(386, 81);
            this.dtpFechaInicioReporte.Name = "dtpFechaInicioReporte";
            this.dtpFechaInicioReporte.Size = new System.Drawing.Size(120, 26);
            this.dtpFechaInicioReporte.TabIndex = 51;
            // 
            // dtpFechaFinalReporte
            // 
            this.dtpFechaFinalReporte.CustomFormat = "yyyy/MM/dd";
            this.dtpFechaFinalReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFinalReporte.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFinalReporte.Location = new System.Drawing.Point(655, 83);
            this.dtpFechaFinalReporte.Name = "dtpFechaFinalReporte";
            this.dtpFechaFinalReporte.Size = new System.Drawing.Size(120, 26);
            this.dtpFechaFinalReporte.TabIndex = 50;
            // 
            // lblTituloReportePorPeriodo
            // 
            this.lblTituloReportePorPeriodo.AutoSize = true;
            this.lblTituloReportePorPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloReportePorPeriodo.Location = new System.Drawing.Point(314, 19);
            this.lblTituloReportePorPeriodo.Name = "lblTituloReportePorPeriodo";
            this.lblTituloReportePorPeriodo.Size = new System.Drawing.Size(364, 31);
            this.lblTituloReportePorPeriodo.TabIndex = 54;
            this.lblTituloReportePorPeriodo.Text = "REPORTE POR PERIODO";
            // 
            // lstvCuentasPorPeriodo
            // 
            this.lstvCuentasPorPeriodo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaTotalVentas,
            this.columnaTotalGastos,
            this.columnaUtilidad});
            this.lstvCuentasPorPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvCuentasPorPeriodo.FullRowSelect = true;
            this.lstvCuentasPorPeriodo.HideSelection = false;
            this.lstvCuentasPorPeriodo.Location = new System.Drawing.Point(12, 187);
            this.lstvCuentasPorPeriodo.MultiSelect = false;
            this.lstvCuentasPorPeriodo.Name = "lstvCuentasPorPeriodo";
            this.lstvCuentasPorPeriodo.Size = new System.Drawing.Size(556, 381);
            this.lstvCuentasPorPeriodo.TabIndex = 55;
            this.lstvCuentasPorPeriodo.UseCompatibleStateImageBehavior = false;
            this.lstvCuentasPorPeriodo.View = System.Windows.Forms.View.Details;
            // 
            // columnaTotalVentas
            // 
            this.columnaTotalVentas.Text = "Ventas";
            this.columnaTotalVentas.Width = 189;
            // 
            // columnaTotalGastos
            // 
            this.columnaTotalGastos.Text = "Gastos";
            this.columnaTotalGastos.Width = 172;
            // 
            // columnaUtilidad
            // 
            this.columnaUtilidad.Text = "Utilidad";
            this.columnaUtilidad.Width = 189;
            // 
            // btnConsultarReportePorPeriodo
            // 
            this.btnConsultarReportePorPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarReportePorPeriodo.Location = new System.Drawing.Point(235, 132);
            this.btnConsultarReportePorPeriodo.Name = "btnConsultarReportePorPeriodo";
            this.btnConsultarReportePorPeriodo.Size = new System.Drawing.Size(101, 38);
            this.btnConsultarReportePorPeriodo.TabIndex = 56;
            this.btnConsultarReportePorPeriodo.Text = "Consultar";
            this.btnConsultarReportePorPeriodo.UseVisualStyleBackColor = true;
            // 
            // lstvGastosTotalesPorPeriodo
            // 
            this.lstvGastosTotalesPorPeriodo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaTipoGastoPeriodo,
            this.columnaTotalGasto});
            this.lstvGastosTotalesPorPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvGastosTotalesPorPeriodo.FullRowSelect = true;
            this.lstvGastosTotalesPorPeriodo.HideSelection = false;
            this.lstvGastosTotalesPorPeriodo.Location = new System.Drawing.Point(583, 187);
            this.lstvGastosTotalesPorPeriodo.MultiSelect = false;
            this.lstvGastosTotalesPorPeriodo.Name = "lstvGastosTotalesPorPeriodo";
            this.lstvGastosTotalesPorPeriodo.Size = new System.Drawing.Size(376, 381);
            this.lstvGastosTotalesPorPeriodo.TabIndex = 58;
            this.lstvGastosTotalesPorPeriodo.UseCompatibleStateImageBehavior = false;
            this.lstvGastosTotalesPorPeriodo.View = System.Windows.Forms.View.Details;
            // 
            // columnaTipoGastoPeriodo
            // 
            this.columnaTipoGastoPeriodo.Text = "Tipo de gasto";
            this.columnaTipoGastoPeriodo.Width = 223;
            // 
            // columnaTotalGasto
            // 
            this.columnaTotalGasto.Text = "Total";
            this.columnaTotalGasto.Width = 141;
            // 
            // btnDetalleGastosPorPeriodo
            // 
            this.btnDetalleGastosPorPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalleGastosPorPeriodo.Location = new System.Drawing.Point(684, 132);
            this.btnDetalleGastosPorPeriodo.Name = "btnDetalleGastosPorPeriodo";
            this.btnDetalleGastosPorPeriodo.Size = new System.Drawing.Size(174, 38);
            this.btnDetalleGastosPorPeriodo.TabIndex = 57;
            this.btnDetalleGastosPorPeriodo.Text = "Detalle de Gastos";
            this.btnDetalleGastosPorPeriodo.UseVisualStyleBackColor = true;
            // 
            // ReportePorPeriodoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 580);
            this.Controls.Add(this.lstvGastosTotalesPorPeriodo);
            this.Controls.Add(this.btnDetalleGastosPorPeriodo);
            this.Controls.Add(this.btnConsultarReportePorPeriodo);
            this.Controls.Add(this.lstvCuentasPorPeriodo);
            this.Controls.Add(this.lblTituloReportePorPeriodo);
            this.Controls.Add(this.lblFechaFinalReporte);
            this.Controls.Add(this.lblFechaInicioReporte);
            this.Controls.Add(this.dtpFechaInicioReporte);
            this.Controls.Add(this.dtpFechaFinalReporte);
            this.Name = "ReportePorPeriodoView";
            this.Text = "ReportePorPeriodoView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechaFinalReporte;
        private System.Windows.Forms.Label lblFechaInicioReporte;
        public System.Windows.Forms.DateTimePicker dtpFechaInicioReporte;
        public System.Windows.Forms.DateTimePicker dtpFechaFinalReporte;
        private System.Windows.Forms.Label lblTituloReportePorPeriodo;
        public System.Windows.Forms.ListView lstvCuentasPorPeriodo;
        private System.Windows.Forms.ColumnHeader columnaTotalVentas;
        private System.Windows.Forms.ColumnHeader columnaTotalGastos;
        private System.Windows.Forms.ColumnHeader columnaUtilidad;
        public System.Windows.Forms.Button btnConsultarReportePorPeriodo;
        public System.Windows.Forms.ListView lstvGastosTotalesPorPeriodo;
        private System.Windows.Forms.ColumnHeader columnaTipoGastoPeriodo;
        private System.Windows.Forms.ColumnHeader columnaTotalGasto;
        public System.Windows.Forms.Button btnDetalleGastosPorPeriodo;
    }
}
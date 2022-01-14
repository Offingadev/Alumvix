﻿using Alumvix.Model.Dao;
using Alumvix.Model.Negocio.Util;
using Alumvix.View.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.Controller.Contrato
{
    internal class IngresoContratoController
    {
        IngresoContratoView ingresoContratoView;
        public IngresoContratoController(IngresoContratoView ingresoContratoVista)
        {
            ingresoContratoView = ingresoContratoVista;
            ingresoContratoView.Load += new EventHandler(CargarTiposFactura);
            ingresoContratoView.btnGuardarNuevoContrato.Click += new EventHandler(GuardarContrato);
        }

        private void GuardarContrato(object sender, EventArgs e)
        {
            if (ValidacionesDeControles.ValidarBotonIngresoContrato(ingresoContratoView.txtIngresarValorContrato.Text, ingresoContratoView.cbIngresarTipoFactura.SelectedIndex) == false)
            {
                MessageBox.Show("Debe diligenciar todos los campos");
            }
            else
            {
                ContratoDao contratoDao = new ContratoDao();
                bool respuestaIngresoContrato = contratoDao.GuardarContrato(Convert.ToInt32(ingresoContratoView.txtIngresarValorContrato.Text), ingresoContratoView.dtpFechaInicioContrato.Text, ingresoContratoView.dtpFechaTerminacionContrato.Text, 1, 1, ingresoContratoView.cbIngresarTipoFactura.SelectedIndex, ClienteController.ObtenerIdCliente());
                if (respuestaIngresoContrato)
                {
                    ingresoContratoView.txtIngresarValorContrato.Clear();
                    ingresoContratoView.cbIngresarTipoFactura.SelectedIndex = 0;
                    ingresoContratoView.Close();
                    MessageBox.Show("El contrato ha sido guardado con exito");
                }else MessageBox.Show("Error al guardar el contrato");

            }
            
        }

        private void CargarTiposFactura(object sender, EventArgs e)
        {
            ingresoContratoView.txtIngresarValorContrato.Clear();
            ContratoDao contratoDao = new ContratoDao();
            ingresoContratoView.cbIngresarTipoFactura.DataSource = contratoDao.ObtenerTiposFactura();
        }

        
    }
}

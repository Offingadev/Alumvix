﻿using Alumvix.Model.Dao;
using Alumvix.Model.Negocio.Util;
using Alumvix.View.Proveedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.Controller.Proveedor
{
    internal class IngresoProveedorController
    {
        IngresoProveedorView ingresoProveedorView;

        public IngresoProveedorController(IngresoProveedorView ingresoProveedorVista)
        {
            ingresoProveedorView = ingresoProveedorVista;
            ingresoProveedorView.btnGuardarNuevoProveedor.Click += new EventHandler(GuardarProveedor);
        }

        private void GuardarProveedor(object sender, EventArgs e)
        {
            ProveedorDao proveedorDao = new ProveedorDao();
            if (ValidacionesDeControles.ValidarBotonIngresoProveedor(ingresoProveedorView.txtIngresarNombreProveedor.Text) == false)
            {
                MessageBox.Show("Debe ingresar un nombre para el proveedor");
            }
            else
            {
                bool respuestaIngresoProveedor = proveedorDao.GuardarProveedor(ingresoProveedorView.txtIngresarNombreProveedor.Text, ingresoProveedorView.txtIngresarCelularProveedor.Text, ingresoProveedorView.txtIngresarTelefonoProveedor.Text, ingresoProveedorView.txtIngresarDireccionProveedor.Text);
                if (respuestaIngresoProveedor)
                {
                    ingresoProveedorView.txtIngresarNombreProveedor.Clear();
                    ingresoProveedorView.txtIngresarCelularProveedor.Clear();
                    ingresoProveedorView.txtIngresarTelefonoProveedor.Clear();
                    ingresoProveedorView.txtIngresarDireccionProveedor.Clear();
                    ingresoProveedorView.Close();
                    MessageBox.Show("El proveedor ha sido guardado con exito");
                }
                else MessageBox.Show("Error al intentar guardar el proveedor");
            }
        }
    }
}

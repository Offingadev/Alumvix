﻿using Alumvix.Model.Dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace Alumvix.Model.Dao
{
    internal class ProductoDao:DbContext
    {
        SqlDataReader lectorFilas;
        SqlCommand command = new SqlCommand();

        public List<ProductoDto> ObtenerListadoProductos(int idContrato)
        {
            command.Connection = connection;
            command.CommandText = "select ID_PRODUCTO, nombreProducto from CONTRATO "
                                +"inner join CONTRATO_PRODUCTO on CONTRATO.ID_CONTRATO = CONTRATO_PRODUCTO.FK_ID_CONTRATO3 "
                                +"inner join PRODUCTO on CONTRATO_PRODUCTO.FK_ID_PRODUCTO = PRODUCTO.ID_PRODUCTO where ID_CONTRATO ="+idContrato;
            command.CommandType = CommandType.Text;
            connection.Open();

            lectorFilas = command.ExecuteReader();
            List<ProductoDto> listaProductos = new List<ProductoDto>();
            while (lectorFilas.Read())
            {
                listaProductos.Add(new ProductoDto
                {
                    IdProducto = lectorFilas.GetInt32(0),
                    NombreProducto = lectorFilas.GetString(1),                  
                });
            }
            lectorFilas.Close();
            connection.Close();
            return listaProductos;
        }

        public string IngresarProducto(int idContrato, int idProducto)
        {
            command.Connection = connection;
            command.CommandText = "insert into CONTRATO_PRODUCTO values("+idContrato+", "+idProducto+")";
            command.CommandType = CommandType.Text;
            connection.Open();
            int filasAfectadasEnBd = command.ExecuteNonQuery();
            if (filasAfectadasEnBd > 0)
            {
                return "El producto se ha guardado con exito";
            }
            else return "Error al intentar guardar el producto";
        }

        public List<string> ObtenerAllProducts()
        {
            command.Connection = connection;
            command.CommandText = "select * from PRODUCTO";
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            List<string> productos = new List<string>();
            productos.Add("--Seleccionar--");
            while (lectorFilas.Read())
            {
                productos.Add(lectorFilas.GetString(1));
            }
            return productos;
        }

        public string ObtenerUnNombreProducto(int idProducto)
        {
            command.Connection = connection;
            command.CommandText = "select * from PRODUCTO where ID_PRODUCTO = "+ idProducto;
            command.CommandType = CommandType.Text;
            connection.Open();
            lectorFilas = command.ExecuteReader();
            string nombreProducto = lectorFilas.GetString(1);
            return nombreProducto;
        }
    }
}

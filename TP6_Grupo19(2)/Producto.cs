using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP6_Grupo19_2_
{
    public class Producto
    {
        /// PROPIEDADES
        private int idProducto;
        private string nombreProducto;
        private string cantidadPorUnidad;
        private decimal precioUnidad;


        /// CONSTRUCTOR
        public Producto()
        {
            ///Cnstructor vacio
        }

        public Producto(int idProducto, string nombreProducto, string cantidadPorUnidad, decimal precioUnidad)
        {
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;
            this.cantidadPorUnidad = cantidadPorUnidad;
            this.precioUnidad = precioUnidad;
        }




        // METODOS GETTERS Y SETTERS
        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }

        public string NombreProducto
        {
            get { return nombreProducto; }
            set { nombreProducto = value; }
        }

        public string CantidadPorUnidad
        {
            get { return cantidadPorUnidad; }
            set { cantidadPorUnidad = value; }
        }

        public decimal PrecioUnidad
        {
            get { return precioUnidad; }
            set { precioUnidad = value; }
        }










    }





}
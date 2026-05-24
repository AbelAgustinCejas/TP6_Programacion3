using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP6_Grupo19_2_
{
    public class Producto
    {
        /// PROPIEDADES
        private int _idProducto;
        private string _nombreProducto;
        private string _cantidadPorUnidad;
        private decimal _precioUnidad;


        /// CONSTRUCTOR
        public Producto()
        {
            ///Cnstructor vacio
        }

        public Producto(int idProducto, string nombreProducto, string cantidadPorUnidad, decimal precioUnidad)
        {
            _idProducto = idProducto;
            _nombreProducto = nombreProducto;
            _cantidadPorUnidad = cantidadPorUnidad;
            _precioUnidad = precioUnidad;
        }




        // METODOS GETTERS Y SETTERS
        public int IdProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }

        public string NombreProducto
        {
            get { return _nombreProducto; }
            set { _nombreProducto = value; }
        }

        public string CantidadPorUnidad
        {
            get { return _cantidadPorUnidad; }
            set { _cantidadPorUnidad = value; }
        }

        public decimal PrecioUnidad
        {
            get { return _precioUnidad; }
            set { _precioUnidad = value; }
        }

    }
}
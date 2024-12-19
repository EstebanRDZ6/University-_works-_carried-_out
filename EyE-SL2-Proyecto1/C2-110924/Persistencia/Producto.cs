using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace C2_110924.Persistencia
{
    internal class Producto
    {
        private string _id;
        private string _nombre;

        // Constructor
        public Producto(string id, string nombre)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("El ID no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede estar vacío.");

            _id = id;
            _nombre = nombre;
        }

        // Propiedades
        public string ID
        {
            get { return _id; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _id = value;
                }
                else
                {
                    throw new ArgumentException("El ID no puede estar vacío.");
                }
            }
        }

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _nombre = value;
                }
                else
                {
                    throw new ArgumentException("El nombre no puede estar vacío.");
                }
            }
        }

        public int StockActual
        {
            get
            {
                int stockActual = 0;
                foreach (var movimiento in _movimientos)
                {
                    stockActual += movimiento.Cantidad;
                }
                return stockActual;
            }
        }

        public override string ToString()
        {
            return $"{Nombre} (ID: {ID}) | Stock actual: {StockActual}";
        }

        // Métodos para manejar movimientos
        public void CargarMovimientos(List<Movimiento> listaMovimientos)
        {
            _movimientos = listaMovimientos ?? new List<Movimiento>();
        }

        public Movimiento AgregarUnidades(string idMovimiento, int cantidadUnidades, DateTime fecha)
        {
            if (cantidadUnidades <= 0)
                throw new ArgumentException("La cantidad debe ser mayor que cero para agregar unidades.");

            var carga = new Movimiento(idMovimiento, cantidadUnidades, fecha);
            _movimientos.Add(carga);
            return carga;
        }

        public Movimiento RestarUnidades(string idMovimiento, int cantidadUnidades, DateTime fecha)
        {
            if (cantidadUnidades <= 0)
                throw new ArgumentException("La cantidad debe ser mayor que cero para restar unidades.");

            if (StockActual < cantidadUnidades)
                throw new InvalidOperationException("No hay suficiente stock para realizar la operación.");

            var descarga = new Movimiento(idMovimiento, -cantidadUnidades, fecha);
            _movimientos.Add(descarga);
            return descarga;
        }

        // Lista de movimientos
        private List<Movimiento> _movimientos = new List<Movimiento>();
    }
}


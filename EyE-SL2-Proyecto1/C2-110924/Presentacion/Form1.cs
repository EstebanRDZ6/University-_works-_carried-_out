using C2_110924.Controladores;
using C2_110924.Negocio;
using C2_110924.Persistencia;

namespace C2_110924
{
    public partial class Form1 : Form
    {
        private List<Producto> _listaProductos = new List<Producto>();
        private Producto? _unProducto;

        public Form1()
        {
            InitializeComponent();
        }

        private void SincronizarListado()
        {
            lstProductos.Items.Clear();

            try
            {
                _listaProductos = ProductosController.LeerProductos() ?? new List<Producto>();
                foreach (var producto in _listaProductos)
                {
                    lstProductos.Items.Add(producto); // Se agregan productos a la lista.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error en la lectura de productos.\nDetalles del error: {ex.Message}");
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Crear y agregar un nuevo producto
            string idProducto = txtID.Text;
            string nombreProducto = txtNombre.Text;

            try
            {
                Producto nuevoProducto = new Producto(idProducto, nombreProducto);
                ProductosController.GuardarProducto(nuevoProducto);
                SincronizarListado();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el producto: {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SincronizarListado(); // Cargar los productos al iniciar el formulario.
        }


        private void btnRecargar_Click(object sender, EventArgs e)
        {
            SincronizarListado();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstProductos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un producto.");
                return;
            }

            // Obtener producto seleccionado
            _unProducto = _listaProductos[lstProductos.SelectedIndex];

            // Leer cantidad ingresada
            int cantidadIngresada = (int)nupCantidadMovimineto.Value;

            // Generar ID único para el movimiento
            string idMovimiento = DateTime.Now.ToString("yyyyMMddHHmmss");

            try
            {
                if (cbxTipoMovimiento.SelectedIndex == 0)
                {
                    // Agregar unidades
                    Movimiento ingreso = _unProducto.AgregarUnidades(idMovimiento, cantidadIngresada, DateTime.Now);
                    ProductosController.AgregarMovimiento(_unProducto, ingreso);
                }
                else
                {
                    // Restar unidades
                    Movimiento egreso = _unProducto.RestarUnidades(idMovimiento, cantidadIngresada, DateTime.Now);
                    ProductosController.AgregarMovimiento(_unProducto, egreso);
                }

                SincronizarListado();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el producto seleccionado en el ListBox (es un objeto Producto)
                Producto productoSeleccionado = lstProductos.SelectedItem as Producto;

                if (productoSeleccionado == null)
                {
                    MessageBox.Show("Por favor, selecciona un producto para eliminar.");
                    return;
                }

                // Convertir el ID a int antes de pasarlo al servicio
                if (int.TryParse(productoSeleccionado.ID, out int idProducto))
                {
                    // Mostrar un mensaje de confirmación
                    DialogResult resultado = MessageBox.Show(
                        $"¿Estás seguro que deseas eliminar el producto {productoSeleccionado.Nombre}?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (resultado == DialogResult.Yes)
                    {
                        // Llamar al servicio para eliminar el producto
                        bool eliminado = ProductosService.EliminarProductoPorID(idProducto);

                        if (eliminado)
                        {
                            MessageBox.Show("Producto eliminado correctamente.");
                            SincronizarListado(); 
                        }
                        else
                        {
                            MessageBox.Show("No se pudo encontrar el producto para eliminar.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El ID del producto no es válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error al eliminar el producto.\nDetalles del error: {ex.Message}");
            }

        }
    }
}




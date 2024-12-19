namespace Escritura_de_un_Producto_en_una_base_de_datos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    // Crear un nuevo producto
                    var producto = new Producto
                    {
                        Descripcion = textBoxDescripcion.Text,
                        Precio = decimal.Parse(textBoxPrecio.Text)
                    };

                    // Agregar el producto a la base de datos
                    db.Productos.Add(producto);
                    db.SaveChanges();
                    MessageBox.Show("Producto agregado correctamente.");

                    // Recargar los datos en el DataGridView
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }
        private void CargarDatos()
        {
            using (var db = new AppDbContext())
            {
                var productos = db.Productos.ToList();
                foreach (var producto in productos)
                {
                    Console.WriteLine($"Id: {producto.Id}, Descripcion: {producto.Descripcion}, Precio: {producto.Precio}");
                }

                dataGridViewProductos.DataSource = productos;
            }
        }
    }
}

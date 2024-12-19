namespace ARCHIVOS_DATOS__ESTRUCTURAS_DE_REGISTROS_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string archivoVehiculo = "vehiculo.dat";
        public class Vehiculo
        {
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public int Año { get; set; }
            public string Color { get; set; }
            public string NumeroDeSerie { get; set; }

            public void Guardar(string filePath)
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(Marca);
                    writer.WriteLine(Modelo);
                    writer.WriteLine(Año);
                    writer.WriteLine(Color);
                    writer.WriteLine(NumeroDeSerie);
                }
            }

            public static Vehiculo Cargar(string filePath)
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    Vehiculo vehiculo = new Vehiculo
                    {
                        Marca = reader.ReadLine(),
                        Modelo = reader.ReadLine(),
                        Año = int.Parse(reader.ReadLine()),
                        Color = reader.ReadLine(),
                        NumeroDeSerie = reader.ReadLine()
                    };
                    return vehiculo;
                }
            }

            public override string ToString()
            {
                return $"Marca: {Marca} \nModelo: {Modelo} \nAño: {Año} \nColor: {Color} \nNúmero de Serie: {NumeroDeSerie}";
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear un objeto Vehiculo con los datos ingresados
                Vehiculo vehiculo = new Vehiculo
                {
                    Marca = txtMarca.Text,
                    Modelo = txtModelo.Text,
                    Año = int.Parse(txtAño.Text),
                    Color = txtColor.Text,
                    NumeroDeSerie = txtNumeroSerie.Text
                };

                // Guardar los datos en el archivo
                vehiculo.Guardar(archivoVehiculo);
                MessageBox.Show("Datos del vehículo guardados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos: {ex.Message}");
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                // Cargar los datos desde el archivo
                Vehiculo vehiculo = Vehiculo.Cargar(archivoVehiculo);

                // Mostrar los datos en el TextBox de resultados
                txtMostrar.Text = vehiculo.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si el archivo existe
                if (File.Exists(archivoVehiculo))
                {
                    // Eliminar el archivo
                    File.Delete(archivoVehiculo);
                    MessageBox.Show("El archivo de datos ha sido eliminado correctamente.");

                    // Limpiar el TextBox de resultados
                    txtMostrar.Clear();
                }
                else
                {
                    MessageBox.Show("El archivo no existe, no hay nada que eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el archivo: {ex.Message}");
            }
        }
    }
}

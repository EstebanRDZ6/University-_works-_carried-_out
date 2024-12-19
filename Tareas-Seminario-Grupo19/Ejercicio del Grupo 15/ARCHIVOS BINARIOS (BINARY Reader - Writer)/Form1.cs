namespace ARCHIVOS_BINARIOS__BINARY_Reader___Writer_
{
    public partial class Form1 : Form
    {
        private string archivoAlumnos = "alumnos.dat";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los datos del formulario
                string nombre = txtNombre.Text;
                string dni = txtDNI.Text;
                string telefono = txtTelefono.Text;

                // Validar que los campos no estén vacíos
                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(telefono))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                // Crear un objeto Alumno
                Alumno nuevoAlumno = new Alumno(nombre, dni, telefono);

                // Abrir el archivo binario y agregar los datos
                using (BinaryWriter writer = new BinaryWriter(File.Open(archivoAlumnos, FileMode.Append)))
                {
                    writer.Write(nuevoAlumno.Nombre);
                    writer.Write(nuevoAlumno.DNI);
                    writer.Write(nuevoAlumno.Telefono);
                }

                MessageBox.Show("Alumno guardado correctamente.");

                // Limpiar los campos
                txtNombre.Clear();
                txtDNI.Clear();
                txtTelefono.Clear();
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
                // Limpiar el ListBox antes de cargar los datos
                lstAlumnos.Items.Clear();

                // Verificar si el archivo existe
                if (File.Exists(archivoAlumnos))
                {
                    // Leer los datos desde el archivo binario
                    using (BinaryReader reader = new BinaryReader(File.Open(archivoAlumnos, FileMode.Open)))
                    {
                        while (reader.BaseStream.Position < reader.BaseStream.Length)
                        {
                            string nombre = reader.ReadString();
                            string dni = reader.ReadString();
                            string telefono = reader.ReadString();

                            // Crear un objeto Alumno y agregarlo al ListBox
                            Alumno alumno = new Alumno(nombre, dni, telefono);
                            lstAlumnos.Items.Add(alumno);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos almacenados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si se ha seleccionado un alumno en el ListBox
                if (lstAlumnos.SelectedItem != null)
                {
                    // Obtener el alumno seleccionado
                    Alumno alumnoSeleccionado = (Alumno)lstAlumnos.SelectedItem;

                    // Eliminar el alumno de la lista
                    lstAlumnos.Items.Remove(alumnoSeleccionado);

                    // Crear una lista temporal para almacenar los alumnos restantes
                    List<Alumno> alumnosRestantes = new List<Alumno>();

                    // Leer todos los alumnos y agregar los que no han sido eliminados
                    using (BinaryReader reader = new BinaryReader(File.Open(archivoAlumnos, FileMode.Open)))
                    {
                        while (reader.BaseStream.Position < reader.BaseStream.Length)
                        {
                            string nombre = reader.ReadString();
                            string dni = reader.ReadString();
                            string telefono = reader.ReadString();

                            Alumno alumno = new Alumno(nombre, dni, telefono);
                            if (alumno != alumnoSeleccionado)  // Solo agregar a los que no fueron eliminados
                            {
                                alumnosRestantes.Add(alumno);
                            }
                        }
                    }

                    // Reescribir el archivo con los alumnos restantes
                    using (BinaryWriter writer = new BinaryWriter(File.Open(archivoAlumnos, FileMode.Create)))
                    {
                        foreach (Alumno alumno in alumnosRestantes)
                        {
                            writer.Write(alumno.Nombre);
                            writer.Write(alumno.DNI);
                            writer.Write(alumno.Telefono);
                        }
                    }

                    MessageBox.Show("Alumno eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un alumno para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el alumno: {ex.Message}");
            }
        }
    }
}

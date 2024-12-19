namespace TrabajandoConArchivosJson
{
    public partial class Form1 : Form
    {
        private List<Persona> listaPersonas = new List<Persona>();
        private string rutaArchivo = "personas.json";

        public Form1()
        {
            InitializeComponent();
        }
        private void SerializarLista()
        {
            try
            {
                // Serializar la lista de personas a formato JSON
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(listaPersonas, Newtonsoft.Json.Formatting.Indented);

                // Guardar en el archivo
                File.WriteAllText(rutaArchivo, json);

                // Mostrar el JSON serializado en el TextBox
                textBoxResultados.Clear(); // Limpiar el TextBox antes de mostrar el nuevo contenido
                textBoxResultados.AppendText(json);

                MessageBox.Show("Lista serializada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al serializar: {ex.Message}");
            }
        }
        private void DeserializarLista()
        {
            try
            {
                if (File.Exists(rutaArchivo))
                {
                    // Leer el contenido del archivo JSON
                    string contenidoJson = File.ReadAllText(rutaArchivo);

                    // Deserializar el contenido a una lista de personas
                    listaPersonas = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Persona>>(contenidoJson) ?? new List<Persona>();

                    // Mostrar las personas en el formato deseado
                    MostrarPersonas();

                    MessageBox.Show("Lista deserializada correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró el archivo personas.json.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al deserializar: {ex.Message}");
            }
        }
        private void MostrarPersonas()
        {
            textBoxResultados.Clear();  // Limpiar el TextBox antes de mostrar los nuevos resultados.

            // Mostrar las personas en el formato deseado
            foreach (var persona in listaPersonas)
            {
                textBoxResultados.AppendText($" Nombre: {persona.Nombre} Edad: {persona.Edad} Correo: {persona.Correo}\n");
            }
        }
        private void AgregarPersona(string nombre, int edad, string correo)
        {
            listaPersonas.Add(new Persona { Nombre = nombre, Edad = edad, Correo = correo });
            MostrarPersonas();  // Mostrar la lista actualizada en el TextBox
            MessageBox.Show("Persona agregada correctamente.");
        }
        private void EliminarPersona(string nombre)
        {
            var personaAEliminar = listaPersonas.FirstOrDefault(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));

            if (personaAEliminar != null)
            {
                listaPersonas.Remove(personaAEliminar);
                MostrarPersonas();
                MessageBox.Show("Persona eliminada correctamente.");
            }
            else
            {
                MessageBox.Show("Persona no encontrada.");
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = textBoxNombre.Text;
                int edad = int.Parse(textBoxEdad.Text);
                string correo = textBoxCorreo.Text;

                AgregarPersona(nombre, edad, correo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar persona: {ex.Message}");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            EliminarPersona(nombre);
        }

        private void buttonSerializar_Click(object sender, EventArgs e)
        {
            SerializarLista();
        }

        private void buttonDeserializar_Click(object sender, EventArgs e)
        {
            DeserializarLista();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cargar datos iniciales al iniciar el programa
            listaPersonas.Add(new Persona { Nombre = "Juan", Edad = 22, Correo = "13212@hotmail.com" });
            listaPersonas.Add(new Persona { Nombre = "Jessica", Edad = 20, Correo = "12312@hotmail.com" });
            listaPersonas.Add(new Persona { Nombre = "Messi", Edad = 37, Correo = "ElMejor@gmail.com" });
            listaPersonas.Add(new Persona { Nombre = "Anastasio", Edad = 80, Correo = "ElSimple@hotmail.com" });
            // Mostrar los datos en el TextBox
            MostrarPersonas();
        }
    }
}

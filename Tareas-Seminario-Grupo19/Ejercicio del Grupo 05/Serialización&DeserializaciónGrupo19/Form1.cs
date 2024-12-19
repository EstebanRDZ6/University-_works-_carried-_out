using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Serialización_DeserializaciónGrupo19
{
    public partial class Form1 : Form
    {
        private List<Persona> listaPersonas = new List<Persona>(); // Lista de objetos
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear y agregar una nueva persona a la lista
                Persona nuevaPersona = new Persona
                {
                    Nombre = textBoxNombre.Text,
                    Edad = int.Parse(textBoxEdad.Text)
                };

                listaPersonas.Add(nuevaPersona);
                ActualizarTextBox();
                MessageBox.Show("Persona agregada a la lista.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar: " + ex.Message);
            }
        }

        private void buttonSerializar_Click(object sender, EventArgs e)
        {
            SerializarLista();
        }

        private void buttonDeserializar_Click(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<Persona>));
                using (FileStream fs = new FileStream("Personas.xml", FileMode.Open))
                {
                    listaPersonas = (List<Persona>)deserializer.Deserialize(fs);
                }

                ActualizarTextBox(); // Actualiza el contenido del TextBox con la lista deserializada.
                MessageBox.Show("Datos deserializados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al deserializar los datos: {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cargar datos iniciales
            listaPersonas.Add(new Persona { Nombre = "Juan", Edad = 30 });
            listaPersonas.Add(new Persona { Nombre = "Ana", Edad = 25 });
            listaPersonas.Add(new Persona { Nombre = "Carlos", Edad = 40 });

            // Mostrar los datos iniciales en el TextBoxResultados
            textBoxResultados.Clear();
            foreach (var persona in listaPersonas)
            {
                textBoxResultados.AppendText($"Nombre: {persona.Nombre}, Edad: {persona.Edad}\n");
            }

            MessageBox.Show("Datos iniciales cargados.");
        }
        private void SerializarLista()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Persona>));

                using (FileStream fs = new FileStream("Personas.xml", FileMode.Create))
                {
                    serializer.Serialize(fs, listaPersonas); // Serializa la lista en el archivo.
                }

                // Mostrar la serialización en el TextBoxResultados.
                using (StringWriter stringWriter = new StringWriter())
                {
                    serializer.Serialize(stringWriter, listaPersonas);
                    textBoxResultados.Text = stringWriter.ToString(); // Muestra la serialización en el TextBoxResultados.
                }

                MessageBox.Show("Lista serializada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al serializar: {ex.Message}");
            }
        }
        private void ActualizarTextBox()
        {
            textBoxResultados.Clear(); // Limpia el contenido existente.
            foreach (var persona in listaPersonas)
            {
                // Concatenar los datos de cada persona en una sola línea.
                textBoxResultados.AppendText($"Nombre: {persona.Nombre} Edad: {persona.Edad} ");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = textBoxNombre.Text;
                int edad = int.Parse(textBoxEdad.Text);

                EliminarPersona(nombre, edad); // Llama al método para eliminar la persona.
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa una edad válida.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void EliminarPersona(string nombre, int edad)
        {
            try
            {
                // Busca la persona en la lista
                var personaAEliminar = listaPersonas.FirstOrDefault(p => p.Nombre == nombre && p.Edad == edad);

                if (personaAEliminar != null)
                {
                    listaPersonas.Remove(personaAEliminar); // Elimina la persona de la lista.
                    ActualizarTextBoxResultados(); // Actualiza el TextBoxResultados con la lista actualizada.
                    MessageBox.Show($"Persona eliminada: Nombre: {nombre}, Edad: {edad}");
                }
                else
                {
                    MessageBox.Show("Persona no encontrada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar persona: {ex.Message}");
            }
        }
        private void ActualizarTextBoxResultados()
        {
            textBoxResultados.Clear(); // Limpia el contenido anterior.

            foreach (var persona in listaPersonas)
            {
                textBoxResultados.AppendText($"Nombre: {persona.Nombre}, Edad: {persona.Edad}\n");
            }
        }


    }
    [Serializable]
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
}

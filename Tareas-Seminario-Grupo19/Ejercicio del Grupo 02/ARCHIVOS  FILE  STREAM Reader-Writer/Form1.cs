using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
namespace ARCHIVOS__FILE__STREAM_Reader_Writer
{
    public partial class Form1 : Form
    {
        private string filePath = "tareas.txt";
        public Form1()
        {
            InitializeComponent();
        }
        private void MostrarTareas()
        {
            lstTareas.Items.Clear();

            // Leer las tareas del archivo y agregarlas al ListBox
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        lstTareas.Items.Add(linea);
                    }
                }
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            string tarea = txtTarea.Text;
            if (!string.IsNullOrEmpty(tarea))
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(tarea);
                }
                MessageBox.Show("Tarea agregada correctamente.");
                txtTarea.Clear();
                MostrarTareas();
            }
            else
            {
                MessageBox.Show("Por favor ingresa una tarea.");
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (lstTareas.SelectedItem != null)
            {
                string tareaModificada = txtTarea.Text;
                if (!string.IsNullOrEmpty(tareaModificada))
                {
                    // Leer todas las tareas
                    List<string> tareas = new List<string>();
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string linea;
                        while ((linea = reader.ReadLine()) != null)
                        {
                            tareas.Add(linea);
                        }
                    }

                    // Reemplazar la tarea seleccionada por la modificada
                    int index = lstTareas.SelectedIndex;
                    tareas[index] = tareaModificada;

                    // Sobrescribir el archivo con las tareas modificadas
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        foreach (var tarea in tareas)
                        {
                            writer.WriteLine(tarea);
                        }
                    }

                    MessageBox.Show("Tarea modificada correctamente.");
                    MostrarTareas();
                    txtTarea.Clear();
                }
                else
                {
                    MessageBox.Show("Por favor ingresa una tarea para modificar.");
                }
            }
            else
            {
                MessageBox.Show("Selecciona una tarea para modificar.");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (lstTareas.SelectedItem != null)
            {
                // Leer todas las tareas
                List<string> tareas = new List<string>();
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        tareas.Add(linea);
                    }
                }

                // Eliminar la tarea seleccionada
                int index = lstTareas.SelectedIndex;
                tareas.RemoveAt(index);

                // Sobrescribir el archivo con las tareas restantes
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var tarea in tareas)
                    {
                        writer.WriteLine(tarea);
                    }
                }

                MessageBox.Show("Tarea eliminada correctamente.");
                MostrarTareas();
            }
            else
            {
                MessageBox.Show("Selecciona una tarea para eliminar.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarTareas();
        }
    }
}

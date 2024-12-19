namespace Aeropuerto19
{
    public partial class Form1 : Form
    {
        private AvionDataBase avionDB = new AvionDataBase();
        public Form1()
        {
            InitializeComponent();
            CargarAviones();
        }
        private void CargarAviones()
        {
            var aviones = avionDB.ObtenerAviones(); // Llama al método que obtiene los datos.
            if (aviones != null)
            {
                dataGridViewAviones.DataSource = aviones; // Asigna los datos al DataGridView.
            }
        }

        // Método para limpiar los campos de entrada.
        private void LimpiarCampos()
        {
            textBoxId.Clear();
            textBoxModelo.Clear();
            textBoxTipoDeNave.Clear();
            textBoxMatricula.Clear();
            textBoxCapacidadPasajeros.Clear();
        }

        // Evento para seleccionar un avión desde el DataGridView.
        private void dataGridViewAviones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewAviones.Rows[e.RowIndex];
                textBoxId.Text = row.Cells["Id"].Value.ToString();
                textBoxModelo.Text = row.Cells["Modelo"].Value.ToString();
                textBoxTipoDeNave.Text = row.Cells["TipoDeNave"].Value.ToString();
                textBoxMatricula.Text = row.Cells["Matricula"].Value.ToString();
                textBoxCapacidadPasajeros.Text = row.Cells["CapacidadPasajeros"].Value.ToString();
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Avion avion = new Avion
                {
                    Id = int.Parse(textBoxId.Text),
                    Modelo = textBoxModelo.Text,
                    TipoDeNave = textBoxTipoDeNave.Text,
                    Matricula = textBoxMatricula.Text,
                    CapacidadPasajeros = int.Parse(textBoxCapacidadPasajeros.Text)
                };

                avionDB.InsertarAvion(avion); // Inserta el avión en la base de datos.
                MessageBox.Show("Avión agregado correctamente.");
                CargarAviones(); // Recarga los datos en el DataGridView.
                LimpiarCampos(); // Limpia los campos de entrada.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el avión: " + ex.Message);
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar los campos
                if (string.IsNullOrEmpty(textBoxId.Text) || !int.TryParse(textBoxId.Text, out int id) ||
                    string.IsNullOrEmpty(textBoxModelo.Text) || string.IsNullOrEmpty(textBoxTipoDeNave.Text) ||
                    string.IsNullOrEmpty(textBoxMatricula.Text) || string.IsNullOrEmpty(textBoxCapacidadPasajeros.Text))
                {
                    MessageBox.Show("Por favor complete todos los campos con información válida.");
                    return;
                }

                // Crear el objeto avion con los datos del formulario
                Avion avion = new Avion
                {
                    Id = id,
                    Modelo = textBoxModelo.Text,
                    TipoDeNave = textBoxTipoDeNave.Text,
                    Matricula = textBoxMatricula.Text,
                    CapacidadPasajeros = int.Parse(textBoxCapacidadPasajeros.Text)
                };

                // Modificar el avión en la base de datos
                avionDB.ModificarAvion(avion); // Asegúrate de que ModificarAvion esté funcionando correctamente.
                MessageBox.Show("Avión modificado correctamente.");

                // Recargar los datos
                CargarAviones(); // Asegúrate de que este método esté actualizando correctamente el DataGridView.

                // Limpiar los campos de entrada
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el avión: " + ex.Message);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBoxId.Text);
                avionDB.EliminarAvion(id); // Elimina el avión de la base de datos.
                MessageBox.Show("Avión eliminado correctamente.");
                CargarAviones(); // Recarga los datos en el DataGridView.
                LimpiarCampos(); // Limpia los campos de entrada.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el avión: " + ex.Message);
            }
        }
    }
}


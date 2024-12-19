using System.ComponentModel;

namespace GestionandoVehiculosConElGrupo19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private BindingList<Vehiculo> vehiculos = new BindingList<Vehiculo>();
        private void Form1_Load(object sender, EventArgs e)
        {
            lstVehiculos.DataSource = vehiculos;
            lstVehiculos.DisplayMember = "ObtenerInformacion";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener datos desde los TextBox
                string nombreDueno = txtNombreDueno.Text;
                int ano = int.Parse(txtAno.Text);
                string marca = txtMarca.Text;
                decimal precio = decimal.Parse(txtPrecio.Text);
                string descripcion = txtDescripcion.Text;
                string tipoVehiculo = cmbTipoVehiculo.SelectedItem.ToString();

                Vehiculo vehiculo = null;

                // Crear el veh�culo seg�n el tipo seleccionado
                if (tipoVehiculo == "Auto")
                {
                    vehiculo = new Auto(nombreDueno, ano, marca, precio, descripcion);
                }
                else if (tipoVehiculo == "Moto")
                {
                    vehiculo = new Moto(nombreDueno, ano, marca, precio, descripcion);
                }

                // Agregar el veh�culo a la lista
                if (vehiculo != null)
                {
                    vehiculos.Add(vehiculo);
                    MessageBox.Show("Veh�culo agregado exitosamente.");
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un tipo de veh�culo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el veh�culo: {ex.Message}");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (lstVehiculos.SelectedItem != null)
            {
                var selectedItem = lstVehiculos.SelectedItem as Vehiculo;
                if (selectedItem != null)
                {
                    vehiculos.Remove(selectedItem);
                    MessageBox.Show("Veh�culo eliminado correctamente.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un veh�culo para eliminar.");
            }
        }
    }
}

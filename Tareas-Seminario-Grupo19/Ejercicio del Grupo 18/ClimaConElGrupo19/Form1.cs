using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace ClimaConElGrupo19
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonConsultar_Click(object sender, EventArgs e)
        {
            string ciudad = textBoxCiudad.Text.Trim();
            if (string.IsNullOrEmpty(ciudad))
            {
                MessageBox.Show("Por favor ingrese una ciudad.");
                return;
            }

            // Llamar al servicio Web para obtener el clima
            var clima = await ObtenerClimaAsync(ciudad);

            if (clima != null)
            {
                labelCiudad.Visible = true;
                labelTemperatura.Visible = true;
                labelHumedad.Visible = true;
                labelSensacionTermica.Visible = true;
                labelViento.Visible = true;
                // Mostrar los datos en los Label
                labelCiudad.Text = $"{clima.nearest_area[0].areaName[0].value}, {clima.nearest_area[0].country[0].value}";
                labelTemperatura.Text = $"Temperatura: {clima.current_condition[0].temp_C} °C";
                labelHumedad.Text = $"Humedad: {clima.current_condition[0].humidity} %";
                labelSensacionTermica.Text = $"Sensación Térmica: {clima.current_condition[0].FeelsLikeC} °C";
                labelViento.Text = $"Viento: {clima.current_condition[0].windspeedKmph} km/h";
            }
            else
            {
                MessageBox.Show("No se pudo obtener la información del clima.");
            }
        }
        private async Task<ClimaResponse> ObtenerClimaAsync(string ciudad)
        {
            try
            {
                string url = $"https://wttr.in/{ciudad}?format=j1";
                var response = await client.GetStringAsync(url);
                var climaData = JsonConvert.DeserializeObject<ClimaResponse>(response);
                return climaData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el clima: {ex.Message}");
                return null;
            }
        }
    }
    public class ClimaResponse
    {
        public NearestArea[] nearest_area { get; set; }
        public CurrentCondition[] current_condition { get; set; }
    }

    public class NearestArea
    {
        public AreaName[] areaName { get; set; }
        public Country[] country { get; set; }
    }

    public class AreaName
    {
        public string value { get; set; }
    }

    public class Country
    {
        public string value { get; set; }
    }

    public class CurrentCondition
    {
        public string temp_C { get; set; }
        public string humidity { get; set; }
        public string FeelsLikeC { get; set; }
        public string windspeedKmph { get; set; }
    }

}

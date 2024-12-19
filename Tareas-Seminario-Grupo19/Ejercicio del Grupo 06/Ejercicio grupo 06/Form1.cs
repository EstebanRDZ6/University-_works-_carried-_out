using AreasGeometricas.DLL;

namespace Ejercicio_grupo_06__DLL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxFiguras.Items.AddRange(new string[] { "C�rculo", "Cuadrado", "Rect�ngulo", "Tri�ngulo" });
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string figura = comboBoxFiguras.SelectedItem?.ToString();
                double param1 = double.Parse(textBoxParam1.Text);
                double resultado = 0;

                switch (figura)
                {
                    case "C�rculo":
                        resultado = CalculoAreas.Circulo(param1);
                        break;
                    case "Cuadrado":
                        resultado = CalculoAreas.Cuadrado(param1);
                        break;
                    case "Rect�ngulo":
                        double param2 = double.Parse(textBoxParam2.Text);
                        resultado = CalculoAreas.Rectangulo(param1, param2);
                        break;
                    case "Tri�ngulo":
                        param2 = double.Parse(textBoxParam2.Text);
                        resultado = CalculoAreas.Triangulo(param1, param2);
                        break;
                    default:
                        MessageBox.Show("Seleccione una figura v�lida.");
                        return;
                }


                labelResultado.Text = $"�rea: {resultado:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void comboBoxFiguras_SelectedIndexChanged(object sender, EventArgs e)
        {
            string figura = comboBoxFiguras.SelectedItem?.ToString();
            textBoxParam2.Enabled = figura == "Rect�ngulo" || figura == "Tri�ngulo";
            textBoxParam2.Clear();
        }
    }
}

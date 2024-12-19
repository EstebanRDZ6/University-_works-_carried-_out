namespace DesafiosDelGrupo13_HechasPorElGrupo19
{
    public partial class Form1 : Form
    {
        List<int> listaNumeros = new List<int>();
        Queue<int> colaNumeros = new Queue<int>();
        Stack<int> pilaNumeros = new Stack<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaNumeros.AddRange(new[] { 10, 20, 30, 40, 50 });
            colaNumeros.Enqueue(1);
            colaNumeros.Enqueue(2);
            colaNumeros.Enqueue(3);
            colaNumeros.Enqueue(4);
            colaNumeros.Enqueue(5);
            pilaNumeros.Push(100);
            pilaNumeros.Push(200);
            pilaNumeros.Push(300);
            pilaNumeros.Push(400);
            pilaNumeros.Push(500);

            MostrarLista();
            MostrarCola();
            MostrarPila();
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(textBoxNumero.Text);
                int posicion = int.Parse(textBoxPosicion.Text);

                listaNumeros.Insert(posicion, numero);
                MostrarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar: {ex.Message}");
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(textBoxNumero.Text);
                int posicion = int.Parse(textBoxPosicion.Text);

                listaNumeros[posicion] = numero;
                MostrarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar: {ex.Message}");
            }
        }

        private void buttonEliminarLista_Click(object sender, EventArgs e)
        {
            try
            {
                int posicion = int.Parse(textBoxPosicion.Text);

                listaNumeros.RemoveAt(posicion);
                MostrarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}");
            }
        }

        private void buttonOrdenarLista_Click(object sender, EventArgs e)
        {
            listaNumeros.Sort();
            MostrarLista();
        }
        private void MostrarLista()
        {
            listBoxLista.Items.Clear();
            foreach (int numero in listaNumeros)
            {
                listBoxLista.Items.Add(numero);
            }
        }

        private void buttonEliminarCola_Click(object sender, EventArgs e)
        {
            if (colaNumeros.Count > 0)
            {
                colaNumeros.Dequeue();
                MostrarCola();
            }
            else
            {
                MessageBox.Show("La cola está vacía.");
            }
        }

        private void buttonAñadirCola_Click(object sender, EventArgs e)
        {
            try
            {
                int numero1 = int.Parse(textBoxNumeroCola.Text);
                colaNumeros.Enqueue(numero1);

                MostrarCola();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al añadir: {ex.Message}");
            }
        }

        private void buttonMostrarCola_Click(object sender, EventArgs e)
        {
            if (colaNumeros.Count > 0)
            {
                MessageBox.Show($"Primer número en la cola: {colaNumeros.Peek()}");
            }
            else
            {
                MessageBox.Show("La cola está vacía.");
            }
        }
        private void MostrarCola()
        {
            listBoxCola.Items.Clear();
            foreach (int numero in colaNumeros)
            {
                listBoxCola.Items.Add(numero);
            }
        }

        private void buttonApilar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(textBoxNumeroPila.Text);
                pilaNumeros.Push(numero);

                MostrarPila();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al apilar: {ex.Message}");
            }
        }

        private void buttonDesapilar_Click(object sender, EventArgs e)
        {
            if (pilaNumeros.Count > 0)
            {
                pilaNumeros.Pop();
                MostrarPila();
            }
            else
            {
                MessageBox.Show("La pila está vacía.");
            }
        }

        private void buttonMostrarPila_Click(object sender, EventArgs e)
        {
            if (pilaNumeros.Count > 0)
            {
                MessageBox.Show($"Número en la parte superior: {pilaNumeros.Peek()}");
            }
            else
            {
                MessageBox.Show("La pila está vacía.");
            }
        }
        private void MostrarPila()
        {
            listBoxPila.Items.Clear();
            foreach (int numero in pilaNumeros)
            {
                listBoxPila.Items.Add(numero);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        private NumberProcessor numberProcessor;

        public Form1()
        {
            InitializeComponent();
            numberProcessor = new NumberProcessor();  // Inicializamos la clase del backend
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtenemos los números ingresados y los convertimos en una lista de enteros
            string input = textBox1.Text; // Supongo que tienes un TextBox llamado textBox1
            List<int> numbers = new List<int>();

            // Separamos los números por comas
            foreach (string num in input.Split(','))
            {
                numbers.Add(int.Parse(num.Trim()));  // Convertimos cada número a entero
            }

            // Procesamos los números con la clase del backend
            List<string> results = numberProcessor.ProcessNumbers(numbers);

            // Mostramos los resultados en el ListBox
            listBox1.Items.Clear();  // Limpiamos el ListBox antes de mostrar nuevos resultados
            foreach (string result in results)
            {
                listBox1.Items.Add(result);  // Mostramos cada resultado
            }
        }
    }
}

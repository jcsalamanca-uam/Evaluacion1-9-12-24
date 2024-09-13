using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion._2
{
    public partial class Form1 : Form
    {
        private double[] notas = new double[1000];
        private int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(TbNotas.Text, out double nota) && contador < 1000)
            {
                notas[contador] = nota;
                contador++;
                LbNotas.Items.Add(nota);

                double promedio = notas.Take(contador).Average();
                LbPromedio.Items.Clear(); 
                LbPromedio.Items.Add($"Promedio: {promedio:F2}");
                var mejoresTres = notas.Take(contador).OrderByDescending(n => n).Take(3).ToArray();
                LbPrimeros3.Items.Clear();
                LbPrimeros3.Items.Add("Primeros 3:");
                foreach (var n in mejoresTres)
                {
                    LbPrimeros3.Items.Add(n);
                }
                TbNotas.Clear();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LbNotas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

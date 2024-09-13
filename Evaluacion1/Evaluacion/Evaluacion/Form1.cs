using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarApe();
        }

        private void BtnAgregarNombre_Click(object sender, EventArgs e)
        {
            AgregarNom();
        }
        private void AgregarNom()
        {
            if (TbNombre.Text.Trim().Length > 0)
            {

                string Titulo = TbNombre.Text.Trim();
                LbNombre.Items.Add(Titulo);
                TbNombre.Clear();
                TbNombre.Focus();

            }


        }
        private void AgregarApe()
        {
            if (TbApellido.Text.Trim().Length > 0)
            {

                string TituloApe = TbApellido.Text.Trim();
                LbApellido.Items.Add(TituloApe);
                TbApellido.Clear();
                TbApellido.Focus();

            }
        }
        private void AgregarFechaNac()
        {
            if (TbFechaNac.Text.Trim().Length > 0)
            {

                string TituloFechaNac = TbFechaNac.Text.Trim();
                LbFechaNac.Items.Add(TituloFechaNac);
                TbFechaNac.Clear();
                TbFechaNac.Focus();

            }
        }
            private void TbApellido_TextChanged(object sender, EventArgs e)
        { 
           
        }

        private void TbFechaNac_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAgregarFechaNac_Click(object sender, EventArgs e)
        {
            AgregarFechaNac();
        }
    }
}

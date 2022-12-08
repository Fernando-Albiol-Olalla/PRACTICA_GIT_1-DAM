using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA_1_GIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste;
            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            if (cbUrgente.Checked)
                tipoTelegrama = 'u';

            if (cbOrdinario.Checked)
                tipoTelegrama = 'o';
            //Obtengo el número de palabras que forma el telegrama 
            //numPalabras = textoTelegrama.Length;
            //Cuento el numeró de Espacios que hay en el texto.
            for (int i = 0; i < textoTelegrama.Length; i++)
            {
                if (textoTelegrama[i] == ' ')
                    numPalabras++;
            }
            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 0.5 * numPalabras;
            else
            //Si el telegrama es urgente
            if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";
        }

        private void txtTelegrama_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbUrgente_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

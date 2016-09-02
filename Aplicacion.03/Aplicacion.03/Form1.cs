using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion._03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string textoInvertido = "";
            string textoOrdenadoAlf = "";

            for (int i = txtCadena.Text.Length - 1; i >= 0 ; i--)
            {
                textoInvertido += txtCadena.Text[i];
            }

            txtInvertida.Text = textoInvertido;

            char[] miArray = txtCadena.Text.ToCharArray(); //Convierto la cadena en una array con el metodo ToCharArray
            Array.Sort(miArray);

            foreach (char item in miArray)
            {
                textoOrdenadoAlf += item;
            }

            txtOrdenAlfabetico.Text = textoOrdenadoAlf;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCadena.Text = "";
            txtInvertida.Text = "";
            txtOrdenAlfabetico.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}

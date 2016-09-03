using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace Aplicacion._05
{
    public partial class Form1 : Form
    {

        private Numero _miNumero;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero_Enter(object sender, EventArgs e)
        {

       /*     //Cantidad de cifras
            this.txtCantCifras.Text = txtNumero.Text.Count().ToString();

            //Suma de cifras Pares e impares
            int contPar = 0;
            int contImp = 0;
            foreach (int item in this.txtNumero.Text)
            {
                if (item % 2 == 0)
                {
                    contPar++;
                }
                else
                {
                    contImp++;
                }

            }

            this.txtPares.Text = contPar.ToString();
            this.txtImpares.Text = contImp.ToString();

            //Suma total de cifras
            int suma = 0;
            foreach (int item in this.txtNumero.Text)
            {
                suma += item;
            }

            this.txtTotal.Text = suma.ToString();

            //Cifra mayor
     /*       char[] caracteres = this.txtNumero.Text.ToArray();
            Array.Sort(caracteres);
            this.txtMenor.Text = caracteres[1].ToString();
            Array.Reverse(caracteres);
            this.txtMayor.Text = caracteres[1].ToString();*/
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Numero num = new Numero(this.IngresoNumero());
            this.CompletaFormulario(num);
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Numero num = new Numero(this.IngresoNumero());
        }

        private int IngresoNumero()
        {
            return int.Parse(Interaction.InputBox("Ingrese un numero"));
        }

        private void CompletaFormulario(Numero num)
        {
            this.txtNumero.Text = num.UnNumero.ToString();
            this.txtCantCifras.Text = num.CantidadCifras().ToString();
            this.txtImpares.Text = num.SumaImpares().ToString();
            this.txtPares.Text = num.SumaPares().ToString();
            this.txtTotal.Text = num.SumaTotal().ToString();
            this.txtMayor.Text = num.CifraMayor().ToString();
            this.txtMenor.Text = num.CifraMenor().ToString();
        }

 
    }
}

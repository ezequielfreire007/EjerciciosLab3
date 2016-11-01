using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class frmCajero : Form
    {
        private int totalDeBilletes = 0;

        public frmCajero()
        {
            InitializeComponent();
        }

        private void Calcular(object sender, EventArgs e)
        {
            //lista de billetes
            int retirar = int.Parse(txtRetirar.Text);
            int[] billetes = new int [] {100, 50, 20, 10, 5, 2};
            int res = 0;
            int cont = 0;
          

            foreach (int item in billetes)
            {
                if ((retirar/item) != 0)
                {
                    res = retirar / item;
                    totalDeBilletes += res;
                    switch (cont)
                    {
                        case 0:
                            this.txtCien.Text = res.ToString();
                            cont++;

                            break;
                        case 1:
                            this.txtCincuenta.Text = res.ToString();
                            cont++;
                            break;
                        case 2:
                            this.txtVeinte.Text = res.ToString();
                            cont++;
                            break;
                        case 3:
                            this.txtDiez.Text = res.ToString();
                            cont++;
                            break;
                        case 4:
                            this.txtCinco.Text = res.ToString();
                            cont++;
                            break;
                        case 5:
                            this.txtDos.Text = res.ToString();
                            cont++;
                            break;
                        default:
                            break;
                    }
                    
                }
            }
        }

        private void Informar(object sender, EventArgs e) 
        {
            if (totalDeBilletes != int.Parse(txtRetirar.Text))
            {
                int retirar = int.Parse(txtRetirar.Text) - totalDeBilletes;
                MessageBox.Show("Le queda para retirar "+ retirar + " Pesos.","Vuelto");
            }
            else
            {
                MessageBox.Show("La cuenta esta vacia", "Vuelto");
            }
        } 

        private void frmCajero_Load(object sender, EventArgs e)
        {
            this.btnAceptar.Click += new EventHandler(Calcular);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.btnAceptar.Click -= new EventHandler(Calcular);
            this.btnLimpiar.Click += new EventHandler(Calcular);
            this.btnAceptar.Click += new EventHandler(Informar);
        }

        
        
    }
}

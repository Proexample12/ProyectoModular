using Monto.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monto
{
    public partial class CalcularMonto : Form
    {
        public CalcularMonto()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double precio = double.Parse(tbPrecio.Text);
            lblMonto.Text = "precio:" + precio + " Monto:" +
                Calculo.CalcularMonto(precio) + " precio " + precio;
        }

        private void btnCalcularRef_Click(object sender, EventArgs e)
        {
            double precio = double.Parse(tbPrecio.Text);
            lblMonto.Text = "precio: " + precio + " Monto: " +
                Calculo.CalcularMonto(ref precio) + " precio " + precio;

        }
    }
}

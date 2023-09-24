using ExamenFinal.Clases;
using ExamenFinal.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ExamenFinal
{
    public partial class AgregarTelefono : Form
    {
        public AgregarTelefono()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbGamma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void button1_Click(object sender, EventArgs e)
        {

            string gammaSel = "";
            OperacionesTelefono tel = new OperacionesTelefono();
            if (rdbX.Checked) gammaSel = "XSs";
            else if (rdbMax.Checked) gammaSel = "XSs Maxs";
            decimal por = 0;
            decimal result = 0;
            if (cmbPais.Text == "Gutamala")
            {
                por = 0.03m;
                result = Convert.ToDecimal(txtPrecio.Text) * por;
                result = Convert.ToDecimal(txtPrecio.Text) + result;
            }
            else if (cmbPais.Text == "Brujas")
            {
                por = 0.06m;
                result = Convert.ToDecimal(txtPrecio.Text) * por;
                result = Convert.ToDecimal(txtPrecio.Text) + result;
            }
            else if (cmbPais.Text == "Amsterdam")
            {
                por = 0.09m;
                result = Convert.ToDecimal(txtPrecio.Text) * por;
                result = Convert.ToDecimal(txtPrecio.Text) + result;
            }
            else if (cmbPais.Text == "Londres")
            {
                por = 0.12m;
                result = Convert.ToDecimal(txtPrecio.Text) * por;
                result = Convert.ToDecimal(txtPrecio.Text) + result;
            }
            Telefono telefono = new Telefono
            {
                Marca = txtMarca.Text,
                Gamma = gammaSel,
                PaisDeEnsamblaje = cmbPais.Text,
                precio = result,
                porcentajeAincrementar = por,
                color = cmbColor.Text,
                FechaDeRegistro = dtmFechaVenta.Value
            };
            tel.Save(telefono);
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtMarca.Text = "";
            cmbPais.Text = "";
            txtPrecio.Text = "";
            cmbColor.Text = "";
            dtmFechaVenta.Value = DateTime.Now;
        }
    }
}

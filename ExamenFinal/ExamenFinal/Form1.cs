using ExamenFinal.Utils;
using System.Data;

namespace ExamenFinal
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var cel = new AgregarTelefono()) { cel.ShowDialog(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OperacionesTelefono ot = new OperacionesTelefono();
            BindingSource bs = new BindingSource();
            DataSet ds = new DataSet();
            ds = ot.GetAllTelefonos();
            bs.DataSource = ds.Tables[0]; ;
            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();
            dataGridView1.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OperacionesTelefono ot = new OperacionesTelefono();
            BindingSource bs = new BindingSource();
            DataSet ds = new DataSet();
            dataGridView1.DataSource = null; 
            dataGridView1.Columns.Clear();
            ds = ot.GetTelefonoByGamma(comboBox1.Text);
            bs.DataSource = ds.Tables[0];
            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();
            dataGridView1.ReadOnly = true;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1_Clases
{
    public partial class ListaProfesores : Form
    {
        public ListaProfesores()
        {
            InitializeComponent();
        }
        private void ListaProfesores_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Datos.Profesores;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea cancelar? ", "Confirmar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Close();

        }
    }
}

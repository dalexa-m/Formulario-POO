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
    public partial class ListaCentros : Form
    {
       

        public ListaCentros()
        {
            InitializeComponent();
        }
        private void ListaCentros_Load(object sender, EventArgs e)
        {


            // Verificar si hay datos previamente guardados en el formulario anterior
            /* if (Datos.Centros != null && Datos.Centros.Count > 0)
             {
                 if (dataGridView1.Columns.Count == 0)
                 {
                    // dataGridView1.DataSource = Datos.Centros;
                     dataGridView1.Columns.Add("Nombre "," Nombre");
                     dataGridView1.Columns["Nombre"].DataPropertyName = "Nombre";
                 }

                 // Agregar los centros al DataGridView

             }*/
            dataGridView1.DataSource = Datos.Centros;
              
                

        }
        private List<Centro> ObtenerCentros()
        {
            // Aquí deberías tener la lógica para obtener los centros desde la lista o fuente de datos correspondiente
            // Por ejemplo, si tienes una lista llamada "listaCentros", simplemente la devuelves
            return Datos.Centros;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea cancelar? ","Confirmar",MessageBoxButtons.YesNo);  
            if(result == DialogResult.Yes)
                Close();    
          

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

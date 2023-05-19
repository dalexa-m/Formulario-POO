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
    public partial class FrmCentro : Form
    {
         
        public FrmCentro()
        {
            InitializeComponent();
        }

        private void FrmCentro_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            // Crear una nueva instancia de la entidad "Centro"
            Centro nuevoCentro = new Centro();
            nuevoCentro.Nombre = txtName.Text;
            nuevoCentro.Dir = txtDireccion.Text;
            nuevoCentro.Telf = txtTelefono.Text;
            nuevoCentro.Email = txtEmail.Text;

            // Agregar la nueva entidad a la lista
            Datos.Centros.Add(nuevoCentro);

            // Limpiar los campos de texto después de guardar
            txtName.Text = "";
            txtDireccion.Text = "";
            MessageBox.Show("El centro se ha guardado correctamente.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtDireccion.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";

            DialogResult result = MessageBox.Show("Esta seguro que desea cancelar? ", "Confirmar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

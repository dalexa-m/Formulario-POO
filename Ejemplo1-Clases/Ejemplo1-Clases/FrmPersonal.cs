using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Ejemplo1_Clases
{
    public partial class FrmPersonal : Form
    {
        public FrmPersonal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personal nuevoPersonal = new Personal();
            nuevoPersonal.Id = txtId.Text;
            nuevoPersonal.Nombre = txtName.Text;
            nuevoPersonal.Direccion = txtDireccion.Text;
            nuevoPersonal.Telf = txtTelefono.Text;
            nuevoPersonal.Email = txtEmail.Text;
            nuevoPersonal.Unidad = txtUnidad.Text;
            nuevoPersonal.Categoria = txtCategoria.Text;
            



            // Agregar la nueva entidad a la lista
            Datos.Personales.Add(nuevoPersonal);
            // Limpiar los campos de texto después de guardar
            txtId.Text = "";
            txtName.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtCategoria.Text = "";
            txtUnidad.Text = "";
            MessageBox.Show("El personal se ha guardado correctamente.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtCategoria.Text = "";
            txtUnidad.Text = "";
            DialogResult result = MessageBox.Show("Esta seguro que desea cancelar? ", "Confirmar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Close();
        }
    }
}

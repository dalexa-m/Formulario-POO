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
    public partial class FrmProfesor : Form
    {
        public FrmProfesor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            // Crear una nueva instancia de la entidad "Centro"
            Profesor nuevoProfesor = new Profesor();
            nuevoProfesor.Id = txtId.Text;
            nuevoProfesor.Nombre = txtName.Text;
            nuevoProfesor.Direccion = txtDireccion.Text;
            nuevoProfesor.Telf = txtTelefono.Text;
            nuevoProfesor.Email = txtEmail.Text;
            nuevoProfesor.Salario = double.Parse(txtSalario.Text);

            nuevoProfesor.INSS = txtINSS.Text;

            // Agregar la nueva entidad a la lista
            Datos.Profesores.Add(nuevoProfesor);

            // Limpiar los campos de texto después de guardar
            txtName.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtINSS.Text = "";
            txtSalario.Text = "";
            MessageBox.Show("El Profesor se ha guardado correctamente.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtINSS.Text = "";
            txtSalario.Text = "";
            DialogResult result = MessageBox.Show("Esta seguro que desea cancelar? ", "Confirmar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Close();
        }
    }
}

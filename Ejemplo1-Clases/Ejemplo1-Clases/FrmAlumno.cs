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
    public partial class FrmAlumno : Form
    {
        public FrmAlumno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alumno nuevoAlumno = new Alumno();
            nuevoAlumno.Id = txtId.Text;
            nuevoAlumno.Nombre = txtName.Text;
            nuevoAlumno.Direccion = txtDireccion.Text;
            nuevoAlumno.Telf = txtTelefono.Text;
            nuevoAlumno.Email = txtEmail.Text;
            nuevoAlumno.Exp = txtExp.Text;
            nuevoAlumno.Tiulacion = txtTitulacion.Text;
            // nuevoProfesor.Salario = double.Parse(txtSalario.Text);


            
            // Agregar la nueva entidad a la lista
            Datos.Alumnos.Add(nuevoAlumno);

            // Limpiar los campos de texto después de guardar
            txtId.Text = "";
            txtName.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtTitulacion.Text = "";
            txtExp.Text = "";
            MessageBox.Show("El Alumno se ha guardado correctamente.");
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
            txtTitulacion.Text = "";
            txtExp.Text = "";
            DialogResult result = MessageBox.Show("Esta seguro que desea cancelar? ", "Confirmar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Close();
        }
    }
}

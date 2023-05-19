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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Form agregarForm = new Form();
            FrmCentro agregarForm = new FrmCentro();
            // Mostrar el formulario de agregar
            agregarForm.ShowDialog();
        }

        private void listaDeCentroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaCentros agregarForm = new ListaCentros();

            agregarForm.ShowDialog();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Form agregarForm = new Form();
            FrmProfesor agregarForm = new FrmProfesor();
            // Mostrar el formulario de agregar
            agregarForm.ShowDialog();
        }

        private void listaDeProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaProfesores agregarForm = new ListaProfesores();
            agregarForm.ShowDialog();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmAlumno agregarForm = new FrmAlumno();
            agregarForm.ShowDialog();
        }

        private void listaDeEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaAlumnos agregarForm = new ListaAlumnos();
            agregarForm.ShowDialog();
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmPersonal agregarForm = new FrmPersonal();
            agregarForm.ShowDialog();
        }

        private void listaDePersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaPersonal agregarForm = new ListaPersonal();
            agregarForm.ShowDialog();
        }
    }
}

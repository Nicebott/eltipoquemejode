using System;
using System.Windows.Forms;

namespace INF512_FinalProject
{
    public partial class MainForm : Form
    {
        private readonly RepositorioEstudiantes repositorio;

        public MainForm()
        {
            InitializeComponent();
            repositorio = new RepositorioEstudiantes();
            CargarEstudiantes();
        }

        private void CargarEstudiantes()
        {
            var estudiantes = repositorio.CargarEstudiantes();

        }

        private void AgregarEstudiante(Estudiante estudiante)
        {
            try
            {
                repositorio.GuardarEstudiante(estudiante);
                CargarEstudiantes();
                MessageBox.Show("Estudiante guardado exitosamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar estudiante: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Estatu_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
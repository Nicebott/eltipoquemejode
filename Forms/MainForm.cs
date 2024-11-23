using System;
using System.Windows.Forms;
using GradeManagementSystem.Data; // Referencia a la capa de datos
using GradeManagementSystem.Models; // Referencia a los modelos de datos

namespace GradeManagementSystem.Forms
{
    // Representa la ventana principal de la aplicación de gestión de calificaciones
    public partial class MainForm : Form
    {
        // Campo privado de solo lectura para el repositorio de estudiantes (Encapsulamiento)
        private readonly IStudentRepository _repository;

        // Constructor de la clase MainForm
        public MainForm()
        {
            InitializeComponent(); // Inicializa los componentes del formulario
            _repository = new FileStudentRepository(); // Inicializa el repositorio
            LoadStudents(); // Carga los estudiantes al iniciar
        }

        // Método para cargar la lista de estudiantes en el DataGridView
        private void LoadStudents()
        {
            dgvStudents.DataSource = null; // Limpia la fuente de datos
            dgvStudents.DataSource = _repository.GetAllStudents(); // Asigna la lista de estudiantes
        }

        // Evento que se ejecuta al hacer clic en el botón "Agregar"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Abre el formulario de estudiantes en modo "Agregar"
            using (var form = new StudentForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _repository.AddStudent(form.Student); // Agrega el estudiante al repositorio
                        LoadStudents(); // Recarga la lista de estudiantes
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Muestra error
                    }
                }
            }
        }

        // Evento para editar el estudiante seleccionado
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                var student = (Student)dgvStudents.SelectedRows[0].DataBoundItem; // Obtiene el estudiante seleccionado
                using (var form = new StudentForm(student)) // Abre el formulario en modo "Editar"
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        _repository.UpdateStudent(form.Student); // Actualiza el estudiante
                        LoadStudents(); // Recarga la lista de estudiantes
                    }
                }
            }
        }

        // Evento para eliminar el estudiante seleccionado
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                var student = (Student)dgvStudents.SelectedRows[0].DataBoundItem; // Obtiene el estudiante seleccionado
                if (MessageBox.Show("¿Está seguro de eliminar este estudiante?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _repository.DeleteStudent(student.StudentId); // Elimina el estudiante
                    LoadStudents(); // Recarga la lista de estudiantes
                }
            }
        }

        // Evento para mostrar detalles del estudiante seleccionado
        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                var student = (Student)dgvStudents.SelectedRows[0].DataBoundItem; // Obtiene el estudiante seleccionado
                using (var form = new DetailsForm(student)) // Abre el formulario de detalles
                {
                    form.ShowDialog(); // Muestra los detalles del estudiante
                }
            }
        }
    }
}

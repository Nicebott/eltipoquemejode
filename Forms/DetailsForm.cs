using System;
using System.Windows.Forms;
using GradeManagementSystem.Models;

namespace GradeManagementSystem.Forms
{
    // Herencia: detailsform hereda de Form (1er pilar - Herencia)
    public partial class DetailsForm : Form 
    {
        private readonly Student _student;

        public DetailsForm(Student student)
        {
            InitializeComponent();
            _student = student;
            LoadDetails();
        }

        private void LoadDetails()
        {
            lblStudentInfo.Text = $"Matrícula: {_student.StudentId}\nNombre: {_student.FirstName} {_student.LastName}";
            lblExamsScore.Text = $"Calificación de Exámenes (60%): {_student.CalculateExamsScore():N2}";
            lblPracticeScore.Text = $"Calificación de Prácticas (40%): {_student.CalculatePracticeScore():N2}";
            lblFinalGrade.Text = $"Calificación Final: {_student.CalculateFinalGrade():N2}";
            lblStatus.Text = $"Estatus: {_student.GetStatus()}";
        }
    }
}
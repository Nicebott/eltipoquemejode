using System;
using System.Windows.Forms;
using GradeManagementSystem.Models;

namespace GradeManagementSystem.Forms
{
    public partial class StudentForm : Form
    {
        public Student Student { get; private set; }

        public StudentForm(Student student = null)
        {
            InitializeComponent();
            if (student != null)
            {
                Student = student;
                LoadStudentData();
            }
        }

        private void LoadStudentData()
        {
            txtStudentId.Text = Student.StudentId;
            txtFirstName.Text = Student.FirstName;
            txtLastName.Text = Student.LastName;
            numFirstExam.Value = (decimal)Student.FirstExam;
            numSecondExam.Value = (decimal)Student.SecondExam;
            numFinalExam.Value = (decimal)Student.FinalExam;
            numPractice1.Value = (decimal)Student.Practice1;
            numPractice2.Value = (decimal)Student.Practice2;
            numPractice3.Value = (decimal)Student.Practice3;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Student = new Student
                {
                    StudentId = txtStudentId.Text,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    FirstExam = numFirstExam.Value,
                    SecondExam = numSecondExam.Value,
                    FinalExam = numFinalExam.Value,
                    Practice1 = numPractice1.Value,
                    Practice2 = numPractice2.Value,
                    Practice3 = numPractice3.Value
                };

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtStudentId.Text))
            {
                MessageBox.Show("La matrícula es requerida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("El nombre es requerido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("El apellido es requerido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
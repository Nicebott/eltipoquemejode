using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System;

namespace GradeManagementSystem.Forms
{
    // Herencia: StudentForm hereda de Form (1er pilar - Herencia)
    partial class StudentForm
    {
        // Encapsulamiento: Campos privados para los controles (2do pilar - Encapsulamiento)
        private System.ComponentModel.IContainer components = null;
        private TextBox txtStudentId;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private NumericUpDown numFirstExam;
        private NumericUpDown numSecondExam;
        private NumericUpDown numFinalExam;
        private NumericUpDown numPractice1;
        private NumericUpDown numPractice2;
        private NumericUpDown numPractice3;
        private Button btnSave;
        private Button btnCancel;
        private Panel headerPanel;
        private Label lblHeader;

        // Polimorfismo: Sobrescribe el método Dispose de Form (3er pilar - Polimorfismo)
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Método privado para inicializar los componentes del formulario
        private void InitializeComponent()
        {
            // Inicialización del contenedor de componentes
            this.components = new System.ComponentModel.Container();

            // Configuración del panel de encabezado
            this.headerPanel = new Panel();
            this.headerPanel.BackColor = Color.FromArgb(52, 73, 94);
            this.headerPanel.Dock = DockStyle.Top;
            this.headerPanel.Height = 60;

            // Configuración de la etiqueta del encabezado
            this.lblHeader = new Label();
            this.lblHeader.Text = "Datos del Estudiante";
            this.lblHeader.ForeColor = Color.White;
            this.lblHeader.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            this.lblHeader.Location = new Point(20, 15);
            this.lblHeader.AutoSize = true;
            this.headerPanel.Controls.Add(this.lblHeader);

            // Abstracción: Creación de estilos reutilizables (4to pilar - Abstracción)
            // Estilo personalizado para TextBox
            var textBoxStyle = new Action<TextBox>((textBox) => {
                textBox.Font = new Font("Segoe UI", 11);
                textBox.BorderStyle = BorderStyle.FixedSingle;
                textBox.Size = new Size(250, 30);
            });

            // Estilo personalizado para NumericUpDown
            var numericStyle = new Action<NumericUpDown>((numeric) => {
                numeric.Font = new Font("Segoe UI", 11);
                numeric.BorderStyle = BorderStyle.FixedSingle;
                numeric.Size = new Size(120, 30);
                numeric.Minimum = 10;          // Valor mínimo permitido
                numeric.Maximum = 100;         // Valor máximo permitido
                numeric.DecimalPlaces = 2;     // Decimales permitidos
                numeric.Value = 10;            // Valor inicial
            });

            // Estilo personalizado para Label
            var labelStyle = new Action<Label>((label) => {
                label.Font = new Font("Segoe UI", 11);
                label.ForeColor = Color.FromArgb(52, 73, 94);
                label.AutoSize = true;
            });

            // Sección de información del estudiante
            var lblStudentId = new Label { Text = "Matrícula:", Location = new Point(30, 80) };
            var lblFirstName = new Label { Text = "Nombre:", Location = new Point(30, 130) };
            var lblLastName = new Label { Text = "Apellido:", Location = new Point(30, 180) };

            this.txtStudentId = new TextBox { Location = new Point(30, 105) };
            this.txtFirstName = new TextBox { Location = new Point(30, 155) };
            this.txtLastName = new TextBox { Location = new Point(30, 205) };

            // Validación para permitir solo números en la matrícula
            this.txtStudentId.KeyPress += new KeyPressEventHandler((sender, e) => {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            });

            // Aplicación de estilos a las etiquetas y campos de texto
            new[] { lblStudentId, lblFirstName, lblLastName }.ToList().ForEach(labelStyle);
            new[] { txtStudentId, txtFirstName, txtLastName }.ToList().ForEach(textBoxStyle);

            // Sección de exámenes
            var lblExams = new Label
            {
                Text = "Calificaciones de Exámenes",
                Location = new Point(30, 255),
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(52, 73, 94)
            };

            var lblFirstExam = new Label { Text = "Primer Parcial:", Location = new Point(30, 290) };
            var lblSecondExam = new Label { Text = "Segundo Parcial:", Location = new Point(30, 340) };
            var lblFinalExam = new Label { Text = "Examen Final:", Location = new Point(30, 390) };

            this.numFirstExam = new NumericUpDown { Location = new Point(160, 290) };
            this.numSecondExam = new NumericUpDown { Location = new Point(160, 340) };
            this.numFinalExam = new NumericUpDown { Location = new Point(160, 390) };

            // Aplicación de estilos a las etiquetas y campos numéricos de exámenes
            new[] { lblFirstExam, lblSecondExam, lblFinalExam }.ToList().ForEach(labelStyle);
            new[] { numFirstExam, numSecondExam, numFinalExam }.ToList().ForEach(numericStyle);

            // Sección de prácticas
            var lblPractices = new Label
            {
                Text = "Calificaciones de Prácticas",
                Location = new Point(330, 255),
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(52, 73, 94)
            };

            var lblPractice1 = new Label { Text = "Práctica 1:", Location = new Point(330, 290) };
            var lblPractice2 = new Label { Text = "Práctica 2:", Location = new Point(330, 340) };
            var lblPractice3 = new Label { Text = "Práctica 3:", Location = new Point(330, 390) };

            this.numPractice1 = new NumericUpDown { Location = new Point(460, 290) };
            this.numPractice2 = new NumericUpDown { Location = new Point(460, 340) };
            this.numPractice3 = new NumericUpDown { Location = new Point(460, 390) };

            // Aplicación de estilos a las etiquetas y campos numéricos de prácticas
            new[] { lblPractice1, lblPractice2, lblPractice3 }.ToList().ForEach(labelStyle);
            new[] { numPractice1, numPractice2, numPractice3 }.ToList().ForEach(numericStyle);

            // Configuración de botones
            this.btnSave = new Button
            {
                Text = "Guardar",
                Location = new Point(330, 460),
                Size = new Size(120, 40),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(46, 204, 113),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11),
                Cursor = Cursors.Hand
            };
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel = new Button
            {
                Text = "Cancelar",
                Location = new Point(460, 460),
                Size = new Size(120, 40),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(231, 76, 60),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11),
                Cursor = Cursors.Hand,
                DialogResult = DialogResult.Cancel
            };

            // Configuración del formulario
            this.ClientSize = new Size(620, 530);
            this.Controls.AddRange(new Control[] {
                headerPanel,
                lblStudentId, lblFirstName, lblLastName,
                txtStudentId, txtFirstName, txtLastName,
                lblExams, lblFirstExam, lblSecondExam, lblFinalExam,
                numFirstExam, numSecondExam, numFinalExam,
                lblPractices, lblPractice1, lblPractice2, lblPractice3,
                numPractice1, numPractice2, numPractice3,
                btnSave, btnCancel
            });

            // Propiedades del formulario
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Gestión de Estudiante";
            this.BackColor = Color.White;
            this.AcceptButton = btnSave;
            this.CancelButton = btnCancel;

            // Inicialización de controles numéricos
            var numericControls = new[] { numFirstExam, numSecondExam, numFinalExam, numPractice1, numPractice2, numPractice3 };
            foreach (var control in numericControls)
            {
                ((System.ComponentModel.ISupportInitialize)(control)).EndInit();
            }
        }
    }
}
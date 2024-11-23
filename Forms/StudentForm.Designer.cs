using System.Windows.Forms;
using System.Drawing;
using System;

namespace GradeManagementSystem.Forms
{
    partial class StudentForm
    {
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
        private Panel panelTop;
        private Label lblHeader;
        private TableLayoutPanel mainLayout;
        private GroupBox groupPersonal;
        private GroupBox groupExams;
        private GroupBox groupPractices;
        private Panel panelButtons;
        private Label lblStudentId;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblFirstExam;
        private Label lblSecondExam;
        private Label lblFinalExam;
        private Label lblPractice1;
        private Label lblPractice2;
        private Label lblPractice3;
        private FlowLayoutPanel flowButtons;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // Layout Principal
            this.mainLayout = new TableLayoutPanel();
            this.mainLayout.Dock = DockStyle.Fill;
            this.mainLayout.RowCount = 4;
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            this.mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            this.mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            this.mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            this.mainLayout.Padding = new Padding(10);

            // Panel Superior
            this.panelTop = new Panel();
            this.panelTop.Dock = DockStyle.Fill;
            this.panelTop.BackColor = Color.FromArgb(0, 70, 140);
            this.panelTop.Margin = new Padding(0);

            this.lblHeader = new Label();
            this.lblHeader.Text = "Registro de Estudiante";
            this.lblHeader.ForeColor = Color.White;
            this.lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblHeader.Dock = DockStyle.Fill;
            this.lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            this.panelTop.Controls.Add(this.lblHeader);

            // Grupo de Datos Personales
            this.groupPersonal = new GroupBox();
            this.groupPersonal.Text = "Datos Personales";
            this.groupPersonal.Dock = DockStyle.Fill;
            this.groupPersonal.Font = new Font("Segoe UI", 9F);
            this.groupPersonal.Padding = new Padding(10);
            this.groupPersonal.Margin = new Padding(0, 5, 0, 5);

            var personalLayout = new TableLayoutPanel();
            personalLayout.Dock = DockStyle.Fill;
            personalLayout.ColumnCount = 6;
            personalLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            personalLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            personalLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            personalLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            personalLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            personalLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));

            // Campos de Datos Personales
            this.lblStudentId = CreateLabel("Matrícula:");
            this.lblFirstName = CreateLabel("Nombre:");
            this.lblLastName = CreateLabel("Apellido:");

            this.txtStudentId = CreateTextBox();
            this.txtFirstName = CreateTextBox();
            this.txtLastName = CreateTextBox();

            personalLayout.Controls.AddRange(new Control[] {
                lblStudentId, txtStudentId,
                lblFirstName, txtFirstName,
                lblLastName, txtLastName
            });
            this.groupPersonal.Controls.Add(personalLayout);

            // TableLayoutPanel para Exámenes y Prácticas
            var gradesLayout = new TableLayoutPanel();
            gradesLayout.Dock = DockStyle.Fill;
            gradesLayout.ColumnCount = 2;
            gradesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            gradesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            gradesLayout.Margin = new Padding(0);

            // Grupo de Exámenes
            this.groupExams = new GroupBox();
            this.groupExams.Text = "Calificaciones de Exámenes";
            this.groupExams.Dock = DockStyle.Fill;
            this.groupExams.Font = new Font("Segoe UI", 9F);
            this.groupExams.Padding = new Padding(10);
            this.groupExams.Margin = new Padding(0, 0, 5, 0);

            var examsLayout = new TableLayoutPanel();
            examsLayout.Dock = DockStyle.Fill;
            examsLayout.RowCount = 3;
            examsLayout.ColumnCount = 2;
            examsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            examsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            // Campos de Exámenes
            this.lblFirstExam = CreateLabel("Primer Parcial:");
            this.lblSecondExam = CreateLabel("Segundo Parcial:");
            this.lblFinalExam = CreateLabel("Examen Final:");

            this.numFirstExam = CreateNumericUpDown();
            this.numSecondExam = CreateNumericUpDown();
            this.numFinalExam = CreateNumericUpDown();

            examsLayout.Controls.AddRange(new Control[] {
                lblFirstExam, numFirstExam,
                lblSecondExam, numSecondExam,
                lblFinalExam, numFinalExam
            });
            this.groupExams.Controls.Add(examsLayout);

            // Grupo de Prácticas
            this.groupPractices = new GroupBox();
            this.groupPractices.Text = "Calificaciones de Prácticas";
            this.groupPractices.Dock = DockStyle.Fill;
            this.groupPractices.Font = new Font("Segoe UI", 9F);
            this.groupPractices.Padding = new Padding(10);
            this.groupPractices.Margin = new Padding(5, 0, 0, 0);

            var practicesLayout = new TableLayoutPanel();
            practicesLayout.Dock = DockStyle.Fill;
            practicesLayout.RowCount = 3;
            practicesLayout.ColumnCount = 2;
            practicesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            practicesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            // Campos de Prácticas
            this.lblPractice1 = CreateLabel("Práctica 1:");
            this.lblPractice2 = CreateLabel("Práctica 2:");
            this.lblPractice3 = CreateLabel("Práctica 3:");

            this.numPractice1 = CreateNumericUpDown();
            this.numPractice2 = CreateNumericUpDown();
            this.numPractice3 = CreateNumericUpDown();

            practicesLayout.Controls.AddRange(new Control[] {
                lblPractice1, numPractice1,
                lblPractice2, numPractice2,
                lblPractice3, numPractice3
            });
            this.groupPractices.Controls.Add(practicesLayout);

            // Agregar grupos al layout de calificaciones
            gradesLayout.Controls.Add(this.groupExams, 0, 0);
            gradesLayout.Controls.Add(this.groupPractices, 1, 0);

            // Panel de Botones
            this.panelButtons = new Panel();
            this.panelButtons.Dock = DockStyle.Fill;
            this.panelButtons.BackColor = SystemColors.Control;
            this.panelButtons.Margin = new Padding(0);

            // FlowLayoutPanel para Botones
            this.flowButtons = new FlowLayoutPanel();
            this.flowButtons.Dock = DockStyle.Right;
            this.flowButtons.FlowDirection = FlowDirection.LeftToRight;
            this.flowButtons.WrapContents = false;
            this.flowButtons.AutoSize = true;
            this.flowButtons.Padding = new Padding(5);

            // Botones
            this.btnCancel = new Button();
            this.btnCancel.Text = "❌ Cancelar";
            this.btnCancel.Size = new Size(120, 40);
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderColor = Color.FromArgb(232, 17, 35);
            this.btnCancel.ForeColor = Color.FromArgb(232, 17, 35);
            this.btnCancel.Font = new Font("Segoe UI", 9F);
            this.btnCancel.DialogResult = DialogResult.Cancel;
            this.btnCancel.Margin = new Padding(5);

            this.btnSave = new Button();
            this.btnSave.Text = "💾 Guardar";
            this.btnSave.Size = new Size(120, 40);
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderColor = Color.FromArgb(0, 120, 215);
            this.btnSave.ForeColor = Color.FromArgb(0, 120, 215);
            this.btnSave.Font = new Font("Segoe UI", 9F);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.Margin = new Padding(5);

            this.flowButtons.Controls.AddRange(new Control[] { btnCancel, btnSave });
            this.panelButtons.Controls.Add(this.flowButtons);

            // Agregar controles al layout principal
            this.mainLayout.Controls.Add(this.panelTop, 0, 0);
            this.mainLayout.Controls.Add(this.groupPersonal, 0, 1);
            this.mainLayout.Controls.Add(gradesLayout, 0, 2);
            this.mainLayout.Controls.Add(this.panelButtons, 0, 3);

            // Form
            this.ClientSize = new Size(800, 600);
            this.Controls.Add(this.mainLayout);
            this.MinimumSize = new Size(800, 600);
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Gestión de Estudiante";
            this.AcceptButton = btnSave;
            this.CancelButton = btnCancel;

            // Manejar el evento Resize del formulario
            this.Resize += new System.EventHandler(this.StudentForm_Resize);
        }

        private Label CreateLabel(string text)
        {
            return new Label
            {
                Text = text,
                AutoSize = true,
                Font = new Font("Segoe UI", 9F),
                Anchor = AnchorStyles.Left | AnchorStyles.Right,
                TextAlign = ContentAlignment.MiddleLeft
            };
        }

        private TextBox CreateTextBox()
        {
            return new TextBox
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 9F),
                Margin = new Padding(0, 3, 10, 3)
            };
        }

        private NumericUpDown CreateNumericUpDown()
        {
            return new NumericUpDown
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 9F),
                Minimum = 0,
                Maximum = 100,
                DecimalPlaces = 2,
                Margin = new Padding(0, 3, 10, 3)
            };
        }

        private void StudentForm_Resize(object sender, EventArgs e)
        {
            // Ajustar el espacio entre los botones según el tamaño de la ventana
            flowButtons.Padding = new Padding(Math.Max(5, (panelButtons.Width - 260) / 2), 5, 5, 5);
        }
    }
}
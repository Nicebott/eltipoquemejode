using System.Windows.Forms;
using System.Drawing;

namespace GradeManagementSystem.Forms
{
    partial class DetailsForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblStudentInfo;
        private Label lblExamsScore;
        private Label lblPracticeScore;
        private Label lblFinalGrade;
        private Label lblStatus;
        private Button btnClose;
        private Panel headerPanel;
        private Panel contentPanel;

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

            // Header Panel
            this.headerPanel = new Panel
            {
                BackColor = Color.FromArgb(155, 89, 182),
                Dock = DockStyle.Top,
                Height = 60
            };

            var lblHeader = new Label
            {
                Text = "Detalle de Calificaciones",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.headerPanel.Controls.Add(lblHeader);

            // Content Panel
            this.contentPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(20)
            };

            // Student Info
            this.lblStudentInfo = new Label
            {
                AutoSize = false,
                Size = new Size(400, 50),
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.FromArgb(52, 73, 94),
                TextAlign = ContentAlignment.MiddleLeft
            };

            // Scores
            this.lblExamsScore = CreateScoreLabel(90);
            this.lblPracticeScore = CreateScoreLabel(140);

            // Final Grade Panel
            var finalGradePanel = new Panel
            {
                Size = new Size(400, 100),
                Location = new Point(0, 190),
                BackColor = Color.FromArgb(236, 240, 241)
            };

            this.lblFinalGrade = new Label
            {
                AutoSize = false,
                Size = new Size(400, 40),
                Location = new Point(0, 10),
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                ForeColor = Color.FromArgb(52, 73, 94),
                TextAlign = ContentAlignment.MiddleCenter
            };

            this.lblStatus = new Label
            {
                AutoSize = false,
                Size = new Size(400, 40),
                Location = new Point(0, 50),
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };

            finalGradePanel.Controls.AddRange(new Control[] {
                this.lblFinalGrade,
                this.lblStatus
            });

            // Close Button
            this.btnClose = new Button
            {
                Text = "Cerrar",
                Size = new Size(120, 40),
                Location = new Point(140, 310),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(52, 152, 219),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                DialogResult = DialogResult.OK
            };

            // Add controls to content panel
            this.contentPanel.Controls.AddRange(new Control[] {
                this.lblStudentInfo,
                this.lblExamsScore,
                this.lblPracticeScore,
                finalGradePanel,
                this.btnClose
            });

            // Form
            this.ClientSize = new Size(440, 420);
            this.Controls.AddRange(new Control[] {
                this.contentPanel,
                this.headerPanel
            });

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Detalle de Calificaciones";
            this.AcceptButton = btnClose;
        }

        private Label CreateScoreLabel(int yPosition)
        {
            return new Label
            {
                AutoSize = false,
                Location = new Point(0, yPosition),
                Size = new Size(400, 30),
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.FromArgb(52, 73, 94),
                TextAlign = ContentAlignment.MiddleLeft
            };
        }
    }
}
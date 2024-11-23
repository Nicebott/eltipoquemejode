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
        private Panel panelTop;
        private Label lblHeader;
        private TableLayoutPanel tableMain;
        private GroupBox groupInfo;
        private GroupBox groupScores;
        private Panel panelStatus;

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

            // Panel Superior
            this.panelTop = new Panel();
            this.panelTop.Height = 60;
            this.panelTop.Dock = DockStyle.Top;
            this.panelTop.BackColor = Color.FromArgb(0, 70, 140);

            this.lblHeader = new Label();
            this.lblHeader.Text = "Detalle de Calificaciones";
            this.lblHeader.ForeColor = Color.White;
            this.lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblHeader.Dock = DockStyle.Fill;
            this.lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            this.panelTop.Controls.Add(this.lblHeader);

            // Layout Principal
            this.tableMain = new TableLayoutPanel();
            this.tableMain.Dock = DockStyle.Fill;
            this.tableMain.Padding = new Padding(20);
            this.tableMain.RowCount = 3;
            this.tableMain.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            this.tableMain.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            this.tableMain.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));

            // Grupo de Información
            this.groupInfo = new GroupBox();
            this.groupInfo.Text = "Información del Estudiante";
            this.groupInfo.Dock = DockStyle.Fill;
            this.groupInfo.Font = new Font("Segoe UI", 9F);
            this.groupInfo.Padding = new Padding(15);

            this.lblStudentInfo = new Label();
            this.lblStudentInfo.Dock = DockStyle.Fill;
            this.lblStudentInfo.Font = new Font("Segoe UI", 10F);
            this.lblStudentInfo.TextAlign = ContentAlignment.MiddleLeft;
            this.groupInfo.Controls.Add(this.lblStudentInfo);

            // Grupo de Calificaciones
            this.groupScores = new GroupBox();
            this.groupScores.Text = "Detalle de Calificaciones";
            this.groupScores.Dock = DockStyle.Fill;
            this.groupScores.Font = new Font("Segoe UI", 9F);
            this.groupScores.Padding = new Padding(15);

            var scoresLayout = new TableLayoutPanel();
            scoresLayout.Dock = DockStyle.Fill;
            scoresLayout.RowCount = 2;
            scoresLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            scoresLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            this.lblExamsScore = CreateScoreLabel();
            this.lblPracticeScore = CreateScoreLabel();

            scoresLayout.Controls.AddRange(new Control[] {
                this.lblExamsScore,
                this.lblPracticeScore
            });
            this.groupScores.Controls.Add(scoresLayout);

            // Panel de Estado Final
            this.panelStatus = new Panel();
            this.panelStatus.Dock = DockStyle.Fill;
            this.panelStatus.Padding = new Padding(15);
            this.panelStatus.BackColor = SystemColors.ControlLightLight;

            this.lblFinalGrade = new Label();
            this.lblFinalGrade.Dock = DockStyle.Top;
            this.lblFinalGrade.Height = 40;
            this.lblFinalGrade.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblFinalGrade.TextAlign = ContentAlignment.MiddleCenter;

            this.lblStatus = new Label();
            this.lblStatus.Dock = DockStyle.Fill;
            this.lblStatus.Font = new Font("Segoe UI", 12F);
            this.lblStatus.TextAlign = ContentAlignment.TopCenter;

            this.panelStatus.Controls.AddRange(new Control[] {
                this.lblFinalGrade,
                this.lblStatus
            });

            // Botón Cerrar
            this.btnClose = new Button();
            this.btnClose.Text = "✔️ Cerrar";
            this.btnClose.Size = new Size(120, 40);
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderColor = Color.FromArgb(0, 120, 215);
            this.btnClose.ForeColor = Color.FromArgb(0, 120, 215);
            this.btnClose.Font = new Font("Segoe UI", 9F);
            this.btnClose.DialogResult = DialogResult.OK;
            this.btnClose.Dock = DockStyle.Bottom;

            // Agregar controles al layout principal
            this.tableMain.Controls.AddRange(new Control[] {
                this.groupInfo,
                this.groupScores,
                this.panelStatus
            });

            // Form
            this.ClientSize = new Size(500, 600);
            this.Controls.AddRange(new Control[] {
                this.btnClose,
                this.tableMain,
                this.panelTop
            });
            this.MinimumSize = new Size(500, 600);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Detalle de Calificaciones";
            this.AcceptButton = btnClose;
        }

        private Label CreateScoreLabel()
        {
            return new Label
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10F),
                TextAlign = ContentAlignment.MiddleLeft
            };
        }
    }
}
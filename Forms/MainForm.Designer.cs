using System.Windows.Forms;
using System.Drawing;
using System;

namespace GradeManagementSystem.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvStudents;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnDetails;
        private Label lblTitle;
        private Panel panelTop;
        private Panel panelButtons;
        private GroupBox groupMain;
        private TableLayoutPanel mainLayout;
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
            this.mainLayout.RowCount = 3;
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            this.mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            this.mainLayout.Padding = new Padding(10);

            // Panel Superior
            this.panelTop = new Panel();
            this.panelTop.Dock = DockStyle.Fill;
            this.panelTop.BackColor = Color.FromArgb(0, 70, 140);
            this.panelTop.Margin = new Padding(0);

            // Título
            this.lblTitle = new Label();
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.Text = "Sistema de Gestión Académica";
            this.lblTitle.AutoSize = false;
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.lblTitle.Dock = DockStyle.Fill;
            this.lblTitle.ForeColor = Color.White;
            this.panelTop.Controls.Add(this.lblTitle);

            // Grupo Principal
            this.groupMain = new GroupBox();
            this.groupMain.Text = "Listado de Estudiantes";
            this.groupMain.Dock = DockStyle.Fill;
            this.groupMain.Font = new Font("Segoe UI", 9F);
            this.groupMain.Padding = new Padding(10);
            this.groupMain.Margin = new Padding(0, 5, 0, 5);

            // DataGridView
            this.dgvStudents = new DataGridView();
            this.dgvStudents.Dock = DockStyle.Fill;
            this.dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.BackgroundColor = SystemColors.Window;
            this.dgvStudents.BorderStyle = BorderStyle.None;
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStudents.EnableHeadersVisualStyles = false;
            this.dgvStudents.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            this.dgvStudents.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(0, 70, 140);
            this.dgvStudents.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9F);
            this.dgvStudents.ColumnHeadersHeight = 35;
            this.dgvStudents.RowTemplate.Height = 30;
            this.dgvStudents.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
            this.groupMain.Controls.Add(this.dgvStudents);

            // Panel de Botones
            this.panelButtons = new Panel();
            this.panelButtons.Dock = DockStyle.Fill;
            this.panelButtons.BackColor = SystemColors.Control;
            this.panelButtons.Margin = new Padding(0);

            // FlowLayoutPanel para Botones
            this.flowButtons = new FlowLayoutPanel();
            this.flowButtons.Dock = DockStyle.Fill;
            this.flowButtons.FlowDirection = FlowDirection.LeftToRight;
            this.flowButtons.WrapContents = false;
            this.flowButtons.AutoScroll = true;
            this.flowButtons.Padding = new Padding(5);

            // Botones
            this.btnAdd = CreateButton("Agregar Estudiante", "➕", Color.FromArgb(0, 120, 215));
            this.btnEdit = CreateButton("Editar", "✏️", Color.FromArgb(0, 153, 188));
            this.btnDelete = CreateButton("Eliminar", "❌", Color.FromArgb(232, 17, 35));
            this.btnDetails = CreateButton("Ver Detalles", "📋", Color.FromArgb(0, 99, 177));

            // Eventos de botones
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);

            // Agregar botones al FlowLayoutPanel
            this.flowButtons.Controls.AddRange(new Control[] { btnAdd, btnEdit, btnDelete, btnDetails });
            this.panelButtons.Controls.Add(this.flowButtons);

            // Agregar controles al layout principal
            this.mainLayout.Controls.Add(this.panelTop, 0, 0);
            this.mainLayout.Controls.Add(this.groupMain, 0, 1);
            this.mainLayout.Controls.Add(this.panelButtons, 0, 2);

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(900, 600);
            this.MinimumSize = new Size(800, 500);
            this.Controls.Add(this.mainLayout);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión Académica";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();

            // Manejar el evento Resize del formulario
            this.Resize += new System.EventHandler(this.MainForm_Resize);
        }

        private Button CreateButton(string text, string icon, Color color)
        {
            var btn = new Button();
            btn.Text = $"{icon} {text}";
            btn.Size = new Size(140, 40);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = color;
            btn.ForeColor = color;
            btn.Font = new Font("Segoe UI", 9F);
            btn.Margin = new Padding(5);
            btn.Cursor = Cursors.Hand;
            btn.UseVisualStyleBackColor = true;
            btn.AutoSize = true;
            btn.MinimumSize = new Size(140, 40);
            btn.MaximumSize = new Size(200, 40);
            btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            btn.MouseEnter += (s, e) => {
                btn.BackColor = color;
                btn.ForeColor = Color.White;
            };

            btn.MouseLeave += (s, e) => {
                btn.BackColor = SystemColors.Control;
                btn.ForeColor = color;
            };

            return btn;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            // Ajustar el ancho de los botones según el tamaño de la ventana
            int availableWidth = flowButtons.ClientSize.Width - flowButtons.Padding.Horizontal;
            int buttonCount = flowButtons.Controls.Count;
            int buttonWidth = Math.Max(140, (availableWidth - (buttonCount * flowButtons.Padding.Horizontal)) / buttonCount);

            foreach (Control control in flowButtons.Controls)
            {
                if (control is Button button)
                {
                    button.Width = Math.Min(200, buttonWidth);
                }
            }
        }
    }
}
namespace ReporteCalificaciones
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNombreYApellido = new System.Windows.Forms.TextBox();
            this.txtParcial1 = new System.Windows.Forms.TextBox();
            this.txtParcial2 = new System.Windows.Forms.TextBox();
            this.txtExamenFinal = new System.Windows.Forms.TextBox();
            this.txtPractica1 = new System.Windows.Forms.TextBox();
            this.txtPractica2 = new System.Windows.Forms.TextBox();
            this.txtPracticaFinal = new System.Windows.Forms.TextBox();
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "REPORTE DE CALIFICACIONES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parcial 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parcial 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Examen Final:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Practica 1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Practica 2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Practica Final:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "CALIFICACIONES";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(373, 144);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(373, 233);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 9;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Matricula:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(264, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Nombre:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(71, 50);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 12;
            // 
            // txtNombreYApellido
            // 
            this.txtNombreYApellido.Location = new System.Drawing.Point(317, 53);
            this.txtNombreYApellido.Name = "txtNombreYApellido";
            this.txtNombreYApellido.Size = new System.Drawing.Size(155, 20);
            this.txtNombreYApellido.TabIndex = 13;
            // 
            // txtParcial1
            // 
            this.txtParcial1.Location = new System.Drawing.Point(71, 147);
            this.txtParcial1.Name = "txtParcial1";
            this.txtParcial1.Size = new System.Drawing.Size(42, 20);
            this.txtParcial1.TabIndex = 14;
            // 
            // txtParcial2
            // 
            this.txtParcial2.Location = new System.Drawing.Point(71, 191);
            this.txtParcial2.Name = "txtParcial2";
            this.txtParcial2.Size = new System.Drawing.Size(42, 20);
            this.txtParcial2.TabIndex = 15;
            // 
            // txtExamenFinal
            // 
            this.txtExamenFinal.Location = new System.Drawing.Point(91, 240);
            this.txtExamenFinal.Name = "txtExamenFinal";
            this.txtExamenFinal.Size = new System.Drawing.Size(42, 20);
            this.txtExamenFinal.TabIndex = 16;
            // 
            // txtPractica1
            // 
            this.txtPractica1.Location = new System.Drawing.Point(85, 281);
            this.txtPractica1.Name = "txtPractica1";
            this.txtPractica1.Size = new System.Drawing.Size(48, 20);
            this.txtPractica1.TabIndex = 17;
            // 
            // txtPractica2
            // 
            this.txtPractica2.Location = new System.Drawing.Point(85, 320);
            this.txtPractica2.Name = "txtPractica2";
            this.txtPractica2.Size = new System.Drawing.Size(48, 20);
            this.txtPractica2.TabIndex = 18;
            // 
            // txtPracticaFinal
            // 
            this.txtPracticaFinal.Location = new System.Drawing.Point(91, 356);
            this.txtPracticaFinal.Name = "txtPracticaFinal";
            this.txtPracticaFinal.Size = new System.Drawing.Size(42, 20);
            this.txtPracticaFinal.TabIndex = 19;
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.AllowUserToOrderColumns = true;
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvEstudiantes.Location = new System.Drawing.Point(454, 110);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvEstudiantes.Size = new System.Drawing.Size(350, 178);
            this.dgvEstudiantes.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvEstudiantes);
            this.Controls.Add(this.txtPracticaFinal);
            this.Controls.Add(this.txtPractica2);
            this.Controls.Add(this.txtPractica1);
            this.Controls.Add(this.txtExamenFinal);
            this.Controls.Add(this.txtParcial2);
            this.Controls.Add(this.txtParcial1);
            this.Controls.Add(this.txtNombreYApellido);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNombreYApellido;
        private System.Windows.Forms.TextBox txtParcial1;
        private System.Windows.Forms.TextBox txtParcial2;
        private System.Windows.Forms.TextBox txtExamenFinal;
        private System.Windows.Forms.TextBox txtPractica1;
        private System.Windows.Forms.TextBox txtPractica2;
        private System.Windows.Forms.TextBox txtPracticaFinal;
        private System.Windows.Forms.DataGridView dgvEstudiantes;
    }
}


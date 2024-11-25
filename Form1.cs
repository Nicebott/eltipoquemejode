using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ReporteCalificaciones
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class Form1 : Form
    {
        private List<Estudiante> estudiantes = new List<Estudiante>();
        // Ruta donde se guardará el archivo de texto
        private readonly string rutaArchivo = Path.Combine(Application.StartupPath, "Estudiantes.txt");

        public Form1()
        {
            InitializeComponent();
        }

        // Evento para guardar los datos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los datos del formulario
                string nombreApellido = txtNombreYApellido.Text;
                string[] nombreApellidoSplit = nombreApellido.Split(' ');

                if (nombreApellidoSplit.Length < 2)
                {
                    MessageBox.Show("Por favor, ingrese tanto el nombre como el apellido.");
                    return;
                }

                string nombre = nombreApellidoSplit[0];  // El primer valor es el nombre
                string apellido = nombreApellidoSplit[1];  // El segundo valor es el apellido

                string matricula = txtMatricula.Text;
                int parcial1 = int.Parse(txtParcial1.Text);
                int parcial2 = int.Parse(txtParcial2.Text);
                int examenFinal = int.Parse(txtExamenFinal.Text);
                int practica1 = int.Parse(txtPractica1.Text);
                int practica2 = int.Parse(txtPractica2.Text);
                int practicaFinal = int.Parse(txtPracticaFinal.Text);

                // Crear un objeto Estudiante
                Estudiante estudiante = new Estudiante(nombre, apellido, matricula, parcial1, parcial2, examenFinal, practica1, practica2, practicaFinal);

                // Agregar a la lista de estudiantes
                estudiantes.Add(estudiante);

                // Actualizar el DataGridView
                ActualizarDataGridView();

                // Guardar en el archivo de texto
                GuardarEnTxt(estudiante);

                // Limpiar el formulario
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }
        }

        // Método para guardar en un archivo de texto
        private void GuardarEnTxt(Estudiante estudiante)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
                {
                    // Si el archivo es nuevo, escribir el encabezado
                    if (new FileInfo(rutaArchivo).Length == 0)
                    {
                        sw.WriteLine("Matricula | Nombre | Apellido | Parcial1 | Parcial2 | ExamenFinal | Practica1 | Practica2 | PracticaFinal | CalificacionFinal | Estatus");
                    }

                    // Escribir los datos del estudiante en el archivo
                    sw.WriteLine(value: estudiante.ToTxt());
                }

                MessageBox.Show("Datos guardados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo: " + ex.Message);
            }
        }

        // Método para cargar y mostrar los estudiantes en el DataGridView
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarDesdeTxt();
            ActualizarDataGridView();
        }

        // Cargar los estudiantes desde el archivo de texto
        private void CargarDesdeTxt()
        {
            try
            {
                if (!File.Exists(rutaArchivo))
                {
                    MessageBox.Show("No se encontró el archivo de texto.");
                    return;
                }

                // Leer todas las líneas del archivo de texto
                string[] lineas = File.ReadAllLines(rutaArchivo);
                estudiantes.Clear();

                // Saltar la primera línea que contiene los encabezados
                for (int i = 1; i < lineas.Length; i++)
                {
                    var datos = lineas[i].Split('|');

                    Estudiante estudiante = new Estudiante(
                        datos[2].Trim(), datos[1].Trim(), datos[0].Trim(),
                        int.Parse(datos[3].Trim()), int.Parse(datos[4].Trim()),
                        int.Parse(datos[5].Trim()), int.Parse(datos[6].Trim()),
                        int.Parse(datos[7].Trim()), int.Parse(datos[8].Trim())
                    );
                    estudiantes.Add(estudiante);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        // Actualizar el DataGridView con los estudiantes
        private void ActualizarDataGridView()
        {
            dgvEstudiantes.Rows.Clear();

            foreach (var estudiante in estudiantes)
            {
                int v = dgvEstudiantes.Rows.Add(estudiante.Matricula, estudiante.Nombre, estudiante.Apellido, estudiante.CalificacionFinal, estudiante.Estatus);
            }
        }

        // Limpiar el formulario
        private void LimpiarFormulario()
        {
            txtNombreYApellido.Clear();
            txtMatricula.Clear();
            txtParcial1.Clear();
            txtParcial2.Clear();
            txtExamenFinal.Clear();
            txtPractica1.Clear();
            txtPractica2.Clear();
            txtPracticaFinal.Clear();
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
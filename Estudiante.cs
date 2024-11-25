using System;

namespace ReporteCalificaciones
{
    public class Estudiante
    {
        private string apellido;
        internal object Apellido;

        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public int Parcial1 { get; set; }
        public int Parcial2 { get; set; }
        public int ExamenFinal { get; set; }
        public int Practica1 { get; set; }
        public int Practica2 { get; set; }
        public int PracticaFinal { get; set; }

        // Constructor modificado
        public Estudiante(string nombre, string matricula, int parcial1, int parcial2,
                          int examenFinal, int practica1, int practica2, int practicaFinal)
        {
            Nombre = nombre;
            Matricula = matricula;
            Parcial1 = parcial1;
            Parcial2 = parcial2;
            ExamenFinal = examenFinal;
            Practica1 = practica1;
            Practica2 = practica2;
            PracticaFinal = practicaFinal;
        }

        public Estudiante(string nombre, string apellido, string matricula, int parcial1, int parcial2, int examenFinal, int practica1, int practica2, int practicaFinal)
        {
            Nombre = nombre;
            this.apellido = apellido;
            Matricula = matricula;
            Parcial1 = parcial1;
            Parcial2 = parcial2;
            ExamenFinal = examenFinal;
            Practica1 = practica1;
            Practica2 = practica2;
            PracticaFinal = practicaFinal;
        }

        // Calcular la calificación final y el estatus
        public double CalificacionFinal
        {
            get
            {
                return (Parcial1 + Parcial2 + ExamenFinal + Practica1 + Practica2 + PracticaFinal) / 6.0;
            }
        }

        public string Estatus
        {
            get
            {
                double calificacionFinal = CalificacionFinal;
                return calificacionFinal >= 60 ? "Aprobado" : "Reprobado";
            }
        }

        // Método para guardar en CSV
        public string ToCsv()
        {
            return $"{Matricula},{Nombre},{Parcial1},{Parcial2},{ExamenFinal},{Practica1},{Practica2},{PracticaFinal},{CalificacionFinal},{Estatus}";
        }

        internal char ToTxt()
        {
            throw new NotImplementedException();
        }
    }
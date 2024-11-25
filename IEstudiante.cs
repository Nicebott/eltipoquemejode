namespace ReporteCalificaciones
{
    public interface IEstudiante
    {
        string Apellido { get; set; }
        string Apellido { get; set; }
        int CalificacionFinal { get; }
        string Estatus { get; set; }
        string Estatus { get; }
        float ExamenFinal { get; set; }
        int ExamenFinal { get; set; }
        string Matricula { get; set; }
        string Matricula { get; set; }
        string Nombre { get; set; }
        string Nombre { get; set; }
        float Parcial1 { get; set; }
        int Parcial1 { get; set; }
        float Parcial2 { get; set; }
        int Parcial2 { get; set; }
        float Practica1 { get; set; }
        int Practica1 { get; set; }
        float Practica2 { get; set; }
        int Practica2 { get; set; }
        float PracticaFinal { get; set; }
        int PracticaFinal { get; set; }
        float Promedio { get; set; }

        string ToCsv();
    }
}
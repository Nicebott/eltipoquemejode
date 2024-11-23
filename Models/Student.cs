using System;

namespace GradeManagementSystem.Models
{
    public class Student
    {
        public string StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal FirstExam { get; set; }
        public decimal SecondExam { get; set; }
        public decimal FinalExam { get; set; }
        public decimal Practice1 { get; set; }
        public decimal Practice2 { get; set; }
        public decimal Practice3 { get; set; }

        public decimal CalculateExamsScore()
        {
            return ((FirstExam + SecondExam + FinalExam) / 3) * 0.6m;
        }

        public decimal CalculatePracticeScore()
        {
            return ((Practice1 + Practice2 + Practice3) / 3) * 0.4m;
        }

        public decimal CalculateFinalGrade()
        {
            return CalculateExamsScore() + CalculatePracticeScore();
        }

        public string GetStatus()
        {
            return CalculateFinalGrade() >= 70 ? "Aprobado" : "Reprobado";
        }
    }
}
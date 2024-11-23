using System.Collections.Generic;
using GradeManagementSystem.Models;

namespace GradeManagementSystem.Data
{
    public interface IStudentRepository
    {
        void AddStudent(Student student);
        List<Student> GetAllStudents();
        Student GetStudentById(string studentId);
        void UpdateStudent(Student student);
        void DeleteStudent(string studentId);
        void SaveChanges();
    }
}
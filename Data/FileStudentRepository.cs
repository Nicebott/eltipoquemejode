using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using GradeManagementSystem.Models;

namespace GradeManagementSystem.Data
{
    public class FileStudentRepository : IStudentRepository
    {
        private List<Student> _students;
        private readonly string _filePath = "students.json";

        public FileStudentRepository()
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            if (File.Exists(_filePath))
            {
                string jsonString = File.ReadAllText(_filePath);
                _students = JsonSerializer.Deserialize<List<Student>>(jsonString) ?? new List<Student>();
            }
            else
            {
                _students = new List<Student>();
            }
        }

        public void AddStudent(Student student)
        {
            if (_students.Any(s => s.StudentId == student.StudentId))
            {
                throw new Exception("La matrícula ya existe.");
            }
            _students.Add(student);
            SaveChanges();
        }

        public List<Student> GetAllStudents()
        {
            return _students;
        }

        public Student GetStudentById(string studentId)
        {
            return _students.FirstOrDefault(s => s.StudentId == studentId);
        }

        public void UpdateStudent(Student student)
        {
            var existingStudent = _students.FirstOrDefault(s => s.StudentId == student.StudentId);
            if (existingStudent != null)
            {
                var index = _students.IndexOf(existingStudent);
                _students[index] = student;
                SaveChanges();
            }
        }

        public void DeleteStudent(string studentId)
        {
            var student = _students.FirstOrDefault(s => s.StudentId == studentId);
            if (student != null)
            {
                _students.Remove(student);
                SaveChanges();
            }
        }

        public void SaveChanges()
        {
            string jsonString = JsonSerializer.Serialize(_students);
            File.WriteAllText(_filePath, jsonString);
        }
    }
}
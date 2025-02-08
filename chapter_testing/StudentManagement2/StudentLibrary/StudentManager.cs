using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentLibrary
{
    public class StudentManager
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            if (student == null)
                throw new ArgumentNullException("Student cannot be null");

            if (students.Any(s => s.Id == student.Id))
                throw new ArgumentException("Student ID already exists");

            students.Add(student);
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public Student? GetStudentById(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }

        public void UpdateStudent(int id, string newName, int newAge, double newGPA)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null)
                throw new ArgumentException("Student not found");

            student.Name = newName;
            student.Age = newAge;
            student.GPA = newGPA;
        }

        public void RemoveStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null)
                throw new ArgumentException("Student not found");

            students.Remove(student);
        }

        public double CalculateAverageGPA()
        {
            if (students.Count == 0)
                throw new InvalidOperationException("No students available");

            return students.Average(s => s.GPA);
        }
        
        public Student GetTopStudent()
        {
            if (students.Count == 0)
                throw new InvalidOperationException("No students available");

            return students.OrderByDescending(s => s.GPA).First();
        }

        public List<Student> FilterStudentsByGPA(double minGPA, double maxGPA)
        {
            if (minGPA < 0 || maxGPA > 4.0 || minGPA > maxGPA)
                throw new ArgumentException("Invalid GPA range");

            return students.Where(s => s.GPA >= minGPA && s.GPA <= maxGPA).ToList();
        }

    }
}


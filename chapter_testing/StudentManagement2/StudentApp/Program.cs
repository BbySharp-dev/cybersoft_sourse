﻿using StudentLibrary;

class Program
{
    static void Main()
    {
        StudentManager studentManager = new StudentManager();

        studentManager.AddStudent(new Student(1, "Truong", 20, 3.5));
        studentManager.AddStudent(new Student(2, "Joy", 22, 3.8));

        Console.WriteLine("Danh sách sinh viên:");
        foreach (var student in studentManager.GetAllStudents())
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}, GPA: {student.GPA}");
        }

        Console.WriteLine($"Điểm trung bình của lớp: {studentManager.CalculateAverageGPA():0.00}");
    }
}
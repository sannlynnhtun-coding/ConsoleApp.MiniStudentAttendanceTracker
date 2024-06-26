﻿namespace ConsoleApp.MiniStudentAttendanceTracker.Repositories;

public interface IStudentRepository
{
    void AddStudent(Student student);
    Student GetStudent(int id);
    IEnumerable<Student> GetAllStudents();
}
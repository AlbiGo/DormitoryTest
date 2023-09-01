// See https://aka.ms/new-console-template for more information
using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using DataLayer.Entities;

Console.WriteLine("Hello, World!");


IStudentService studentService = new StudentService();

var allStudents = await studentService.GetAllStudents();

allStudents.ForEach(student =>
{
    Console.WriteLine(student.Name);
});

studentService.ShtoStudent(new Student()
{ 
    Name = "Ori",
    LastName = "Goxhaj"
});

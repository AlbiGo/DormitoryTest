// See https://aka.ms/new-console-template for more information
using BusinessLayer.Interfaces;
using BusinessLayer.Services;

Console.WriteLine("Hello, World!");


IStudentService studentService = new StudentService();

var allStudents = await studentService.GetAllStudents();

allStudents.ForEach(student =>
{
    Console.WriteLine(student.Name);
});
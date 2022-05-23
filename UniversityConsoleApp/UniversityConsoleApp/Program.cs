using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityConsoleApp.BL;
using UniversityConsoleApp.Models;
namespace UniversityConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager();
            List<Person> students = studentManager.Create(21, 19);
            studentManager.Print(students);
            TeacherManager teacherManager = new TeacherManager();
            List<Person> teachers = teacherManager.Create(5, 19);
            teacherManager.Print(teachers);
            Console.WriteLine("**********STUDENTS TO TEACHERS**********");
            UniversityManager.SwapWithStudents(teachers, students);
            teacherManager.Print(teachers);
            Console.WriteLine("**********TEACHERS TO STUDENTS**********");
            UniversityManager.SwapWithTeachers(students, teachers);
            studentManager.Print(students);
        }
    }
}

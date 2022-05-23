using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityConsoleApp.Models;
using UniversityConsoleApp.Interfaces;
namespace UniversityConsoleApp.BL
{

    public class TeacherManager : IPrint, IManager
    {
        public Person Create(string firstName, string lastName, int age) => new Teacher(firstName, lastName, age);

        public List<Person> Create(int count, int minAge)
        {
            List<Person> teachers = new List<Person>(count);
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                teachers.Add(new Teacher($"name{i}", $"surName{i}", rnd.Next(minAge, 36)));
            }

            return teachers;
        }

        public void Print(Person person)
        {
            if (person is Teacher)
            {
                Console.WriteLine("**********  Teacher  **********");
                Console.WriteLine($"id:{person.ID} name:{person.FirstName} lastName:{person.LastName} age:{person.Age}");
                Teacher teacher = (Teacher)person;
                if (teacher.Students == null)
                    Console.WriteLine("This person does not have students!");
                else
                {
                    Console.WriteLine("Students of this teacher:");
                    for (int i = 0; i < teacher.Students.Count; i++)
                    {
                        Console.WriteLine(
                            $"id:{teacher.Students[i].ID} name:{teacher.Students[i].FirstName} lastName:{teacher.Students[i].LastName} age:{teacher.Students[i].Age}");
                    }
                }

                Console.WriteLine();
            }
        }

        public void Print(List<Person> teachers)
        {
            for (int i = 0; i < teachers.Count; i++) Print(teachers[i]);
        }
    }
}

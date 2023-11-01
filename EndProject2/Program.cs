using EndProjectLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndProject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teacher Management System");

            do
            {
                Console.WriteLine("1. Add Teacher");
                Console.WriteLine("2. View All Teachers");
                Console.WriteLine("3. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Add Teacher
                        Console.WriteLine("Enter Teacher ID:");
                        int id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Teacher Name:");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter Class and Section:");
                        string classAndSection = Console.ReadLine();

                        Teacher newTeacher = new Teacher { ID = id, Name = name, ClassAndSection = classAndSection };
                        Teacherinfo.AddTeacher(newTeacher);
                        Console.WriteLine("Teacher added successfully!");
                        break;

                    case 2:
                        // View All Teachers
                        List<Teacher> teachers = Teacherinfo.GetAllTeachers();
                        foreach (var teacher in teachers)
                        {
                            Console.WriteLine($"{teacher.ID}, {teacher.Name}, {teacher.ClassAndSection}");
                        }
                        break;

                    case 3:
                        // Exit the program
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
                Console.Clear();

            } while (true);
        }
    }
}
    


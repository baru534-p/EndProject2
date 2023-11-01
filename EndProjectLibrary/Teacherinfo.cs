using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndProjectLibrary
{
    public class Teacherinfo
    {
        private const string FilePath = "C:\\Users\\Bhargavi\\source\\repos\\EndProject2\\teacher.txt";

        public static List<Teacher> GetAllTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();

            if (File.Exists(FilePath))
            {
                using (StreamReader reader = new StreamReader(FilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        teachers.Add(new Teacher
                        {
                            ID = int.Parse(data[0]),
                            Name = data[1],
                            ClassAndSection = data[2]
                        });
                    }
                }
            }

            return teachers;
        }

        public static void AddTeacher(Teacher teacher)
        {
            using (StreamWriter writer = new StreamWriter(FilePath, true))
            {
                writer.WriteLine($"{teacher.ID},{teacher.Name},{teacher.ClassAndSection}");
            }
        }

        // Add methods for updating and deleting teachers if needed
    }
}
    


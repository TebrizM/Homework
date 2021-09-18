using System;
using System.Collections.Generic;
using System.Text;


namespace Tasklar.Task14
{
    class Group
    {
        static double count = 120;
        public string  No;
        public int groupLimit;
        public Student[] students;

        public Group(int limit)
        {
            count++;
            No = "P" + count;   
            groupLimit = limit;
            students = new Student[0];
        }
        public void AddStudent()
        {
            Console.Write("Student Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Student Surname: ");
            string surname = Console.ReadLine();

            Student student = new Student(name, surname);
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }
        public void GetStudents()
        {
            foreach (var item in students)
            {
                Console.Write(item.Name);
                Console.Write(item.Surname);
                Console.Write(No);
                Console.WriteLine();
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using DataStorageOef1.Data.Models;
using Newtonsoft.Json;
using SMUtils;

namespace DataStorageOef1.Views
{
    class StudentViews
    {
        public static Student CreateStudent()
        {
            var student = new Student();
            Console.Write("Please enter your name: ");
            student.StudentName = Console.ReadLine();

            Console.Write("Please enter your age: ");
            student.StudentAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter your class: ");
            student.StudentClass = Console.ReadLine();

            return student;
        }

        public static void ShowStudent(Student student)
        {
            Console.WriteLine("Name: " + student.StudentName);
            Console.WriteLine("Age: " + student.StudentAge);
            Console.WriteLine("Class: " + student.StudentClass);
        }
        public static void ShowStudents(List<Student> list)
        {
            list.ForEach(item =>
            {
                ShowStudent(item);
                Console.WriteLine();
            });
        }
    }
}

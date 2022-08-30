using Code_Academy.Models;
using Code_Academy.Services;
using System;
using System.Collections.Generic;

namespace Code_Academy
{
     public class Program
    {
         static void Main(string[] args)
        {

            //education types
            string programming = "programming";
            string design = "Design";
            string helpdesk = "Helpdesk";
            string marketing = "Marketing";



            //teachers
            Teacher teacher = new Teacher();
            teacher.Name = "Valeh";
            teacher.Surname = "Agayev";
            teacher.Age = 35;


            //groups
            Group programmingGroup = new Group(programming);
            Group designGroup = new Group(design);
            Group marketingGroup = new Group(marketing);


            //students
            Student student1 = new Student();
            student1.Name = "Ruslan";
            student1.Surname = "Ibrahimov";
            student1.Age = 22;

            Student student = new Student()
            {
                Name="Gunay",
                Surname="Esgerxanli",
                Age=19
                
            };


            //list for Add student method
            List<Student> students = new List<Student>();


            //operations

            Operations operations = new Operations();

            operations.AddStudent(programmingGroup, student, students);

            operations.AddStudent(programmingGroup, student1, students);

            operations.GetStudents(programmingGroup);

            operations.AddTeacher(programmingGroup, teacher);

            operations.GetTeacher(programmingGroup);
        }

    }
}

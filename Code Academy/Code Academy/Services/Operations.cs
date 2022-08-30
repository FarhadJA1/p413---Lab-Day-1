using Code_Academy.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Academy.Services
{
    public class Operations : IOperations
    {
        public void AddStudent(Group group,Student student,List<Student> students)
        {
            students.Add(student);
            group.Students = students;
        }

        public void AddTeacher(Group group,Teacher teacher)
        {
            group.Teacher = teacher;
        }

        public void GetStudents(Group group)
        {
            foreach (var student in group.Students)
            {
                Console.WriteLine(group.GroupCode+" Students are "+student.Name+" "+student.Surname);
            }
        }

        public void GetTeacher(Group group)
        {
            Console.WriteLine($"{group.GroupCode} teacher is {group.Teacher.Name} {group.Teacher.Surname}");
           
        }
    }
}

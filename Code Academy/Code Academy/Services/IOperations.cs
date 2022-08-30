using Code_Academy.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Academy.Services
{
    public interface IOperations
    {
        void AddStudent(Group group, Student student, List<Student> students); 
        void AddTeacher(Group group, Teacher teacher);
        void GetStudents(Group group);
        void GetTeacher(Group group);
    }
}

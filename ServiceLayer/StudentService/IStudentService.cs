using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.StudentService
{

    public interface IStudentService
    {
        IEnumerable<Student> GetAllStudents();
       Student GetStudent(int id);
        void InsertStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int id);
    }

}

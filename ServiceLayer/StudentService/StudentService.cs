using DomainLayer.Models;
using RepositoryLayer.RepositoryPattern;
using System.Collections.Generic;

namespace ServiceLayer.StudentService
{

    public class StudentService : IStudentService
    {
        #region Property  
        private IRepository<Student> _repository;
        #endregion

        #region Constructor  
        public StudentService(IRepository<Student> repository)
        {
            _repository = repository;
        }
        #endregion

        public IEnumerable<Student> GetAllStudents()
        {
            return _repository.GetAll();
        }

        public Student GetStudent(int id)
        {
            return _repository.Get(id);
        }

            public void InsertStudent(Student student)
        {
            _repository.Insert(student);
        }

        public void UpdateStudent(Student student)
        {
            _repository.Update(student);
        }

        public void DeleteStudent(int id)
        {
            Student student = GetStudent(id);
            _repository.Remove(student);
            _repository.SaveChanges();
        }
    }
}

using NetDevPack.Data;
using PlanB.Domain.Models;
using System;
using System.Threading.Tasks;

namespace PlanB.Domain.Contracts
{
    public interface IStudentRepository : IRepository<Student>
    {
        Task<Student> GetById(Guid id);
        Task<Student> GetByLastName(string LastName);
        Task<IEquatable<Student>> GetAll();

        void Add(Student student);
        void Update(Student student);
        void Remove(Student student);
         
    }
}
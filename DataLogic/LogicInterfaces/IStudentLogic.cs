using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLogic;

namespace DataLogic.LogicInterfaces
{
    public interface IStudentLogic
    {
        Task<StudentView?> GetStudentByIdAsync(int id);
        Task<List<StudentView>> GetAllStudentsAsync();
        Task AddStudentAsync(StudentView student);
        Task UpdateStudentAsync(StudentView student);
    }
}

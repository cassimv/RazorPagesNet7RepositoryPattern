using Azure.Identity;
using DataLogic;
using DataLogic.Students;
using Microsoft.EntityFrameworkCore;
using Repository.GenericRepository;
using Repository.RepositoryInterfaces;

namespace Repository.ImplementedRepositories
{
    public class StudentRepository: GenericRepository<Students>, iStudentRepository
    {
        public StudentRepository(DefaultContext dataContext) : base(dataContext)
        {
        }
    }
}
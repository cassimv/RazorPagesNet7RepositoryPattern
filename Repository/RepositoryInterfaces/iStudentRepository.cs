using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLogic.Students;
using Repository.Interfaces;

namespace Repository.RepositoryInterfaces
{
    public interface iStudentRepository : iGenericRepository<Students>
    {
    }
}

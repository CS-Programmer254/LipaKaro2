using AbsaBank.Microservice.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsaBank.Microservice.Domain.Repositories
{
    public interface IStudentAccountRepository
    {
        Task<bool> SaveStudentAccountAsync(StudentAccount student);
        Task<Guid> DeleteStudentAccountByIdAsync(Guid StudentId);

    }
}

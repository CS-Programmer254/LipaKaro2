using AbsaBank.Microservice.Application.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsaBank.Microservice.Application.Services
{
    public interface IStudentAccountService
    {

        Task<Guid> CreateStudentAccountAsync(CreateStudentAccountCommand createStudentAccountCommand);
        Task<Guid> DeleteStudentAccountAsync(DeleteStudentAccountCommand deleteStudentAccountCommand);
    }
}

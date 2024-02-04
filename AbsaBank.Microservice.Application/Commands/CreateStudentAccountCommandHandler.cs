using AbsaBank.Microservice.Application.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsaBank.Microservice.Application.Commands
{
    public class CreateStudentAccountCommandHandler : IRequestHandler<CreateStudentAccountCommand, Guid>
    {
        private readonly IStudentAccountService _studentAccountService;
        public CreateStudentAccountCommandHandler(IStudentAccountService studentAccountService)
        {
            _studentAccountService = studentAccountService ?? throw new ArgumentNullException(nameof(studentAccountService));
        }
        public Task<Guid> Handle(CreateStudentAccountCommand request, CancellationToken cancellationToken)
        {
            try
            {
                return _studentAccountService.CreateStudentAccountAsync(request);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

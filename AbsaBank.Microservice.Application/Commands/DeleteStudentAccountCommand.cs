using AbsaBank.Microservice.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsaBank.Microservice.Application.Commands
{
    public class DeleteStudentAccountCommand : IRequest<Guid>
    {
        public DeleteStudentAccountDto ? deleteStudentAccountDto { get; set; }
    }
}

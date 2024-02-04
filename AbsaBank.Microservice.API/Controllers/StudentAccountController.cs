using AbsaBank.Microservice.Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AbsaBank.Microservice.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAccountController : ControllerBase
    {
        private readonly IMediator _mediator;
        public StudentAccountController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }
  
        // POST api/<StudentAccountController>
        [HttpPost]
        public async Task<Guid> CreateStudentAccount([FromBody] CreateStudentAccountCommand command)
        {
            try
            {
                return await _mediator.Send(command);
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/<StudentAccountController>/5
        [HttpDelete]
        public async Task<Guid> DeleteStudentAccount([FromBody] DeleteStudentAccountCommand command)
        {
            try
            {
                return await _mediator.Send(command);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

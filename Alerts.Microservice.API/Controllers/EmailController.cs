using Alerts.Microservice.Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Alerts.Microservice.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IMediator _mediator;
        public EmailController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        // POST api/<Email>
        [HttpPost]
        public async Task<bool> SendEmail([FromBody] SendEmailCommand command)
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

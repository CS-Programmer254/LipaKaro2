using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsaBank.Microservice.Application.Dtos
{

    public record DeleteStudentAccountDto
    {
        [Key]
        public Guid StudentId { get; set; }

    }
}

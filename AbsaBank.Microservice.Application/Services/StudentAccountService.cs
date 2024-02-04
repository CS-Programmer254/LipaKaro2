using AbsaBank.Microservice.Application.Commands;
using AbsaBank.Microservice.Domain.Entities;
using AbsaBank.Microservice.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsaBank.Microservice.Application.Services
{
    public class StudentAccountService : IStudentAccountService
    {
        private readonly IStudentAccountRepository _studentAccountRepository;
        public StudentAccountService(IStudentAccountRepository studentRepository)
        {

            _studentAccountRepository = studentRepository;

        }

        public async Task<Guid> CreateStudentAccountAsync(CreateStudentAccountCommand studentAccountCommand)
        {
            try
            {

                var newStudentAccount = StudentAccount.
                    AddNewStudentAccount(
                    studentAccountCommand.StudentAccountDetails.FirstName,
                    studentAccountCommand.StudentAccountDetails.MiddleName,
                    studentAccountCommand.StudentAccountDetails.LastName,
                    studentAccountCommand.StudentAccountDetails.AdmissionNumber,
                    studentAccountCommand.StudentAccountDetails.Email,
                    studentAccountCommand.StudentAccountDetails.PhoneNumber,
                    studentAccountCommand.StudentAccountDetails.NationalIDNumber,
                    studentAccountCommand.StudentAccountDetails.KraPin,
                    studentAccountCommand.StudentAccountDetails.Cif,
                    studentAccountCommand.StudentAccountDetails.CustomerStatus,
                    studentAccountCommand.StudentAccountDetails.DateOfBirth
                    );
                await _studentAccountRepository.SaveStudentAccountAsync(newStudentAccount);
                return newStudentAccount.StudentId;

            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<Guid> DeleteStudentAccountAsync(DeleteStudentAccountCommand deleteStudentAccountCommand)
        {
            try
            {
                return await _studentAccountRepository.DeleteStudentAccountByIdAsync(deleteStudentAccountCommand.
                    deleteStudentAccountDto.StudentId);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

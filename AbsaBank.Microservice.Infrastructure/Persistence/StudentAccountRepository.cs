using AbsaBank.Microservice.Domain.Entities;
using AbsaBank.Microservice.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsaBank.Microservice.Infrastructure.Persistence
{
    public class StudentAccountRepository : IStudentAccountRepository
    {
        private readonly AbsaBankDbContext _dbContext;
        public StudentAccountRepository(AbsaBankDbContext absaBankDbContext)
        {
            _dbContext = absaBankDbContext ?? throw new ArgumentNullException(nameof(absaBankDbContext));

        }

        public async Task<bool> SaveStudentAccountAsync(StudentAccount student)
        {
            try
            {
                await _dbContext.StudentAccounts.AddAsync(student);
                await _dbContext.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<Guid> DeleteStudentAccountByIdAsync(Guid StudentId)
        {
            try
            {
                var student = await _dbContext.StudentAccounts.FirstOrDefaultAsync(s => s.StudentId == StudentId);
                if (student is not null)
                {
                    _dbContext.StudentAccounts.Remove(student);
                    await _dbContext.SaveChangesAsync();

                }
                return student.StudentId;

            }
            catch (Exception)
            {

                throw;
            }

        }

      
    }
}

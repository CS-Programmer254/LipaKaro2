using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsaBank.Microservice.Domain.Entities
{
    public class StudentAccount
    {
        [Key]
        public Guid StudentId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string AdmissionNumber { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string NationalIDNumber { get; set; }
        public string KraPin { get; set; }
        public string Cif { get; set; }
        public Guid CustomerStatus { get; set; }
        public DateTime DateOfBirth { get; set; }

        public StudentAccount()
        {

        }
        public StudentAccount(string firstName, string middleName, string lastName, string admissionNumber, string email, string phoneNumber, string nationalIDNumber, string kraPin, string cif, Guid customerStatus, DateTime dateOfBirth)
        {
            StudentId = Guid.NewGuid();
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            AdmissionNumber = admissionNumber;
            Email = email;
            PhoneNumber = phoneNumber;
            NationalIDNumber = nationalIDNumber;
            KraPin = kraPin;
            Cif = cif;
            CustomerStatus = customerStatus;
            DateOfBirth = dateOfBirth;

        }
        public static StudentAccount AddNewStudentAccount(string firstName, string middleName, string lastName, string admissionNumber, string email, string phoneNumber, string nationalIDNumber, string kraPin, string cif, Guid customerStatus, DateTime dateOfBirth)
        {
            return new StudentAccount(firstName, middleName, lastName, admissionNumber, email, phoneNumber, nationalIDNumber, kraPin, cif, customerStatus, dateOfBirth);
        }


    }
}

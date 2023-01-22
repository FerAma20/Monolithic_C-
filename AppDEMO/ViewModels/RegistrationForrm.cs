using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppDEMO.ViewModels
{
    
    public class RegistrationForrm
    {
        private string firstName;
        private string lastName;
        private string address;
        private string email;
        private string phoneNumber;
        private string course;
        private string dateOfBirth;

        public RegistrationForrm()
        {
        }

        public RegistrationForrm(string firstName, string lastName, string address, string email, string phoneNumber, string course, string dateOfBirth)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.course = course;
            this.dateOfBirth = dateOfBirth;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Course { get => course; set => course = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
    }
}
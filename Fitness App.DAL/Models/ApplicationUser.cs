using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_App.DAL.Models
{
    public class ApplicationUser: IdentityUser<int>
    {
        //public int UserID { get; set; }
        //public string Email { get; set; }
        //public string Password { get; set; }
        //public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public DateTime RegistrationDate { get; set; }
        public UserType UserType { get; set; }
        public Status Status { get; set; }

        
        
        

        //[ForeignKey("CoachId")]
        //public int CoachId { get; set; }
        //public Coach? Coach { get; set; }

        //[ForeignKey("ClientId")]
        //public int ClientId { get; set; }
        //public Client? Client { get; set; }

        //[ForeignKey("AdminId")]
        //public int AdminId { get; set; }
        //public Admin? Admin { get; set; }

    }
    public enum UserType
    {
        Admin,
        Coach,
        Client
    }

    public enum Status
    {
        Active,
        Inactive,
        Banned,
        LoggedOut   
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_App.DAL.Models
{
    public class Admin:ApplicationUser
    {
        //[Key]
        //public int AdminId { get; set; }// class inherit id from User
        
        //[ForeignKey("UserId")]
        //public int UserId { get; set; }
        //public ApplicationUser ApplicationUser { get; set; }

        public long NationalId { get; set; }

        public ICollection<Blogs> ?Blogs { get; set; }
        public ICollection<Exercises>? Exercises { get; set; }
        //public ICollection<DietPlans>? DietPlans { get; set; }

    }
}

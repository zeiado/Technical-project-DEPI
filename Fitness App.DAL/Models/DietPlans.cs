using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_App.DAL.Models
{
    public class DietPlans
    {
        [Key]
        public int PlanId { get; set; }

        [Required]
        [StringLength(100)]
        public string PlanTitle { get; set; }

        public string ImagePath { get; set; }


        //[ForeignKey("admin")]
        //public int AdminId { get; set; }

        //public Admin admin { get; set; }

    }
}

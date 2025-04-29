using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Fitness_App.BL.ViewModels
{
    public class DietPlanViewModel
    {

        [Required]
        [StringLength(100)]
        public string PlanTitle { get; set; }

        [Required]
        public IFormFile Image { get; set; } // To upload the photo

        //[Required]
        //public int AdminId { get; set; } // Set AdminId from session or manually
    }
}

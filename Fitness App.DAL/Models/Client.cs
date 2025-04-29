using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fitness_App.BL.Models;

namespace Fitness_App.DAL.Models
{
    public class Client: ApplicationUser
    {
        //[Key]
        //public int ClientId { get; set; } // class inherit id from User
        
        public float Height { get; set; }
        public float Weight { get; set; }
        public string HealthConditions { get; set; }
        public string FitnessGoals { get; set; }
        public string ActivityLevel { get; set; }       
        
        public List<ProgressLog> ProgressLogs { get; set; }
        public List<Message> messages { get; set; }
        public List<Subscription> subscriptions { get; set; }

        public List<Feedback> feedbacks { get; set; }

        //public int UserId { get; set; }
        //[ForeignKey("UserId")]
        //public ApplicationUser ApplicationUser { get; set; }

    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_App.DAL.Models
{
    public class Coach: ApplicationUser
    {
        //[Key]
        //public int CoachID { get; set; }// class inherit id from User
        public string Specialization { get; set; }
        public int Experience { get; set; }
        public List<string> Certification { get; set; }
        public float Rating { get; set; }  
        public double HourlyPrice { get; set; }
        public double WorkingHoursCount { get; set; }//     عدد ساعات الشغل 
        public List<Message> messages { get; set; }
        public List<Subscription> subscriptions { get; set; }
        //public int UserId { get; set; }
        //[ForeignKey("UserId")]
        //public ApplicationUser ApplicationUser { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_App.DAL.Models
{
    public class ProgressLog
    {
       public int ProgressLogId { get; set; }
        public DateTime Date { get; set; }
        public double Weight { get; set; }
        public string Measurements { get; set; }
        public string Notes { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
   
}

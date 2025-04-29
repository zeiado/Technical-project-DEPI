using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fitness_App.DAL.Models;

namespace Fitness_App.BL.Models
{
    public class Feedback
    {
        [Key]
        public int FeedbackId { get; set; }

        [Required]
        [StringLength(500)]
        public string Content { get; set; }


        [StringLength(100)]
        public string Subject { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Client who submitted the feedback
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

    }
}

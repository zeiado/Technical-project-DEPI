using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_App.DAL.Models
{
    public class Exercises
    {
        [Key]
        public int ExerciseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] GIF { get; set; }// check this how to upload the photos
        public ExerciseType Type { get; set; }


        [ForeignKey("admin")]
        public int AdminId { get; set; }

        public Admin admin { get; set; }
    }
    public enum ExerciseType
    {
        Cardio,
        Strength,
        Flexibility,
        Balance
    }
}

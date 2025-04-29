using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_App.DAL.Models
{
    public class Blogs
    {
        [Key]
        public int BlogId { get;set; }
        public string BlogTitle{ get;set; }
        public string BlogContent { get; set; }


        [ForeignKey("admin")]
        public int AdminId { get; set; }

        public Admin admin { get; set; }
        
    }
}

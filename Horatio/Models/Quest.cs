using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Horatio.Models
{
    public class Quest
    {
        [Key]
        public int Quest_ID { get; set; }
        [Required]
        public string Title { get; set; }

        [Required]
        //[DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        [ForeignKey("ETA")]
        public int ETA_ID { get; set; }
        public ETA ETA { get; set; }
        
        public decimal? Rating { get; set; }

        [Display(Name = "Completed")]
        public bool? isCompleted { get; set; }

        public List<Labor> Labors { get; set; }
    }
}
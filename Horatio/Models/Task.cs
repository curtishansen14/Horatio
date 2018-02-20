using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Horatio.Models
{
    public class Task
    {
        [Key]
        public int Task_ID { get; set; }

        [ForeignKey("Quest")]
        public int Quest_ID { get; set; }

        [MaxLength(509)]
        public string Description { get; set; }

        [ForeignKey("ETA")]
        [Display(Name = "Completion Time")]
        public string Recommended_Completion_Time { get; set; }

        public string Location { get; set; }

        [Display(Name = "Completed")]
        public bool isCompleted { get; set; }



    }
}
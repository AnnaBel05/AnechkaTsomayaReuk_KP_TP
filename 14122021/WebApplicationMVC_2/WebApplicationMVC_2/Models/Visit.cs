using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVC_2.Models
{
    public class Visit
    {
        public Guid Id { get; set; }
		[Display(Name = "Студент")] 				
        public Guid StudentId { get; set; }
        [Display(Name = "Студент")]
        public Student Student { get; set; }
		[Display(Name = "Причина")] 				
        public int ReasonId { get; set; }
        [Display(Name = "Причина")]
        public Reason Reason { get; set; }
        [DataType(DataType.Date), Display(Name = "Дата")]
        public DateTime Date { get; set; }
    }
}

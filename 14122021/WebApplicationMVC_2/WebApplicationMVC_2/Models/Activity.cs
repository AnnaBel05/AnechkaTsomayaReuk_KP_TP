using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVC_2.Models
{
    public class Activity
    {
        public Guid Id { get; set; }
        [Display(Name = "Студент")] 		
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
		[Display(Name = "Вид активности")] 		
        public int ActivityTypeId { get; set; }
        public ActivityType ActivityType { get; set; }
        [DataType(DataType.Date), Display(Name = "Дата")] 
        public DateTime Date { get; set; }
		[Display(Name = "Тема")] 		
        public String Topic { get; set; }
    }
}

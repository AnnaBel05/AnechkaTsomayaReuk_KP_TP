using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVC_2.Models
{
    public class GraduateWork
    {
        public Guid Id { get; set; }
		[Display(Name = "Тема")] 		
        public String Topic { get; set; }
		[Display(Name = "Студент")] 		
        public Guid StudentId { get; set; }
        [Display(Name = "Студент")]
        public Student Student { get; set; }
		[Display(Name = "Преподаватель")] 		
        public Guid EmployeeId { get; set; }
        [Display(Name = "Преподаватель")]
        public Employee Employee { get; set; }
		[Display(Name = "Оценка")] 				
        public int ValueId { get; set; }
        [Display(Name = "Оценка")]
        public Value Value { get; set; }
		[Display(Name = "Состояние работы")] 				
        public int WorkStatusId { get; set; }
        [Display(Name = "Состояние работы")]
        public WorkStatus WorkStatus { get; set; }

    }
}

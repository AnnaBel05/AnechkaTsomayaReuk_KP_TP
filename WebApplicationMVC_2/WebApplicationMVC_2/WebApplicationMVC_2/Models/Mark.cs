using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVC_2.Models
{
    public class Mark
    {
        public Guid Id { get; set; }
		[Display(Name = "Студент")] 				
        public Guid StudentId { get; set; }
        [Display(Name = "Студент")]
        public Student Student { get; set; }
		[Display(Name = "Вид работы")] 		
        public int MarkTypeId { get; set; }
        [Display(Name = "Вид работы")]
        public MarkType MarkType { get; set; }
		[Display(Name = "Дисциплина")] 		
        public Guid CourseId { get; set; }
        [Display(Name = "Дисциплина")]
        public Course Course { get; set; }
        [DataType(DataType.Date), Display(Name = "Дата")] 
        public DateTime Date { get; set; }
		[Display(Name = "Оценка")] 				
        public int ValueId { get; set; }
        [Display(Name = "Оценка")]
        public Value Value { get; set; }
        
    }
}

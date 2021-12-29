using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVC_2.Models
{
    public class EditableList
    {
        public Guid Id { get; set; }
        [Display(Name = "Название")]
        public string Name { get; set; }
    }
    public class Course : EditableList
    {
    }
    public class Group : EditableList
    {
    }

}

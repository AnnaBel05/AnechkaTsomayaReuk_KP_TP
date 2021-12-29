using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMVC_2.Models
{

    public class Enumeration
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class ActivityType : Enumeration
    {
    }
    public class EducationalForm : Enumeration
    {       
    }
    public class MarkType : Enumeration
    {
    }
    public class Reason : Enumeration
    {
    }
    public class ScholarshipType : Enumeration
    {
    }
    public class TrainingType : Enumeration
    {
    }
    public class Value : Enumeration
    {
    }    public class WorkStatus : Enumeration
    {
    }
}

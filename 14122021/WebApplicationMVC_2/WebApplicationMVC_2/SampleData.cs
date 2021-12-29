using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMVC_2.Models;

namespace WebApplicationMVC_2
{
    public class SampleData
    {
        public static void Initialize(UniversityContext context)
        {
            if (!context.Courses.Any())
            {
                context.Courses.AddRange(
                    new Course
                    {
                        Id = Guid.NewGuid(),
                        Name = "Дисциплина А"
                    },
                    new Course
                    {
                        Id = Guid.NewGuid(),
                        Name = "Дисциплина Б"
                    },
                    new Course
                    {
                        Id = Guid.NewGuid(),
                        Name = "Дисциплина В"
                    }
                );
                context.SaveChanges();
            }
            if (!context.Groups.Any())
            {
                context.Groups.AddRange(
                    new Group
                    {
                        Id = Guid.NewGuid(),
                        Name = "Группа 11"
                    },
                    new Group
                    {
                        Id = Guid.NewGuid(),
                        Name = "Группа 12"
                    }
                );
                context.SaveChanges();
            }        
        }
    }
}

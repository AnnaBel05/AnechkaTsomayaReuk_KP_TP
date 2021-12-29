using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMVC_2.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public List<User> Users { get; set; }
        public Role()
        {
            Users = new List<User>();
        }
    }
}

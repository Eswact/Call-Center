using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [StringLength(20)]
        public string Username { get; set; }
        [StringLength(20)]
        public string Password { get; set; }
        public int Role { get; set; }

        public ICollection<Job> Jobs { get; set; }
    }
}

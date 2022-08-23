using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Call
    {
        [Key]
        public int CallID { get; set; }
        public int CallNumber { get; set; }
        [StringLength(20)]
        public string CallDesc { get; set; }
        [StringLength(20)]
        public string CallStatus { get; set; }
        public DateTime CallTime { get; set; }
        [StringLength(20)]
        public string CustomerName { get; set; }

        public ICollection<Job> Jobs { get; set; }

    }
}

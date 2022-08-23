using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Job
    {
        [Key]
        public int JobID { get; set; }
        [StringLength(20)]
        public string Cari { get; set; }
        [StringLength(20)]
        public string CariAdres { get; set; }
        [StringLength(20)]
        public string Gruplar { get; set; }
        [StringLength(20)]
        public string Teknisyenler { get; set; }
        public DateTime KayıtTarihi { get; set; }
        public Boolean IsImportant { get; set; }
        public Boolean IsOpen { get; set; }
        
        public int UserID { get; set; }
        public virtual User Users { get; set; }

        public int CallID { get; set; }
        public virtual Call Calls { get; set; }
    }
}

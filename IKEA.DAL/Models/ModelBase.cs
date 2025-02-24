using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.DAL.Models
{
    public class ModelBase
    {
        public int Id { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateOn { get; set; }
        public int LastModificationBy { get; set; }
        public DateTime LastModificationOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}

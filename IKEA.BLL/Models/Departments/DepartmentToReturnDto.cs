using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Models.Departments
{
    //Dto: دي لي ال view
    public class DepartmentToReturnDto
    {
        public int Id { get; set; }
        //public int CreateBy { get; set; }
        //public DateTime CreateOn { get; set; }
        //public int LastModificationBy { get; set; }
        //public DateTime LastModificationOn { get; set; }
        //public bool IsDeleted { get; set; }
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public DateOnly CreationDate { get; set; }
    }
}

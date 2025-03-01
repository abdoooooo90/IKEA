using IKEA.BLL.Models.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Services.Departments
{
    public interface IDepartmentService
    {
        IEnumerable<DepartmentToReturnDto> GetAllDepartment();
        DepartmentDetailsReturnDto? GetDepartmentById(int id);
        int CreateDepartment (CreatedDepartmentDto departmentDto);
        int UpdateDepartment (UpdateDepartmentDto departmentDto);
        bool DeleteDepartment (int id);

    }
}

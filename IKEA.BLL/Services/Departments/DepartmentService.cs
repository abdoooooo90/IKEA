using IKEA.BLL.Models.Departments;
using IKEA.DAL.Models.Department;
using IKEA.DAL.Presistance.Repositoies.Departments;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Services.Departments
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public IEnumerable<DepartmentToReturnDto> GetAllDepartment()
        {
            var departments = _departmentRepository.GetAllAsQueryable().Select(
                department  => new DepartmentToReturnDto
                {
                    Id = department.Id,
                    Code = department.Code,
                    Name = department.Name,
                    CreationDate = department.CreationDate,
                }).AsNoTracking().ToList();
            return departments;
        }
        public DepartmentDetailsReturnDto? GetDepartmentById(int id)
        {
            var department = _departmentRepository.GetById(id);
            if (department is { })
            {
                return new DepartmentDetailsReturnDto()
                {
                    Id = department.Id,
                    Code = department.Code,
                    Name = department.Name,
                    Description = department.Description,
                    CreationDate = department.CreationDate,
                    CreateBy = department.CreateBy,
                    CreateOn = department.CreateOn,
                    LastModificationBy = department.LastModificationBy,
                    LastModificationOn = department.LastModificationOn
                };
            }
            return null;
        }
        public int CreateDepartment(CreatedDepartmentDto departmentDto)
        {
            var CreatedDepartment = new Department
            {
                Code = departmentDto.Code,
                Name = departmentDto.Name,
                Description = departmentDto.Description,
                CreationDate = departmentDto.CreationDate,
                CreateBy = 1,
                LastModificationBy = 1,
                LastModificationOn = DateTime.UtcNow
            };
            return _departmentRepository.Add(CreatedDepartment);
        }
        public int UpdateDepartment(UpdateDepartmentDto departmentDto)
        {
            var updateDepartment = new Department
            {
                Code = departmentDto.Code,
                Name = departmentDto.Name,
                Description = departmentDto.Description,
                CreationDate = departmentDto.CreationDate,
                CreateBy = 1,
                LastModificationBy = 1,
                LastModificationOn = DateTime.UtcNow
            };
            return _departmentRepository.Update(updateDepartment);
        }
        public bool DeleteDepartment(int id)
        {
            var department = _departmentRepository.GetById(id);
            if(department is { })
            {
                return _departmentRepository.Delete(department) > 0;
            }
            return false;
        }
    }
}

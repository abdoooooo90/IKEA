﻿using IKEA.DAL.Models.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.DAL.Presistance.Repositoies.Departments
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAll(bool WithNoTracking = true);
        IQueryable<Department> GetAllAsQueryable();
        Department? GetById(int id);
        int Add(Department entity);
        int Update(Department entity);
        int Delete(Department entity);
    }
}

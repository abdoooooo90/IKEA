﻿using IKEA.DAL.Models.Department;
using IKEA.DAL.Presistance.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.DAL.Presistance.Repositoies.Departments
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public DepartmentRepository(ApplicationDbContext dbContext)
        {
            //Ask Clr For Object For ApplicationDbContext Implicictly
            _dbContext = dbContext;
        }
        public IEnumerable<Department> GetAll(bool WithNoTracking = true)
        {
            if(WithNoTracking)
                return _dbContext.Departments.AsNoTracking().ToList();
            return _dbContext.Departments.ToList();
        }
        public Department? GetById(int id)
        {
            return _dbContext.Departments.Find(id);
            //var department = _dbContext.Departments.Local.FirstOrDefault(x => x.Id == id);
            //return department;
        }
        public int Add(Department entity)
        {
            _dbContext.Departments.Add(entity);
            return _dbContext.SaveChanges();
        }
        public int Update(Department entity)
        {
            _dbContext.Departments.Update(entity);
            return _dbContext.SaveChanges();
        }
        public int Delete(Department entity)
        {
            _dbContext.Departments.Remove(entity);
            return _dbContext.SaveChanges();
        }

        public IQueryable<Department> GetAllAsQueryable()
        {
            return _dbContext.Departments;
        }
    }
}

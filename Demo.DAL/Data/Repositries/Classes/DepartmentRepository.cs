using Demo.DAL.Data.Repositries.Interfaces;
using Demo.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Data.Repositries.Classes
{
    public class DepartmentRepository(AppDbContext dbContext) : IDeparmentRepositry
    {
        private readonly AppDbContext _dbContext = dbContext; //null

        public int Add(Department Entity) // object member method
        {
            _dbContext.Departments.Add(Entity); // state Add
            return _dbContext.SaveChanges();    // update database
        }

        public int Delete(Department Entity)
        {
            _dbContext.Departments.Remove(Entity); // Remove Locally [deleted]
            return _dbContext.SaveChanges(); // database علشان التغيير ده يسمع في ال
        }

        public IEnumerable<Department> GetAll(bool withtracking= false)
        {
            if (withtracking)
            {
                return _dbContext.Departments.ToList();
            }
            else 
                return _dbContext.Departments.AsNoTracking().ToList();
        }

        public Department GetById(int id)
        {
            return _dbContext.Departments.Find(id);
        }

        public int Update(Department Entity)
        {
            _dbContext.Departments.Update(Entity); // Update Locally [modified]
            return _dbContext.SaveChanges();
        }
    }
}

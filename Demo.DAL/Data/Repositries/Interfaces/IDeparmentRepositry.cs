using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.DAL.Models;

namespace Demo.DAL.Data.Repositries.Interfaces
{
    public interface IDeparmentRepositry 
    {
        // Get All
        IEnumerable<Department> GetAll(bool withTracking);
        // Get by Id
        Department GetById(int id);
        // Update
        int Update(Department Entity);
        // Delete
        int Delete(Department Entity);  
        // insert
        int Add(Department Entity);
    }
}

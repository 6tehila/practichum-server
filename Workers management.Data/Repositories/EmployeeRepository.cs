using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workers_management.Core.Entities;
using Workers_management.Core.Repositories;
using Microsoft.EntityFrameworkCore;


namespace Workers_management.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DataContext _context;

        public EmployeeRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Employee> AddEmployeeAsync(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return employee;
        }

        public async Task DeleteEmployeeAsync(int id)
        {
            var employee = await GetByIdAsync(id);
            employee.IsActive = false;
            await _context.SaveChangesAsync();

        }

        public async Task<Employee> GetByIdAsync(int id)
        {
            return await _context.Employees.Include(x => x.EmployeePositions).FirstAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Employee>> GetEmployeeAsync()
        {
            return await _context.Employees.ToListAsync();
        }

        //public async Task<Employee> UpdateEmployeeAsync(int id, Employee employee)
        //{
        //    var updateEmp = _context.Employees.FirstOrDefault(emp=>emp.Id==id);
        //    if (updateEmp != null)
        //    {
        //        updateEmp.Id = employee.Id;
        //        updateEmp.FirstName = employee.FirstName;
        //        updateEmp.LastName = employee.LastName;
        //        updateEmp.StartDate = employee.StartDate;
        //        updateEmp.BirthDate = employee.BirthDate;
        //        updateEmp.IsActive = employee.IsActive;
        //        await _context.SaveChangesAsync();
        //        return updateEmp;
        //    }
        //    return null;
        //}
        public async Task<Employee> UpdateEmployeeAsync(int id, Employee employee)
        {
            var updateEmp = _context.Employees.FirstOrDefault(emp => emp.Id == id);
            if (updateEmp != null)
            {
                updateEmp.FirstName = employee.FirstName;
                updateEmp.LastName = employee.LastName;
                updateEmp.StartDate = employee.StartDate;
                updateEmp.BirthDate = employee.BirthDate;
                updateEmp.IsActive = employee.IsActive;
                updateEmp.EmployeePositions = employee.EmployeePositions;
                updateEmp.Gender = employee.Gender;
               
                await _context.SaveChangesAsync();
                return updateEmp;
            }
            return null;
        }

    }
}

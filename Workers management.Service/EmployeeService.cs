using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workers_management.Core.Entities;
using Workers_management.Core.Repositories;
using Workers_management.Core.Services;


namespace Workers_management.Service
{
    public class EmployeeService: IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Employee> AddEmployeeAsync(Employee employee)
        {
            return await _employeeRepository.AddEmployeeAsync(employee);
        }

        public async Task DeleteEmployeeAsync(int id)
        {
           await _employeeRepository.DeleteEmployeeAsync(id);
        }

        public async Task<Employee> GetByIdAsync(int id)
        {
            return await _employeeRepository.GetByIdAsync(id); 
        }

        public async Task<IEnumerable<Employee>> GetEmployeesAsync()
        {
            return await _employeeRepository.GetEmployeeAsync();
        }

        public async Task<Employee> UpdateEmployeeAsync(int id, Employee employee)
        {
           return await _employeeRepository.UpdateEmployeeAsync(id, employee);
        }
    }
}

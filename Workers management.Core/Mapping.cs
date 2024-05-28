using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workers_management.Core.Entities;

namespace Workers_management.Core.DTOs
{
    public class Mapping
    {
        public PotionDto MapToRoleDto(Position position)
        {
            return new PotionDto { Id = position.Id, Name = position.Name };
        }
        //public EmployeePotionsDto MapToEmployeeRolesDto(EmployeePosition employeePosition)
        //{
        //    return new EmployeePotionsDto { Id = employeePosition.Id, RoleId = employeePosition.ro, StartDate = employeePosition.StartDate, IsManagerial = employeePosition.IsManagerial };
        //}
        public EmployeeDto MapToEmployeeDto(Employee employee)
        {
            return new EmployeeDto {Id=employee.Id, FirstName = employee.FirstName, LastName = employee.LastName, StartDate = employee.StartDate,BirthDate=employee.BirthDate };
        }

    }
}

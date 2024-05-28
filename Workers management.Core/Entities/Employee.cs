using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers_management.Core.Entities
{
    public enum Gender
    {
        male,
        female,
    }
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsActive { get; set; }
        public Gender Gender { get; set; }

        public List<EmployeePosition> EmployeePositions { get; set; }

        public Employee()
        {
            EmployeePositions = new List<EmployeePosition>();
        }

    }
}

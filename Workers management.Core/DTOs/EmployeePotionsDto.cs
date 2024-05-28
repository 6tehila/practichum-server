using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers_management.Core.DTOs
{
    public class EmployeePotionsDto
    {
        //public int Id { get; set; }
        public int RoleId { get; set; }
        public bool IsManagerial { get; set; }
        public DateTime EntryDate { get; set; }
    }
}

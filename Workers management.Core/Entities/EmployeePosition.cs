using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers_management.Core.Entities
{
    public class EmployeePosition
    {
        public int Id { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public bool IsManagerial { get; set; }
        public DateTime StartDate { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers_management.Core.Entities
{
    public class Position
    {  
        public int Id { get; set; }
        public string Name { get; set; }
        //public bool IsActive { get; set; }
        public DateTime entryDate { get; set; }
    }
}

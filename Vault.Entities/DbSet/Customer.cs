using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vault.Entities.DbSet
{
    public class Customer : BaseEntity
    {
      
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? City { get; set; }
        public byte[]? Photo { get; set; }

        //Customer is only assigned to one employee
        public virtual Employee Employees { get; set; }

    }
}

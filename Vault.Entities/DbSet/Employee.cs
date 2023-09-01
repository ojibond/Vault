using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vault.Entities.DbSet
{
    public class Employee : BaseEntity
    {
        public Employee()
        {
            Customers = new HashSet<Customer>();
        }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;        
        public List<JobTitle> JobTitle { get; set; }
        public List<JobType> JobType { get; set; }
        public List<Roles> Role { get; set; }

        //Employee could be assigned to multiple customers and have multiple JDs
        public virtual ICollection<Customer> Customers { get; set; }


    }
}

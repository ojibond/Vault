using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vault.Entities.DbSet
{
    public class Customer : BaseEntity
    {
        public Customer()
        {
            Employees = new HashSet<Employees>();
            JobDescription = new HashSet<JobDescription>();
        }
        public int CustomerId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Address { get; set; }
        public int City { get; set; }

        public virtual ICollection<Employees> Employees { get; set; }
        public virtual ICollection<JobDescription> JobDescription { get; set; }
    }
}

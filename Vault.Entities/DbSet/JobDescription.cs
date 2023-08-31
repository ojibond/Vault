using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vault.Entities.DbSet
{
    public class JobDescription : BaseEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public List<Roles> Role { get; set; }

        public virtual Customer? Customer { get; set; }
    }
}

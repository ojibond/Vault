using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vault.Entities.DbSet
{
    public class NonClientFacingEmployees : Employees
    {
        public List<NCFJobTitle>NCFJobTitles { get; set; }

        public List<NCFRoles>NCFRoles { get; set; }

        public List<JobType> JobType { get; set; }
    }
}

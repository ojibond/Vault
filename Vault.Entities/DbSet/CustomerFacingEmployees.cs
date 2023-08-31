using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vault.Entities.DbSet
{
    public class ClientFacingEmployees : Employees
    {
        public List<CFJobTitle>CFJobTitles { get; set; }

        public List<CFRoles>CFRoles { get; set; }

    }
}

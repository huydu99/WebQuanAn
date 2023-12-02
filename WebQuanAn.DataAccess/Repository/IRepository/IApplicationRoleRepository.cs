using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebQuanAn.Models;

namespace WebQuanAn.DataAccess.Repository.IRepository
{
    public interface  IApplicationRoleRepository : IRepository<ApplicationRole>
    {
        void Update(ApplicationRole applicationRole);
    }
}

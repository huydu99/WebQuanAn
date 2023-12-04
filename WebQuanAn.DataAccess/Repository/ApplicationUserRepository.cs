using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebQuanAn.DataAccess.Repository;
using WebQuanAn.DataAccess.Repository.IRepository;
using WebQuanAn.DataAcess.Data;
using WebQuanAn.Models;

namespace WebQuanAn.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser> ,IApplicationUserRepository
    {
        private ApplicationDbContext _context;
        public ApplicationUserRepository(ApplicationDbContext context) : base(context) 
        {
            _context = context;
        }
        public void Update(ApplicationUser obj)
        {
		    _context.ApplicationUsers.Update(obj);
		}

    }
}

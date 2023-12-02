﻿using System;
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
            var user = _context.ApplicationUsers.FirstOrDefault(u => u.Id == obj.Id);   
            if(user != null)
            {
                user.FirstName = obj.FirstName; 
                user.LastName = obj.LastName;   
                user.PhoneNumber = obj.PhoneNumber;
                user.Address = obj.Address; 
            }
        }

    }
}

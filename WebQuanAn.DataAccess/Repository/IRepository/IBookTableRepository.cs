﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebQuanAn.DataAccess.Migrations;
using WebQuanAn.Models;

namespace WebQuanAn.DataAccess.Repository.IRepository
{
    public interface IBookTableRepository : IRepository<BookTable>
    {
        void Update(BookTable bookTable);
    }
}

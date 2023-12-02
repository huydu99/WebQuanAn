using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebQuanAn.DataAccess.Migrations;
using WebQuanAn.DataAccess.Repository.IRepository;
using WebQuanAn.DataAcess.Data;
using WebQuanAn.Models;

namespace WebQuanAn.DataAccess.Repository
{
    public class BookTableRepository : Repository<BookTable>, IBookTableRepository
    {
        private readonly ApplicationDbContext _context;
        public BookTableRepository(ApplicationDbContext db) : base(db)
        {
            _context = db;
        }

        public void Update(BookTable bookTable)
        {
            _context.BookTables.Update(bookTable);
        }
    }
}

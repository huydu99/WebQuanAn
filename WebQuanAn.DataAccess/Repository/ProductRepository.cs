﻿using WebQuanAn.DataAccess.Repository.IRepository;
using WebQuanAn.DataAcess.Data;
using WebQuanAn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebQuanAn.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        

        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = obj.Name;
                objFromDb.Description = obj.Description;
                objFromDb.ShortDescription = obj.ShortDescription;  
                objFromDb.Price = obj.Price;
                objFromDb.UpdateAt = DateTime.Now;
                objFromDb.PromotionPrice = obj.PromotionPrice;    
                objFromDb.CategoryId = obj.CategoryId;
                objFromDb.ProductImages = obj.ProductImages;
            }
        }
    }
}

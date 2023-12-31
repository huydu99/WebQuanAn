﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebQuanAn.Models.ViewModels
{
	public class ProductCategoryVM
	{
		public IEnumerable<Product> Products { get; set; }
		public IEnumerable<Category> Categories { get; set; }
		public PageInfo PageInfo { get; set; }
	}
}

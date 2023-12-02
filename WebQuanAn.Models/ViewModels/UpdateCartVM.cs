using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebQuanAn.Models.ViewModels
{
	public class UpdateCartVM
	{
		public int CartId { get; set; }	
		public int ProductId { get;set; }
		public int Quantity { get; set; }
	}
}

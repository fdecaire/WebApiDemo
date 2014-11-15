using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemo.Models
{
	public class InventoryRecord
	{
		public int ProductId { get; set; }
		public string Name { get; set; }
		public int Quantity { get; set; }
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemo.Models
{
	public class ApiRequest
	{
		public int StoreId { get; set; }
		public List<int> ProductId { get; set; }
	}
}
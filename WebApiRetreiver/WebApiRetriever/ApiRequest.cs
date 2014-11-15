using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiRetreiver
{
	public class ApiRequest
	{
		public int StoreId { get; set; }
		public List<int> ProductId = new List<int>();
	}
}

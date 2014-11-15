using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemo.Models
{
	[Serializable]
	public class ApiResponse
	{
		public List<InventoryRecord> Records = new List<InventoryRecord>();
	}
}
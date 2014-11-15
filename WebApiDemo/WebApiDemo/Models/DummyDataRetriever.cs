using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemo.Models
{
	public static class DummyDataRetriever
	{
		public static List<InventoryRecord> ReadData(List<int> productIdList)
		{
			List<InventoryRecord> result = new List<InventoryRecord>();

			if (productIdList.Contains(1))
			{
				result.Add(new InventoryRecord
				{
					ProductId = 1,
					Name = "Dish soap",
					Quantity = 5
				});
			}

			if (productIdList.Contains(2))
			{
				result.Add(new InventoryRecord
				{
					ProductId = 2,
					Name = "Spoon",
					Quantity = 12
				});
			}

			if (productIdList.Contains(3))
			{
				result.Add(new InventoryRecord
				{
					ProductId = 3,
					Name = "Fork",
					Quantity = 6
				});
			}

			if (productIdList.Contains(4))
			{
				result.Add(new InventoryRecord
				{
					ProductId = 4,
					Name = "Knife",
					Quantity = 3
				});
			}

			return result;
		}
	}
}
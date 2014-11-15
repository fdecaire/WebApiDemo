using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiRetreiver
{
	public static class StringHelpers
	{
		public static int ToInteger(this string s)
		{
			if (s == null)
			{
				return 0;
			}

			int valueAsInteger;
			var successfulConversion = int.TryParse(s, out valueAsInteger);
			if (!successfulConversion)
			{
				return 0;
			}

			return valueAsInteger;
		}
	}
}

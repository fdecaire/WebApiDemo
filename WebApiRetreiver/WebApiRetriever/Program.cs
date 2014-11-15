using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Configuration;
using log4net;
using System.IO;
using Newtonsoft.Json;

namespace WebApiRetreiver
{
	class Program
	{
		static void Main(string[] args)
		{
			WebApiRetriever webApiRetreiver = new WebApiRetriever();

			webApiRetreiver.Retreiver();
		}
	}
}

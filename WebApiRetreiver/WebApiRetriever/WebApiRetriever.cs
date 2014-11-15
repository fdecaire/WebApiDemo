using System.Configuration;
using System.IO;
using System.Net;
using log4net;
using Newtonsoft.Json;
using System.Text;
using System;

namespace WebApiRetreiver
{
	public class WebApiRetriever
	{
		private readonly string apiURLLocation = ConfigurationManager.AppSettings["ApiURLLocation"];
		private readonly string apiAuthorization = ConfigurationManager.AppSettings["ApiCredential"];

		public void Retreiver()
		{
			var serializer = new JsonSerializer();

			var apiRequest = new ApiRequest
			{
				StoreId = 1,
				ProductId = { 2, 3, 4 }
			};

			var request = (HttpWebRequest)WebRequest.Create(apiURLLocation + "");
			request.ContentType = "application/json; charset=utf-8";
			request.Accept = "application/json";
			request.Method = "POST";
			request.Headers.Add(HttpRequestHeader.Authorization, apiAuthorization);
			request.UserAgent = "ApiRequest";

			//Writes the ApiRequest Json object to request 
			using (var streamWriter = new StreamWriter(request.GetRequestStream()))
			{
				streamWriter.Write(JsonConvert.SerializeObject(apiRequest));
				streamWriter.Flush();
			}

			var httpResponse = (HttpWebResponse)request.GetResponse();

			using (var streamreader = new StreamReader(httpResponse.GetResponseStream()))
			using (var reader = new JsonTextReader(streamreader))
			{
				var storeInventory = serializer.Deserialize<ApiResponse>(reader);
			}
		}
	}
}

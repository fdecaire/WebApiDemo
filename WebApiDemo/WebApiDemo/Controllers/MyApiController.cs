using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDemo.Models;
using Newtonsoft.Json;
using System.Text;

//http://www.franksdomain.com/WebApiDemo/api/MyApi
namespace WebApiDemo.Controllers
{
	public class MyApiController : ApiController
	{
		[HttpPost]
		[ActionName("GetInventory")]
		public HttpResponseMessage GetInventory([FromBody] ApiRequest request)
		{
			if (request == null)
			{
				return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Request was null");
			}
			
			// check authentication
			var auth = ControllerContext.Request.Headers.Authorization;
			
			// simple demonstration of user rights checking.
			if (auth.Scheme != "ABCD")
			{
				return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Invalid Credentials");
			}
		
			ApiResponse apiResponse = new ApiResponse();

			// read data from a database
			apiResponse.Records = DummyDataRetriever.ReadData(request.ProductId);

			// convert the data into json
			var jsonData = JsonConvert.SerializeObject(apiResponse);

			var resp = new HttpResponseMessage();
			resp.Content = new StringContent(jsonData, Encoding.UTF8, "application/json");
			return resp;
		}
	}
}

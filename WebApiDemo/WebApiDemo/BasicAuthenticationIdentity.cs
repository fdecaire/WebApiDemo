using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Principal;

namespace WebApiDemo
{
	public class BasicAuthenticationIdentity : GenericIdentity
	{
		public BasicAuthenticationIdentity(int storeId, Guid apiKey)
			: base(storeId.ToString(), "Basic")
		{
			this.ApiKey = apiKey;
			this.StoreId = storeId;
		}

		/// <summary>
		/// Basic Auth Password for custom authentication
		/// </summary>
		/// 
		public int StoreId { get; set; }
		public Guid ApiKey { get; set; }
	}
}
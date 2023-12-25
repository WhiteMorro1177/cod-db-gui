using COD_UI.DTO;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace COD_UI
{
	public struct Data
	{
		// defults
		public const string TB_USERNAME_DEFAULT_VALUE = "Enter your username";
		public const string TB_PASSWORD_DEFAULT_VALUE = "Enter your password";



		// app settings
		public static string USERNAME = null;

		// connection settings
		public static RestClient client = new RestClient("http://localhost:3002");
	}
}

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.Logging;

//namespace Messages
//{
//	public class Program
//	{
//		public static void Main(string[] args)
//		{
//			CreateWebHostBuilder(args).Build().Run();
//		}

//		public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
//				WebHost.CreateDefaultBuilder(args)
//						.UseStartup<Startup>();
//	}
//}
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Messages
{
	public class Program
	{
		public static void Main()
		{
			WebHost
				.CreateDefaultBuilder()
				.UseStartup<Startup>()
				.Build()
				.Run();
		}
	}
}

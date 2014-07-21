using System;
using Nancy.Hosting.Self;
using System.Threading;
using System.Linq;
using System.Configuration;

namespace HelloWorld
{
	class MainClass
	{
		private const string HOST_KEY = "host";

		public static void Main (string[] args)
		{
			var uri = ConfigurationManager.AppSettings [HOST_KEY];

			string port = string.Empty;
			if (args.Length > 0) {
				int tmp;
				if (int.TryParse (args [0], out tmp)) {
					port = tmp.ToString ();

					var host = new NancyHost (new Uri (uri + ":" + port), new Uri("http://0.0.0.0:" + port));

					host.Start (); 

					while(true)
					{
						Console.ReadLine();
					}
				} 
			}
		}
	}
}
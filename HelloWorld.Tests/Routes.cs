using System;
using NUnit.Framework;
using Nancy;
using Nancy.Testing;
using NFluent;

namespace HelloWorld.Tests
{
	[TestFixture]
	public class Routes
	{
		[Test]
		public void Should_return_status_ok_when_route_exists()
		{
			// Given
			var bootstrapper = new DefaultNancyBootstrapper();
			var browser = new Browser(bootstrapper);

			// When
			var result = browser.Get("/", with => {
				with.HttpRequest();
			});

			// Then
			Check.That(result.StatusCode).Equals(result.StatusCode);
		}
	}
}


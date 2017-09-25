using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Moq;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
		public class Startup
		{
			public void ConfigureServices(IServiceCollection services)
			{
				
				services.AddMvc();
			}

			public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider)
			{
				app.UseMvc();
			}
		}


		[Fact]
		public async void StartupWithDefaults()
		{
			var server = new TestServer(
				new WebHostBuilder()
					.UseWebRoot("")
					.UseContentRoot("")
					.UseEnvironment("Development")
					.UseStartup<Startup>());
			var client = server.CreateClient();
			var response = await client.GetAsync("/");
			response.EnsureSuccessStatusCode();
		}

	}
}

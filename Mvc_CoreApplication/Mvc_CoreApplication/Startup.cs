using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Mvc_CoreApplication
{
	public class Startup
	{
		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc(option => option.EnableEndpointRouting = false);
			services.AddSession(options =>
			{
				options.IdleTimeout = TimeSpan.FromMinutes(30);
			});
			services.AddResponseCaching();
			services.AddOutputCaching();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			app.UseMvc(routes =>
			{
				routes.MapRoute("Home", "Home/QueryPostTest", new { controller = "Home" , action = "QueryPostTest" });
				//routes.MapRoute("Home", "Home/QueryTest", new { controller = "Home", action = "QueryTest" });
				routes.MapRoute("Product", "Product/Create", new { controller = "Product", action = "Create" });
				routes.MapRoute("Customer", "Customer/Index", new { controller = "Customer", action = "Index" });
			});
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Error");
			}
			app.UseStatusCodePages("text/html", "We're <b>really</b> sorry, but something went wrong. Error code: {0}");
			app.UseStaticFiles();
			app.UseRouting();
			app.UseMvcWithDefaultRoute();
			app.UseSession();
			app.UseResponseCaching();
			app.UseOutputCaching();
			//app.UseEndpoints(endpoints =>
			//{
			//	endpoints.MapGet("/", async context =>
			//	{
			//		await context.Response.WriteAsync("Hello World!");
			//	});
			//});
		}
	}
}

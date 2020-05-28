using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjectName.ServicesInstallation;
//using Only installation namespace

namespace ProjectName
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{
			//invoking only the installation method
			services.servicesInstallation(Configuration);
		}

		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{

		}
	}
}

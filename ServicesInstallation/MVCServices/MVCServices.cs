using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ProjectName.ServicesInstallation.MVCServices
{
	public class MVCServices : IServiceInstallation
	{
		public void InstallServices(IServiceCollection service, IConfiguration configuration)
		{
			service.Configure<CookiePolicyOptions>(options =>
			{
				options.CheckConsentNeeded = context => true;
				options.MinimumSameSitePolicy = SameSiteMode.None;
			});


			service.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
		}
	}
}

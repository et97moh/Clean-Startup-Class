using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace ProjectName.ServicesInstallation
{
    public static class InstallationOfServices
	{
		public static void servicesInstallation(this IServiceCollection services, IConfiguration configuration)
		{
			var _services = typeof(Startup).Assembly.ExportedTypes
				.Where(selection =>
					typeof(IServiceInstallation)
					.IsAssignableFrom(selection) && !selection.IsInterface && !selection.IsAbstract)
				.Select(Activator.CreateInstance).Cast<IServiceInstallation>().ToList();

			_services.ForEach(_service => _service.InstallServices(services, configuration));
		}
	}
}

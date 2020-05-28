using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ProjectName.ServicesInstallation
{
	public interface IServiceInstallation
	{
		void InstallServices(IServiceCollection service, IConfiguration configuration);
	}
}

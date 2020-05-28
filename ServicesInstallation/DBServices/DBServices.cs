using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ProjectName.ServicesInstallation.DBServices
{
    public class DBServices : IServiceInstallation
	{
		public void InstallServices(IServiceCollection service, IConfiguration configuration)
		{
			service.AddDbContext<DBContexName>(options =>
			options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

		}
	}
}

# Clean-Startup-Class
make startup class more readable, maintainable and single responsibility for each services set !
# Main info about it.

we use this structure to make the startup class more clean!

```c#
public void ConfigureServices(IServiceCollection services)
{
			//invoking only the installation method
			services.servicesInstallation(Configuration);
}
```
# Benefit
1- Minimize namespaces that used in the Startup class.
2- Make the class more readable.
3- isolated each set of services together.
4- easy maintainable each one.

# Example
The MVC servies
```c#
#inherit from the IServiceInstallation that contain only InstallServices method.
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
```
https://i.ibb.co/CvfjCwG/1-services-file.png
https://i.ibb.co/dPFd92G/1-services-file.png
https://i.ibb.co/9NxNFc8/2-installation-Method.png
https://i.ibb.co/JCkyYz8/file-Explorer.png

# Note : Change the namespace, i use random name.

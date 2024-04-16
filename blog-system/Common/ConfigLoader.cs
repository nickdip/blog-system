using System;
namespace blog_system.Config
{
	public class ConfigLoader
	{
		private readonly IConfiguration Configuration;

		public ConfigLoader(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration GetConfiguration()
		{
			return Configuration;
		}

	}
}

// Make an instance of this
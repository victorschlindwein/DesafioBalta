using DesafioBalta.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioBalta.Context { 
	public class ApiContext : DbContext
    {
		public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }

        public void configureServices(IServiceCollection services)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.Development.json")
                .Build();

            var connectionString = configuration.GetConnectionString("ConexaoPadrao");
        }

        public DbSet<User> Users { get; set; }
    }
}
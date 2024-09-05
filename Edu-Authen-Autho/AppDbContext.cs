using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Edu_Authen_Autho
{
	public class AppDbContext:IdentityDbContext<IdentityUser>
	{
		private readonly IConfiguration _configuration;
		public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration) : base(options)
		{
			_configuration = configuration;
		}
	}
}

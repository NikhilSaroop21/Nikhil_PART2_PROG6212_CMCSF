using Microsoft.AspNetCore.Identity;

namespace Nikhil_PART2_PROG6212_CMCSF.Models
{

	public class User : IdentityUser
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }

	}
}
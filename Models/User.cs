using Microsoft.AspNetCore.Identity; // Importing the Identity namespace for user authentication and authorization.

namespace Nikhil_PART2_PROG6212_CMCSF.Models // Defining the namespace for the project.
{
    // Defining the 'User' class, which inherits from 'IdentityUser' to integrate ASP.NET Core Identity functionality.
    public class User : IdentityUser
    {
        // Property to store the first name of the user.
        public string FirstName { get; set; }

        // Property to store the last name of the user.
        public string LastName { get; set; }
    }
}

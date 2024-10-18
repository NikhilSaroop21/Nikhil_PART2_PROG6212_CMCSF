using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;


namespace Nikhil_PART2_PROG6212_CMCSF.Controllers
{
    [Authorize]
    public class AppRolesController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public AppRolesController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }







        // This action method handles HTTP requests to the 'Index' action of the controller.
        public IActionResult Index()
        {
            // Retrieves all roles from the Role Manager and stores them in the 'roles' variable.
            var roles = _roleManager.Roles;

            // Passes the 'roles' data to the 'Index' view for rendering.
            return View(roles);
        }






        // This action method handles GET requests to the 'Create' action of the controller.
        [HttpGet] // Specifies that this method responds only to HTTP GET requests.
        public IActionResult Create()
        {
            // Returns the 'Create' view to the user, typically rendering a form for data input.
            return View();
        }








        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole model)
        {
            if (!_roleManager.RoleExistsAsync(model.Name).GetAwaiter().GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole(model.Name)).GetAwaiter().GetResult();
            }
            return RedirectToAction("Index");
        }
    }
}


// code attribution // W3schools // https://www.w3schools.com/cs/index.php

// code attribution //Microsoft //https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started

// code attribution //Microsoft //https://learn.microsoft.com/en-us/azure/storage/blobs/storage-blob-dotnet-get-started?tabs=azure-ad

// code attribution //Bootswatch //https://bootswatch.com/

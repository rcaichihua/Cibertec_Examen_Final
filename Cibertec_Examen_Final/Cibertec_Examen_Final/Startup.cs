using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using Cibertec_Examen_Final.Models;

[assembly: OwinStartupAttribute(typeof(Cibertec_Examen_Final.Startup))]
namespace Cibertec_Examen_Final
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            CreateUserAndRole();
            ConfigureAuth(app);
            ConfigInjector();
        }

        internal void CreateUserAndRole()
        {
            using (var context = new ApplicationDbContext())
            {

                var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
                var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

                // In Startup iam creating first Admin Role and creating a default Admin User    
                if (!roleManager.RoleExists("Admin"))
                {

                    // first we create Admin rool   
                    var role = new IdentityRole();
                    role.Name = "Admin";
                    roleManager.Create(role);

                    //Here we create a Admin super user who will maintain the website                  

                    var user = new ApplicationUser
                    {
                        UserName = "rcaichihua@gmail.com",
                        Email = "rcaichihua@gmail.com"
                    };

                    string userPassword = "V3rg5r5123*";

                    var userCreation = userManager.Create(user, userPassword);

                    //Add default User to Role Admin   
                    if (userCreation.Succeeded)
                        userManager.AddToRole(user.Id, "Admin");
                }
  
                if (!roleManager.RoleExists("Gestor"))
                {
                    var role = new IdentityRole
                    {
                        Name = "Gestor"
                    };
                    roleManager.Create(role);

                }
 
                if (!roleManager.RoleExists("Empleado"))
                {
                    var role = new IdentityRole
                    {
                        Name = "Empleado"
                    };
                    roleManager.Create(role);

                }
            }
        }
    }
}

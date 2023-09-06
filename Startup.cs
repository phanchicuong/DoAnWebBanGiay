using WebsiteBanGiay.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(WebsiteBanGiay.Startup))]

namespace WebsiteBanGiay
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions()
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/login")
            });
            this.CreateRolesAndUser();
        }
        public void CreateRolesAndUser()
        {
            var roleManage = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new AppDBContext()));
            var appDBContext = new AppDBContext();
            var appUserStore = new AppUserStore(appDBContext);
            var userManager = new AppUserManager(appUserStore);


            // admin
            if (!roleManage.RoleExists("Admin"))
            {
                var role = new IdentityRole();
                role.Name = "Admin";
                roleManage.Create(role);
            }
            if (userManager.FindByName("admin") == null)
            {
                var user = new AppUser();
                user.UserName = "ChiCuong";
                user.Email = "ChiCuong@gmail.com";
                user.Anh = "admin.png";
                string userPwd = "16082002Aa";




                var checkUser = userManager.Create(user, userPwd);//save kq
                if (checkUser.Succeeded)//tao thanh cong
                {
                    userManager.AddToRole(user.Id, "Admin");
                }
            }

            // Manager
            if (!roleManage.RoleExists("Manager"))
            {
                var role = new IdentityRole();
                role.Name = "Manager";
                roleManage.Create(role);
            }
            if (userManager.FindByName("manager") == null)
            {
                var user = new AppUser();
                user.UserName = "CuongPhan";
                user.Email = "CuongPhan123@gmail.com";
                string userPwd = "123456789";

                var checkUser = userManager.Create(user, userPwd);
                if (checkUser.Succeeded)
                {
                    userManager.AddToRole(user.Id, "Manager");
                }
            }

            //Customer
            if (!roleManage.RoleExists("Customer"))
            {
                var role = new IdentityRole();
                role.Name = "Customer";
                roleManage.Create(role);
            }

        }
    }
}

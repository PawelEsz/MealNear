using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MealNear.Startup))]
namespace MealNear
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

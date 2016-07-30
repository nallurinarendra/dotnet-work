using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmployerForm.Startup))]
namespace EmployerForm
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

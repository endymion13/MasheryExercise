using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MasheryMVCExercise.Startup))]
namespace MasheryMVCExercise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

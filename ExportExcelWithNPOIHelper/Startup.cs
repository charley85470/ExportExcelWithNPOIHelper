using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExportExcelWithNPOIHelper.Startup))]
namespace ExportExcelWithNPOIHelper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

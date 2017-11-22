using System.Reflection;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Routing;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework.Config;
using ReefTank.Models;
using ReefTank.Models.Base;

namespace ReefTank.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            MvcHandler.DisableMvcResponseHeader = true;

            InitializeDomain();
        }

        private static void InitializeDomain()
        {
            var assembly = Assembly.GetAssembly(typeof(Creature));
            var assemblies = new[] { assembly };

            //Set database configuration
            var path = HostingEnvironment.MapPath(@"~/Config/ActiveRecord.cfg.config");
            var config = new XmlConfigurationSource(path);

            ActiveRecordStarter.Initialize(assemblies, config);
        }
    }
}

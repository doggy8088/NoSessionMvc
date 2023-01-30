using System.Web.Mvc;

namespace NoSessionMvc.Controllers
{
    public abstract class BaseController : Controller
    {
        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            base.Initialize(requestContext);
            
            TempDataProvider = new CookieTempDataProvider(requestContext.HttpContext);
            
            //TempDataProvider = new NoTempDataProvider();
        }
    }
}
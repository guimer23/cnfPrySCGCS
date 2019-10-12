using System.Web.Mvc;

namespace cnfPrySCGCS.Areas.cnfDashboard
{
    public class cnfDashboardAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "cnfDashboard";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "cnfDashboard_default",
                "cnfDashboard/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
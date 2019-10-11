using System.Web.Mvc;

namespace cnfPrySCGCS.Areas.cnfCmbios
{
    public class cnfCmbiosAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "cnfCmbios";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "cnfCmbios_default",
                "cnfCmbios/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
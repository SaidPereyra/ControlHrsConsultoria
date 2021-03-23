using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlHrsConsultoria.Filters
{
    public class VerificaSesion : ActionFilterAttribute
    {
        private Models.Usuario isUser;
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                base.OnActionExecuting(filterContext);

                isUser = (Models.Usuario)HttpContext.Current.Session["User"];
                if (isUser == null)
                {
                    if (filterContext.Controller is Controllers.AccessController == false)
                    {
                        filterContext.HttpContext.Response.Redirect("/Access/Index");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString()); //modificar error
            }
        }

    }
}
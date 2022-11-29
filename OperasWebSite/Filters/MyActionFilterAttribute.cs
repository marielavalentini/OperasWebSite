using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OperasWebSite.Filters
{
    public class MyActionFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("Antes de invocar el action - OnActionExecuting");
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("Despues de invocar el action - OnActionExecuted");
        }
    }
}
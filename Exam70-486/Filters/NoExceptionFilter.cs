using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exam70_486.Filters
{
    public class NoExceptionFilter : HandleErrorAttribute
    {
        public NoExceptionFilter()
        {
        }

        public override void OnException(ExceptionContext filterContext)
        {
            Debug.WriteLine("Exception occured");
        }
        
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Web.Infrastructure.CustomFilters
{
    public class RedirectExceptionAttribute : ExceptionFilterAttribute
    {
        private readonly Type exceptionType;

        public RedirectExceptionAttribute(Type exceptionType)
        {
            this.exceptionType = exceptionType;
        }

        public override void OnException(ExceptionContext context)
        {
            if (exceptionType == null || exceptionType == context.Exception.GetType())
            {
                context.Result = new RedirectResult("/");
            }
        }
    }
}

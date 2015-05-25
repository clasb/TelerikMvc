using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using DataAccessModel;
using Telerik.OpenAccess;

namespace TelerikMvc
{
    class ContextFactory
    {
        private static readonly string contextKey = typeof(EntitiesModel).FullName;

        public static EntitiesModel GetContextPerRequest()
        {
            HttpContext httpContext = HttpContext.Current;
            if (httpContext == null)
            {
                return new EntitiesModel();
            }
            else
            {
                EntitiesModel context = httpContext.Items[contextKey] as EntitiesModel;

                if (context == null)
                {
                    context = new EntitiesModel();
                    httpContext.Items[contextKey] = context;
                }

                return context;
            }
        }
    }
}

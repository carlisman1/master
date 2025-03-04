﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Mvc_SEGUNDO_EXAMEN_PRACTICO_AZURE_JCMG.Filters
{
    public class AuthorizeUsuariosAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var user = context.HttpContext.User;
            if (user.Identity.IsAuthenticated == false)
            {
                RouteValueDictionary routeLogin = new(new
                {
                    controller = "Managed",
                    action = "Login"
                });

                context.Result = new RedirectToRouteResult(routeLogin);
            }
        }
    }
}

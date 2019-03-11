using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFotoCore.Filters
{
    public class AuthorizedUserAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            //SOLO QUEREMOS QUE ENTREN LOS EMPLEADOS
            //PERO VALIDAREMOS POR ROLES PARA 
            //PRESIDENTE, DIRECTOR Y ANALISTA
            var usuario = context.HttpContext.User;
            bool isadmin = usuario.IsInRole("ADMINISTRATOR");
            if (usuario.Identity.IsAuthenticated == false)
            {
                //SI NO ESTA VALIDADO, LO ENVIAMOS A LOGIN
                //CONTROLLER, ACTION
                RouteValueDictionary rutalogin = new RouteValueDictionary( 
                    new {
                        controller = "Login",
                        action = "login"
                    });
                RedirectToRouteResult action = new RedirectToRouteResult(rutalogin);
                context.Result = action;
            }
        }
    }
}

﻿using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace api
{
   public class AuthorizationProvider:OAuthAuthorizationServerProvider
    {
       public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
       {
           context.Validated();
       }
       public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
       {

           context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin",new []{"*"});
           var identity = new ClaimsIdentity(context.Options.AuthenticationType);
           identity.AddClaim(new Claim("role", "user"));
           context.Validated(identity);

       }
    }
}

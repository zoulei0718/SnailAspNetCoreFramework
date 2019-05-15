﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Web.Security
{
    public class AuthHandler:IAuthorizationHandler
    {
        public Task HandleAsync(AuthorizationHandlerContext context)
        {
            return Task.CompletedTask;
        }
    }
}
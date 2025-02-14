﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace EmployeeManagement.Security
{
    public class SuperAdminHandler : AuthorizationHandler<ManageRolesAndClaimsRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ManageRolesAndClaimsRequirement requirement)
        {
            if(context.User.IsInRole("Super Admin"))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}

﻿using ApplicationCore.Entity;
using System;
using System.Collections.Generic;

namespace Web.Domain
{
    public class ResourceModel
    {
        private Resource _resource;

        public ResourceModel(int id)
        {

        }

        public ResourceModel(string resourceKey)
        {

        }

        public static ResourceModel CreateResourceModel(int id)
        {
            return new ResourceModel(id);
        }

        public List<Role> AllPermissionRoles()
        {
            throw new NotImplementedException();
        }

    }
}

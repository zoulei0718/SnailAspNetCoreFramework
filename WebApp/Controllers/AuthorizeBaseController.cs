﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Entity;

namespace WebApp.Controllers
{
    [Authorize(Policy = ConstValues.PermissionPolicy)]
    public class AuthorizeBaseController : ControllerBase
    {
        public DatabaseContext _db;

        public AuthorizeBaseController(DatabaseContext db)
        {
            _db = db;
        }
    }
}
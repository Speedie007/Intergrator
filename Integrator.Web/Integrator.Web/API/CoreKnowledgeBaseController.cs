﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Integrator.Web.API
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class CoreKnowledgeBaseController : ControllerBase
    {

    }
}
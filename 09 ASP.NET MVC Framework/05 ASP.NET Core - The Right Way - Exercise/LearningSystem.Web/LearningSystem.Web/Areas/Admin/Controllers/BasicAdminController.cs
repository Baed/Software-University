using LearningSystem.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Web.Areas.Admin.Controllers
{
    [Area(AdminConstants.ADMIN_AREA)]
    [Authorize(Roles = IdentitiesConstants.ADMINISTRATOR_ROLE)]
    public abstract class BasicAdminController : Controller
    {
        
    }
}

namespace EmeraldBotany.Web.Areas.Administration.Controllers
{
    using EmeraldBotany.Common;
    using EmeraldBotany.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}

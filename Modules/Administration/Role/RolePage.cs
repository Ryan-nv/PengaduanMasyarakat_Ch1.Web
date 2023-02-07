using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace PengaduanMasyarakat.Administration.Pages
{
    [PageAuthorize(typeof(RoleRow))]
    public class RoleController : Controller
    {
        [Route("Administration/Role")]
        public ActionResult Index()
        {
            return this.GridPage("@/Administration/Role/RolePage",
                RoleRow.Fields.PageTitle());
        }
    }
}
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace PengaduanMasyarakat.Administration.Pages
{
    [PageAuthorize(typeof(LanguageRow))]
    public class LanguageController : Controller
    {
        [Route("Administration/Language")]
        public ActionResult Index()
        {
            return this.GridPage("@/Administration/Language/LanguagePage",
                LanguageRow.Fields.PageTitle());
        }
    }
}
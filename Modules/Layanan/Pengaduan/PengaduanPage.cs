using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace PengaduanMasyarakat.Layanan.Pages 
{

    [PageAuthorize(typeof(PengaduanRow))]
    public class PengaduanController : Controller
    {
        [Route("Layanan/Pengaduan")]
        public ActionResult Index()
        {
            return this.GridPage("@/Layanan/Pengaduan/PengaduanPage",
                PengaduanRow.Fields.PageTitle());
        }
    }
}
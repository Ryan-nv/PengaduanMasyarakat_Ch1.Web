using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace PengaduanMasyarakat.Layanan.Pages 
{

    [PageAuthorize(typeof(TanggapanRow))]
    public class TanggapanController : Controller
    {
        [Route("Layanan/Tanggapan")]
        public ActionResult Index()
        {
            return this.GridPage("@/Layanan/Tanggapan/TanggapanPage",
                TanggapanRow.Fields.PageTitle());
        }
    }
}
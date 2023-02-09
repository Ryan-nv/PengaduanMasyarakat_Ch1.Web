using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<PengaduanMasyarakat.Layanan.TanggapanRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = PengaduanMasyarakat.Layanan.TanggapanRow;
using System.Security.Claims;
using System.Linq;
namespace PengaduanMasyarakat.Layanan
{
    public interface ITanggapanSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class TanggapanSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITanggapanSaveHandler
    {
        public TanggapanSaveHandler(IRequestContext context)
             : base(context)
        {
        }

        protected override void BeforeSave()
        {
            base.BeforeSave();
            if (IsCreate)
            {
                var claim = Context.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier);
                var idUser = int.Parse(claim.Value);
                base.Row.IdPetugas = idUser;
            }
            else if (IsUpdate)
            {
                base.Row.IdPetugas = Old.IdPetugas;
            }
        }
    }
}
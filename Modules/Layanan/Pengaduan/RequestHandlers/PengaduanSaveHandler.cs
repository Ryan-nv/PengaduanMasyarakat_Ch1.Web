using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<PengaduanMasyarakat.Layanan.PengaduanRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = PengaduanMasyarakat.Layanan.PengaduanRow;
using System.Security.Claims;
using System.Linq;

namespace PengaduanMasyarakat.Layanan
{
    public interface IPengaduanSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

    public class PengaduanSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPengaduanSaveHandler
    {
        public PengaduanSaveHandler(IRequestContext context)
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
                base.Row.UserId = idUser;
            }
            else if (IsUpdate)
            {
                base.Row.UserId = Old.UserId;
            }

        }
    }
}
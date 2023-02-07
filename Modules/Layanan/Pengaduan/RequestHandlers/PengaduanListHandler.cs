using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<PengaduanMasyarakat.Layanan.PengaduanRow>;
using MyRow = PengaduanMasyarakat.Layanan.PengaduanRow;

namespace PengaduanMasyarakat.Layanan
{
    public interface IPengaduanListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class PengaduanListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPengaduanListHandler
    {
        public PengaduanListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}
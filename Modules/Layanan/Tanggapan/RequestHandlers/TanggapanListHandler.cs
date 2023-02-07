using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<PengaduanMasyarakat.Layanan.TanggapanRow>;
using MyRow = PengaduanMasyarakat.Layanan.TanggapanRow;

namespace PengaduanMasyarakat.Layanan
{
    public interface ITanggapanListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class TanggapanListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITanggapanListHandler
    {
        public TanggapanListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}
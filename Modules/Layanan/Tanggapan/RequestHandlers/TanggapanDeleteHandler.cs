using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = PengaduanMasyarakat.Layanan.TanggapanRow;

namespace PengaduanMasyarakat.Layanan
{
    public interface ITanggapanDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class TanggapanDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITanggapanDeleteHandler
    {
        public TanggapanDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}
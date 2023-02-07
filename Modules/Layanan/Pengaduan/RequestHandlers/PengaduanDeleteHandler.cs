using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = PengaduanMasyarakat.Layanan.PengaduanRow;

namespace PengaduanMasyarakat.Layanan
{
    public interface IPengaduanDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class PengaduanDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPengaduanDeleteHandler
    {
        public PengaduanDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}
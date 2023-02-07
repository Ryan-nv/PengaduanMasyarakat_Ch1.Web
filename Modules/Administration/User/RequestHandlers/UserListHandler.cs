using Serenity.Services;
using MyRow = PengaduanMasyarakat.Administration.UserRow;
using MyRequest = PengaduanMasyarakat.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<PengaduanMasyarakat.Administration.UserRow>;

namespace PengaduanMasyarakat.Administration
{
    public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

    public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
    {
        public UserListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}
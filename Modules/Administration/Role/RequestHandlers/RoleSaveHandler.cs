using Serenity.Services;
using MyRow = PengaduanMasyarakat.Administration.RoleRow;
using MyRequest = Serenity.Services.SaveRequest<PengaduanMasyarakat.Administration.RoleRow>;
using MyResponse = Serenity.Services.SaveResponse;


namespace PengaduanMasyarakat.Administration
{
    public interface IRoleSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
    public class RoleSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IRoleSaveHandler
    {
        public RoleSaveHandler(IRequestContext context)
             : base(context)
        {
        }

        protected override void InvalidateCacheOnCommit()
        {
            base.InvalidateCacheOnCommit();

            Cache.InvalidateOnCommit(UnitOfWork, UserPermissionRow.Fields);
            Cache.InvalidateOnCommit(UnitOfWork, RolePermissionRow.Fields);
        }
    }
}
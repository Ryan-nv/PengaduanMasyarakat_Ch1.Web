using Serenity.Services;

namespace PengaduanMasyarakat.Administration
{
    public class UserRoleListRequest : ServiceRequest
    {
        public int? UserID { get; set; }
    }
}
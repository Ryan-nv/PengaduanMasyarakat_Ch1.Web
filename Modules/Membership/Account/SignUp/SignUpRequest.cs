using Serenity.Services;
using System;

namespace PengaduanMasyarakat.Membership
{
    public class SignUpRequest : ServiceRequest
    {
        public String DisplayName { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String Nik { get; set; }
        public String Telp { get; set; }
    }
}
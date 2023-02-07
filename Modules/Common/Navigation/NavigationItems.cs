using Serenity.Navigation;
using MyPages = PengaduanMasyarakat.Layanan.Pages;

[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "fa-tachometer")]

[assembly: NavigationMenu(2000, "Layanan", icon: "fa fa-address-book")]
[assembly: NavigationLink(2100, "Layanan/Pengaduan", typeof(MyPages.PengaduanController), icon: "fa fa-flag-o")]
[assembly: NavigationLink(2200, "Layanan/Tanggapan", typeof(MyPages.TanggapanController), icon: "fa fa-check-circle")]

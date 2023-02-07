using Serenity.Services;
using MyRow = PengaduanMasyarakat.Administration.LanguageRow;
using MyRequest = Serenity.Services.SaveRequest<PengaduanMasyarakat.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;


namespace PengaduanMasyarakat.Administration
{
    public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
    public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
    {
        public LanguageSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}
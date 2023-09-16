using stigzler.Screenscraper.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace stigzler.Screenscraper.Services
{
    public interface IGetDataService
    {
        Task<List<ApiGetOutcome>> GetUrlListData(List<string> UrlList);
    }
}
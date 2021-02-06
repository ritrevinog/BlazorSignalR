using BlazorSignalR.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSignalR.Server.Data
{
    public interface ILanguageService
    {
        Task<IEnumerable<Language>> GetAllLanguage();
        Task<Language> GetLanguageDetails(int id);
        Task<bool> InsertLanguage(Language language);
        Task<bool> UpdateLanguage(Language language);
        Task<bool> DeleteLanguage(int id);

        Task<bool> SaveLanguage(Language language);
    }
}

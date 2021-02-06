using BlazorSignalR.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSignalR.Server.Data
{
    public class LanguageService : ILanguageService
    {
        private readonly MyLanguagesContext _context;

        public LanguageService(MyLanguagesContext context)
        {
            _context = context;
        }

        public Task<bool> DeleteLanguage(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Language>> GetAllLanguage()
        {
            throw new NotImplementedException();
        }

        public Task<Language> GetLanguageDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertLanguage(Language language)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveLanguage(Language language)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateLanguage(Language language)
        {
            throw new NotImplementedException();
        }
    }
}

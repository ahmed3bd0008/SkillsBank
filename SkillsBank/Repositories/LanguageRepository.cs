using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp1_SkillsBank.Models;
using WebApp1_SkillsBank.Repositories.Interfaces;

namespace WebApp1_SkillsBank.Repositories
{
    public class LanguageRepository : ILanguageRepository
    {
        SkillsBankContext _DB;
        public LanguageRepository(SkillsBankContext DB)
        {
            _DB = DB;
        }

        public List<Language> GetLanguages()
        {
            return _DB.Languages.ToList();
        }
    }
}

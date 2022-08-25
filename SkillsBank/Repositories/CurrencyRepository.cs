using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp1_SkillsBank.Models;
using WebApp1_SkillsBank.Repositories.Interfaces;

namespace WebApp1_SkillsBank.Repositories
{
    public class CurrencyRepository : ICurrencyRepository
    {
        SkillsBankContext _DB;
        public CurrencyRepository(SkillsBankContext DB)
        {
            _DB = DB;
        }
        public List<Currency> GetCurrencies()
        {
            return _DB.Currencies.ToList();
        }
    }
}

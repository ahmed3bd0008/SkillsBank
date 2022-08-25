using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp1_SkillsBank.Models;
using WebApp1_SkillsBank.Repositories.Interfaces;

namespace WebApp1_SkillsBank.Repositories
{
    public class CrsTypeRepository : ICrsTypeRepository
    {
        SkillsBankContext _DB;
        public CrsTypeRepository(SkillsBankContext DB)
        {
            _DB = DB;
        }
        public List<CrsType> GetCrsTypes()
        {
            return _DB.CrsTypes.ToList();
        }
    }
}

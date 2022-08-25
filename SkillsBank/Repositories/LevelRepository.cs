using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp1_SkillsBank.Models;
using WebApp1_SkillsBank.Repositories.Interfaces;

namespace WebApp1_SkillsBank.Repositories
{
    public class LevelRepository : ILevelRepository
    {
        SkillsBankContext _DB;
        public LevelRepository(SkillsBankContext DB)
        {
            _DB = DB;
        }
        public List<CrsLevel> GetLevels()
        {
            return _DB.CrsLevels.ToList();
        }
    }
}

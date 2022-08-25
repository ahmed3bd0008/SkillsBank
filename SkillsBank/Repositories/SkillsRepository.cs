using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp1_SkillsBank.Models;
using WebApp1_SkillsBank.Repositories.Interfaces;

namespace WebApp1_SkillsBank.Repositories
{
    public class SkillsRepository : ISkillsRepository
    {
        SkillsBankContext _DB;
        public SkillsRepository(SkillsBankContext DB)
        {
            _DB = DB;
        }

        public List<Skills> GetSkills()
        {
            return _DB.Skills.ToList();
        }
    }
}

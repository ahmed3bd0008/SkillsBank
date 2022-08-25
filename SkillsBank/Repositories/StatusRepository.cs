using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp1_SkillsBank.Models;
using WebApp1_SkillsBank.Repositories.Interfaces;

namespace WebApp1_SkillsBank.Repositories
{
    public class StatusRepository : IStatusRepository
    {
        SkillsBankContext _DB;
        public StatusRepository(SkillsBankContext DB)
        {
            _DB = DB;
        }
        public List<CrsStatus> GetStatus()
        {
            return _DB.CrsStatus.ToList();
        }
    }
}

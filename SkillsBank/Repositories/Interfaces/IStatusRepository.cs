using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp1_SkillsBank.Models;

namespace WebApp1_SkillsBank.Repositories.Interfaces
{
    public interface IStatusRepository
    {
        List<CrsStatus> GetStatus();

    }
}

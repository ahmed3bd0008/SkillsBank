using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp1_SkillsBank.Models
{
    public class Skills
    {
        public int Id { get; set; }
        public string skillName { get; set; }
        public string skillAName { get; set; }

        public List<CrsSkills> crsSkills { get; set; }


    }
}

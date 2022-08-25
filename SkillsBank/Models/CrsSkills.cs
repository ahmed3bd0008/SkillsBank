using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace WebApp1_SkillsBank.Models
{
    public class CrsSkills
    {
        [ForeignKey("course")]
        public int CrsFK { get; set; }
        public Course course { get; set; }

        [ForeignKey("skill")]
        public int skillFK { get; set; }
        public Skills skill { get; set; }

    }
}

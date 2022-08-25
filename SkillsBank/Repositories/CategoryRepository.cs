using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp1_SkillsBank.Models;
using WebApp1_SkillsBank.Repositories.Interfaces;

namespace WebApp1_SkillsBank.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        SkillsBankContext _DB;
        public CategoryRepository(SkillsBankContext DB)
        {
            _DB = DB;
        }
        public List<Category> GetCategories()
        {
            return  _DB.Categories.ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp1_SkillsBank.Models;

namespace WebApp1_SkillsBank.Repositories.Interfaces
{
    public interface ICourseRepository
    {
        List<Course> GetAllCourses();
        Course GetCourseById(int id);

        //Task<Course> GetCrsByRefText(string refTxt);
        bool AddCourse(Course newCrs);
        bool EditCourse(int id, Course newCrs);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp1_SkillsBank.Models;
using WebApp1_SkillsBank.Repositories.Interfaces;

namespace WebApp1_SkillsBank.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        SkillsBankContext _DB;
        public CourseRepository(SkillsBankContext DB)
        {
            _DB = DB;
        }
        public List<Course> GetAllCourses()
        {
            return  _DB.Courses.ToList();
        }
        public bool AddCourse(Course newCrs)
        {
            
            _DB.Courses.Add(newCrs);
            _DB.SaveChanges();
            return true;
        }


        public Course GetCourseById(int id)
        {
            return _DB.Courses.FirstOrDefault(c => c.Id == id);
        }

        public bool EditCourse(int id, Course newCrs)
        {
            Course oldCrs = GetCourseById(id);

            oldCrs.name = newCrs.name;
            oldCrs.img = newCrs.img;
            oldCrs.Price = newCrs.Price;
            oldCrs.categoryFK = newCrs.categoryFK;
            oldCrs.crsLevelFK = newCrs.crsLevelFK;
            oldCrs.crsStatusFK = newCrs.crsStatusFK;
            oldCrs.startDate = newCrs.startDate;
            oldCrs.endDate = newCrs.endDate;
            oldCrs.description = newCrs.description;
            oldCrs.Aname = newCrs.Aname;
            oldCrs.Adescription = newCrs.Adescription;
            oldCrs.languageFK = newCrs.languageFK;
            oldCrs.CrsReferenceLink = newCrs.CrsReferenceLink;
            oldCrs.CrsReferenceText = newCrs.CrsReferenceText;
            oldCrs.CrsReleasedDate = newCrs.CrsReleasedDate;
            oldCrs.CrsRequirement = newCrs.CrsRequirement;
            oldCrs.CrsPromoLink = newCrs.CrsPromoLink;
            oldCrs.currencyFK = newCrs.currencyFK;
            oldCrs.duration = newCrs.duration;
            oldCrs.ApplicationDueDate = newCrs.ApplicationDueDate;
            oldCrs.VideoTranscript = newCrs.VideoTranscript;
            oldCrs.TotalHours = newCrs.TotalHours;
            oldCrs.minStudents = newCrs.minStudents;
            oldCrs.maxStudents = newCrs.maxStudents;


            _DB.Courses.Update(oldCrs);
            _DB.SaveChanges();

            return true;

        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp1_SkillsBank.Models;
using WebApp1_SkillsBank.Repositories.Interfaces;

namespace WebApp1_SkillsBank.Controllers
{
    public class CourseController : Controller
    {
        ICourseRepository _CrsRepository;
        ICategoryRepository _categoryRepository;
        ILanguageRepository _languageRepository;
        ISkillsRepository _skillsRepository;
        ICrsTypeRepository _crsTypeRepository;
        IStatusRepository _statusRepository;
        ILevelRepository _levelRepository;
        ICurrencyRepository _currencyRepository;

        public CourseController(ICourseRepository crsRepository, ICategoryRepository categoryRepository, 
            ILanguageRepository languageRepository, ISkillsRepository skillsRepository,
            ICrsTypeRepository crsTypeRepository, IStatusRepository statusRepository, ILevelRepository levelRepository,
            ICurrencyRepository currencyRepository)
        {
            _CrsRepository = crsRepository;
            _categoryRepository = categoryRepository;
            _languageRepository = languageRepository;
            _skillsRepository = skillsRepository;
            _crsTypeRepository = crsTypeRepository;
            _statusRepository = statusRepository;
            _levelRepository = levelRepository;
            _currencyRepository = currencyRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddCourse1()
        {
            ViewBag.categories = _categoryRepository.GetCategories() ;
            ViewBag.languages = _languageRepository.GetLanguages() ;
            ViewBag.skills = _skillsRepository.GetSkills();
            ViewBag.crsType = _crsTypeRepository.GetCrsTypes();
            ViewBag.Status = _statusRepository.GetStatus();
            ViewBag.levels = _levelRepository.GetLevels();
            ViewBag.currency = _currencyRepository.GetCurrencies();
            return View();
        }

        [HttpPost]
        public IActionResult AddCourse(Course newCrs)
        {
            if (ModelState.IsValid)
            {
                _CrsRepository.AddCourse(newCrs);
                return View("Index");
            }
            return View("AddCourse1");
        }

        [HttpPost]
        public IActionResult EditCourse(int id, Course ModifiedCrs)
        {
            if(ModelState.IsValid){
                _CrsRepository.EditCourse(id, ModifiedCrs);
                return View("Index");
            }
            return View("AddCourse1");
        }

        /* for validation on min&max students num */
        public IActionResult IsValidCrsCapacity(int maxStudents, int minStudents)
        {
            if (minStudents < maxStudents)
            {
                return Json(true);
            }
            return Json(false);
        }

        public IActionResult IsValidDates(DateTime eDate, DateTime sDate)
        {
            if(eDate > sDate)
            {
                return Json(true);
            }
            return Json(false);
        }
    }
}

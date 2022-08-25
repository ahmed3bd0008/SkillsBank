using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace WebApp1_SkillsBank.Models
{
    public class Course
    {
        public int Id { get; set; }

        
        [Display(Name = "Course Name")]
        [Required(ErrorMessage = "Course name is required")]
        public string name { get; set; }
        public string Aname { get; set; }

        public string img { get; set; }

        [Display(Name = "Course Promo Link")]
        public string CrsPromoLink { get; set; }
        public DateTime duration { get; set; }

        [Display(Name ="Course Desc")]
        public string description { get; set; }
        public string Adescription { get; set; }
        

        /*unique required*/
        [Required(ErrorMessage = "Course reference is required")]
        [Display(Name = "Course Reference text")]
        public string CrsReferenceText { get; set; }

        [Display(Name = "Course Reference link")]
        public string CrsReferenceLink { get; set; }

        [Display(Name = "Video Transcript")]
        public string VideoTranscript { get; set; }
        
        /* modified */
        [ForeignKey("CrsStatus")]
        [Display(Name = "Course Status")]
        [Required(ErrorMessage = "Course Status is required")]
        public int crsStatusFK { get; set; }
        public CrsStatus CrsStatus { get; set; }

        [Required(ErrorMessage = "StartDate must be declared")]
        [Display(Name = "Course start date")]
        public DateTime startDate { get; set; }

        [Required(ErrorMessage = "EndDate must be declared")]
        [Remote("IsValidDates", "Course", AdditionalFields = "startDate")]
        [Display(Name = "Course end date")]
        public DateTime endDate { get; set; }

        [Display(Name = "Application due date")]
        public DateTime ApplicationDueDate { get; set; }

        [Display(Name = "Course released date")]
        public DateTime CrsReleasedDate { get; set; }

        [Display(Name =  "No. of Sessions")]
        public int Sessions { get; set; }

        [Display(Name = "Effort")]
        public DateTime TotalHours { get; set; }

        [Display(Name = "min. number of students")]
        public int minStudents { get; set; }

        [Display(Name = "max. number of students")]
        [Remote("IsValidCrsCapacity", "Course", AdditionalFields = "minStudents")]
        public int maxStudents { get; set; }

        [Display(Name = "Certificate Available")]
        public bool CertAvailable { get; set; }

        public decimal Price { get; set; }

        [Display(Name = "Course Search Tags")]
        public string SearchTags { get; set; }

        [Display(Name = "Course Discount Percentage")]
        public int DiscountPercent { get; set; }

        [Display(Name = "Course Requirements")]
        public string CrsRequirement { get; set; }

        [Required(ErrorMessage = "Category must be selected")]
        [ForeignKey("category")]
        [Display(Name = "Course Category")]
        public int categoryFK { get; set; }
        public Category category { get; set; } 


        [ForeignKey("crsLevel")]
        [Display(Name = "Course Level")]
        public int crsLevelFK { get; set; }
        public CrsLevel crsLevel { get; set; } 


        [Required(ErrorMessage = "Declare at least one skill")]
        [Display(Name = "Skill to gain")]
        public List<CrsSkills> crsSkills { get; set; }


        [ForeignKey("currency")]
        [Display(Name = "Currency")]
        public int currencyFK { get; set; }
        public Currency currency { get; set; }


        [ForeignKey("crsType")]
        [Display(Name ="Course Type")]
        public int crsTypeFK { get; set; }
        public CrsType crsType { get; set; }


        [ForeignKey("language")]
        [Display(Name = "Language")]
        public int languageFK { get; set; }
        public Language language { get; set; }
    }
}

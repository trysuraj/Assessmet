using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Text.Json;

namespace Assessmet.Models
{
    public class ApplicationForm 
    {
        [Key]
        [JsonProperty(PropertyName = "ApplicationId")]
        public string ApplicationId { get; set; }
        public string ProgramBenefits { get; set; }
        public string ImageUpload { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Nationality { get; set; }
        public string CurrentResidence { get; set; }
        public string IdNumber { get; set; }
        public string ProgramTitle { get; set; }
        public string ProgramSummary { get; set; }
        public string ProgramDescription { get; set; }
        public string ApplicationCriteria { get; set; }
        public string KeySkills { get; set; }
        public DateTime DOB { get; set; }
        public Prog ProgramType { get; set; }
        public DateTime ProgramStart { get; set; }
        public DateTime ApplciationOpen { get; set; }
        public DateTime ApplicationClose { get; set; }
        public int Duration { get; set; }
        public string Location { get; set; }
        public Gender Gender { get; set; }
        public MinQual MinQualification { get; set; }
        public int MaxApplications { get; set; }
        public ICollection<Education>? Educations { get; set; }
        public ICollection<Experience>? Experiences { get; set; }
        public ICollection<IntVid> Questions { get; set; }
        public ICollection<Stages> stages { get; set; }
        public string Resume { get; set; }
        public string AboutSelf { get; set; }
        public string SchoolGrad { get; set; }
        public string Choice { get; set; }
        public string TimesRejected { get; set; } 
    }
    public enum Quest
    {
        Paragraph,
        ShortAnswer,
        Yes_No,
        MultipleChoice,
        Date,
        Number,
        FileUpload,
        VideoQuestion
    }
    public enum Gender
    {
        Male,
        Female
    }
}

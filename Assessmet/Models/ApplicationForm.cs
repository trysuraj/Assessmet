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
        public string ImageUpload { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Nationality { get; set; }
        public string CurrentResidence { get; set; }
        public string IdNumber { get; set; }
        public DateTime DOB { get; set; }

        public Gender Gender { get; set; }
        public ICollection<Education>? Educations { get; set; }
        public ICollection<Experience>? Experiences { get; set; }
        public ICollection<IntVid> Questions { get; set; }
       
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

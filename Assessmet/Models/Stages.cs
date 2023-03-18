using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessmet.Models
{
    public class Stages
    {
        
            [Key]
            public string StageId { get; set; }
            public string StageName { get; set; }
            public string Shortlistings { get; set; }
            public string Placement { get; set; }
            public ICollection<IntVid>? InterviewQuestion { get; set; }
    }

    public class IntVid
    {
            [Key]
            public string InterviewId { get; set; }
            [DataType(DataType.Text)]
            public string VideoInterviewQuest { get; set; }
            [DataType(DataType.Text)]
            public string AdditionalInformation { get; }
            public Time VidDuration { get; set; }
            public String VidDeadline { get; set; }
    }
        public enum Time
        {
            Sec,
            Min
        }
    
}

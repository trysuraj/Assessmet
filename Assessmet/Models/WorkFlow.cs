using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessmet.Models
{
    public class WorkFlow
    {
        public IntVidQuest VidInterviewQuest { get; set; }
        public string StageName { get; set; } 
        public string StageType { get; set; }
        public IntVid InterviewVideo { get; set; }

    }
  public class  IntVidQuest
    {
        public string About { get; set; }
        public string WhyApply { get; set; }    
    }
}

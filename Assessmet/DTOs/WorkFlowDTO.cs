using Assessmet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessmet.DTOs
{
    public class WorkFlowDTO
    {
        public IntVidQuest VidInterviewQuest { get; set; }
        public string StageName { get; set; }
        public string StageType { get; set; }
        public IntVid InterviewVideo { get; set; }
    }
}

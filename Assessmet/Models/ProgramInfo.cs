using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessmet.Models
{
    public class ProgramInfo
    {
        public Prog ProgramType { get; set; }
        public DateTime ProgramStart { get; set; }
        public DateTime ProgramOpen { get; set; }
        public DateTime ProgramClose { get; set; }
        public int Duration { get; set; }
        public string Location { get; set; }
        public MinQual MinQualification { get; set; }
        public string MaxApplicationNumber { get; set; }
    }
    public enum Prog
    {
        Internshipt,
        Job,
        Training,
        Masterclass,
        Webinar,
        Course,
        LiveSeminar,
        Volunteering,
        other
    }

    public enum MinQual
    {
        HighSchool,
        College,
        Graduate,
        University,
        Masters,
        Ph_D,
        Any
    }
}

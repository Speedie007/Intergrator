using System;
using System.Collections.Generic;

namespace DAtabasetables
{
    public partial class CurriculumViteaWorkExperiences
    {
        public CurriculumViteaWorkExperiences()
        {
          
        }

        public int CurriculumViteaWorkExperienceId { get; set; }
        public int CurriculumViteaId { get; set; }
        public int IntegratorUserIndustryCategoryJobId { get; set; }
        public int CompanyId { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime DateEnded { get; set; }
        public string Achievments { get; set; }

        
    }
}
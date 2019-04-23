using System;
using System.Collections.Generic;

namespace DAtabasetables
{
    public partial class CoreKbskills
    {
        public int CoreKbskillId { get; set; }
        public int CoreSkillCategoryId { get; set; }
        public string CoreSkill { get; set; }

        public virtual CoreSkillCategories CoreSkillCategory { get; set; }
    }
}
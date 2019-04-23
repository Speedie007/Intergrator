using System;
using System.Collections.Generic;

namespace DAtabasetables
{
    public partial class CoreSkillCategories
    {
        public CoreSkillCategories()
        {
            CoreKbskills = new HashSet<CoreKbskills>();
        }

        public int CoreSkillCategoryId { get; set; }
        public int CoreKbskillTypeId { get; set; }
        public string CoreSkillCategory { get; set; }

        public virtual CoreKbskillTypes CoreKbskillType { get; set; }
        public virtual ICollection<CoreKbskills> CoreKbskills { get; set; }
    }
}
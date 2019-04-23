using System;
using System.Collections.Generic;

namespace DAtabasetables
{
    public partial class CoreKbskillTypes
    {
        public CoreKbskillTypes()
        {
            CoreSkillCategories = new HashSet<CoreSkillCategories>();
        }

        public int CoreKbskillTypeId { get; set; }
        public string CoreKbskillType { get; set; }

        public virtual ICollection<CoreSkillCategories> CoreSkillCategories { get; set; }
    }
}
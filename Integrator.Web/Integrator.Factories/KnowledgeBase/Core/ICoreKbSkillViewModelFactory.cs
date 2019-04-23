using Integrator.Models.ViewModels.KnowledgeBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Factories.KnowledgeBase.Core
{
    public partial interface ICoreKbSkillViewModelFactory
    {
        EditCoreKbSkillViewModel PrepareCoreKbSkillViewModel();

        EditCoreKbIndustryViewModel PrepareCoreKbIndusrtyViewModel();
    }
}

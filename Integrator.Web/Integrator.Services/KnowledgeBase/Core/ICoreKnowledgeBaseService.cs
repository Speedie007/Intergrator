using Integrator.Models.Domain.KnowledgeBase.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Services.KnowledgeBase.Core
{
    public partial interface ICoreKnowledgeBaseService
    {


        #region Select Section 

        CoreKbIndustry GetIndustry(int ID);
        List<CoreKbIndustry> ListIndustries();

        CoreKbIndustryCategory GetIndustryCategory(int ID);
        List<CoreKbIndustry> ListIndustriesByCategory(int CategoryID);
        List<CoreKbIndustryCategory> ListIndustryCategories();

        CoreKbJob GetJob(int ID);
        List<CoreKbJob> ListJobs();

        CoreKbIndustryJob GetIndustryJob(int ID);
        List<CoreKbIndustryJob> ListIndustryJobs();

        CoreKbJobSkill GetJobSkill(int ID);
        List<CoreKbJobSkill> ListJobSkills(int JobID);
        List<CoreKbJobSkill> ListSkillJobs(int SkillID);

        CoreKbSkill GetSkill(int SkillID);
        List<CoreKbSkill> ListSkills();
        List<CoreKbSkill> ListSkillsByCategory(int CategoryID);
        List<CoreKbSkill> ListHardSkills();
        List<CoreKbSkill> ListSoftSkills();

        CoreSkillCategory GetSkillCategory(int ID);
        List<CoreSkillCategory> ListSkillCategories();
        List<CoreSkillCategory> ListSkillCategoriesBySkillType(int SkillTypeID);

        CoreKbSkillType GetSkillType(int ID);
        List<CoreKbSkillType> ListSkillTypes();
        #endregion

        #region Delete Section

        Boolean DeleteIndustry(CoreKbIndustry Entity);
        Boolean DeleteIndustries(List<CoreKbIndustryCategory> EntityList);

        Boolean DeleteCategory(CoreKbIndustryCategory Entity);
        Boolean DeleteCategories(List<CoreKbIndustryCategory> EntityList);

        Boolean DeleteJob(CoreKbJob Entity);
        Boolean DeleteJobs(List<CoreKbJob> Entity);

        Boolean DeleteIndustryJob(CoreKbJob Entity);
        Boolean DeleteIndustryJobs(List<CoreKbJob> Entity);

        Boolean DeleteJobSkill(CoreKbJobSkill Entity);
        Boolean DeleteJobSkills(List<CoreKbJobSkill> Entity);

        Boolean DeleteSkill(CoreKbSkill Entity);
        Boolean DeleteSkills(List<CoreKbSkill> Entity);

        Boolean DeleteSkillCategory(CoreSkillCategory Entity);
        Boolean DeleteSkillsCategory(List<CoreSkillCategory> Entity);

        Boolean DeleteSkillType(CoreKbSkillType Entity);
        Boolean DeleteSkillTypes(List<CoreKbSkillType> Entity);

        #endregion


        #region Insert Section

        void AddIndustry(CoreKbIndustry Entity);
        void AddIndustries(List<CoreKbIndustryCategory> EntityList);

        void AddIndusrtyCategory(CoreKbIndustryCategory Entity);
        void AddCategories(List<CoreKbIndustryCategory> EntityList);

        void AddJob(CoreKbJob Entity);
        void AddJobs(List<CoreKbJob> Entity);

        void AddIndustryJob(CoreKbJob Entity);
        void AddIndustryJobs(List<CoreKbJob> Entity);

        void AddJobSkill(CoreKbJobSkill Entity);
        void AddJobSkills(List<CoreKbJobSkill> Entity);

        void AddSkill(CoreKbSkill Entity);
        void AddSkills(List<CoreKbSkill> Entity);

        void AddSkillCategory(CoreSkillCategory Entity);
        void AddSkillCategories(List<CoreSkillCategory> Entity);

        void AddSkillType(CoreKbSkillType Entity);
        void AddSkillTypes(List<CoreKbSkillType> Entity);

        #endregion
    }
}

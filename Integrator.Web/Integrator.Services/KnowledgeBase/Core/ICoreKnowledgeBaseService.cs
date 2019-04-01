using Integrator.Models.Domain.KnowledgeBase.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Services.KnowledgeBase.Core
{
    public partial interface ICoreKnowledgeBaseService
    {

        #region Delete Section

        Boolean DeleteIndustry(CoreKBIndustryType Industry);
        Boolean DeleteIndustries(List<CoreKBIndustryType> Industrires);

        Boolean DeleteCategory(CoreKBIndustryCategory Category);
        Boolean DeleteCategories(List<CoreKBIndustryCategory> Categoies);

        Boolean DeleteJob(CoreKBIndustryCategoryJob Job);
        Boolean DeleteJobs(List<CoreKBIndustryCategoryJob> Job);

        Boolean DeleteSkillSet(CoreKBIndustryCategoryJobSkillSet SkillSet);
        Boolean DeleteSkillSets(List<CoreKBIndustryCategoryJobSkillSet> SkillSets);

        #endregion

        #region Insert Section 

        /// <summary>
        /// Links single industry to the user 
        /// </summary>
        /// <param name="Industry">Is an CoreKBIndustryType Entity</param>
        /// <returns>True if succssefull else returns false</returns>
        Boolean InsertIndustry(CoreKBIndustryType Industry);

        /// <summary>
        /// Links multiple industries to the user
        /// </summary>
        /// <param name="Industry">Is a list of CoreKBIndustryType Entity</param>
        /// <returns>True if succssefull else returns false</returns>
        Boolean InsertIndustries(List<CoreKBIndustryType> Industries);

        /// <summary>
        /// Links single Category to the user assocciated with a specific Industry
        /// </summary>
        /// <param name="Category">Is an CoreKBIndustryType Entity</param>
        /// <returns>True if succssefull else returns false</returns>
        Boolean InsertCategory(CoreKBIndustryCategory Category);

        /// <summary>
        /// Links multiple Categories to the user with its assocciated Industry
        /// </summary>
        /// <param name="Category">Is a list of CoreKBIndustryCategory Entity</param>
        /// <returns>True if succssefull else returns false</returns>
        Boolean InsertCategories(List<CoreKBIndustryCategory> Categories);


        /// <summary>
        /// Links single CategoryJob to the user assocciated with a specific Category
        /// </summary>
        /// <param name="Job">Is an CoreKBIndustryType Entity</param>
        /// <returns>True if succssefull else returns false</returns>
        Boolean InsertJob(CoreKBIndustryCategoryJob Job);

        /// <summary>
        /// Links multiple CategoryJobs to the user with its assocciated Category
        /// </summary>
        /// <param name="Job"></param>
        /// <returns>True if succssefull else returns false</returns>
        Boolean InsertJobs(List<CoreKBIndustryCategoryJob> Jobs);


        /// <summary>
        /// Links single JobSkillSet to the user assocciated with a specific CategoryJob
        /// </summary>
        /// <param name="SkillSet"></param>
        /// <returns>True if succssefull else returns false</returns>
        Boolean InsertSkillSet(CoreKBIndustryCategoryJobSkillSet SkillSet);


        /// <summary>
        ///  Links multiple JobSkillSets to the user with its assocciated CategoryJob
        /// </summary>
        /// <param name="SkillSet"></param>
        /// <returns>True if succssefull else returns false</returns>
        Boolean InsertSkillSets(List<CoreKBIndustryCategoryJobSkillSet> SkillSets);
        #endregion

        #region Select Section
        /// <summary>
        /// Get All Associated Industries for the the User
        /// </summary>
        /// <param name="UserID">UserID</param>
        /// <returns>List of all industies the user is associated with</returns>
        List<CoreKBIndustryType> ListAllIndustries();

        /// <summary>
        /// Returns Single Industry by CoreKBIndustryTypeID
        /// </summary>
        /// <param name="CoreKBIndustryTypeID"></param>
        /// <returns></returns>
        CoreKBIndustryType GetIndustry(int IndustryID);


        /// <summary>
        /// List All associated Categories for a selected industry that user is associated with.
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="CoreKBIndustryTypeID"></param>
        /// <returns></returns>
        List<CoreKBIndustryCategory> ListCategoriesPerIndustry(int IndustryID);

        /// <summary>
        /// Return Single Category by CoreKBIndustryCategoryID
        /// </summary>
        /// <param name="CoreKBIndustryCategoryID"></param>
        /// <returns></returns>
        CoreKBIndustryCategory GetCategory(int IndustryCategoryID);

        /// <summary>
        /// List All associated Jobs for a selected category that user is associated with.
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="CoreKBIndustryCategoryID"></param>
        /// <returns></returns>
        List<CoreKBIndustryCategoryJob> ListJobsPerCategory(int IndustryCategoryID);

        /// <summary>
        /// Retrun single Job By CoreKBIndustryCategoryJobID
        /// </summary>
        /// <param name="CoreKBIndustryCategoryJobID"></param>
        /// <returns></returns>
        CoreKBIndustryCategoryJob GetJob(int CoreKBIndustryCategoryJobID);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="CoreKBIndustryCategoryJobID"></param>
        /// <returns>List of CoreKBIndustryCategoryJobSkillSet</returns>
        List<CoreKBIndustryCategoryJobSkillSet> ListSkillSetsPreJob(int IndustryCategoryJobID);

        /// <summary>
        /// Retrun single SkillSet By CoreKBIndustryCategoryJobSkillSetID
        /// </summary>
        /// <param name="CoreKBIndustryCategoryJobSkillSetID"></param>
        /// <returns>Single selected skillset [CoreKBIndustryCategoryJobSkillSet]</returns>
        CoreKBIndustryCategoryJobSkillSet GetSkillSet(int IndustryCategorySkillSetID);

        #endregion
    }
}

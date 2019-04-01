using Integrator.Models.Domain.KnowledgeBase.Core;
using Integrator.Models.Domain.KnowledgeBase.IndividualUsers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Services.KnowledgeBase.Users
{
    public partial interface IUserKnowledgeBaseService
    {

        #region Delete Section

        Boolean DeleteIndustry(IntegratorUserIndustry Item);
        Boolean DeleteIndustries(List<IntegratorUserIndustry> Item);

        Boolean DeleteCategory(IntegratorUserIndustryCategory Item);
        Boolean DeleteCategories(List<IntegratorUserIndustryCategory> Item);

        Boolean DeleteJob(IntegratorUserIndustryCategoryJob Item);
        Boolean DeleteJobs(List<IntegratorUserIndustryCategoryJob> Item);

        Boolean DeleteSkillSet(IntegratorUserIndustryCategoryJobSkillSet Item);
        Boolean DeleteSkillSets(List<IntegratorUserIndustryCategoryJobSkillSet> Item);

        #endregion

        #region Insert Section 

        /// <summary>
        /// Links single industry to the user 
        /// </summary>
        /// <param name="Item">Is an IntegratorUserIndustry Entity</param>
        /// <returns>True if succssefull else returns false</returns>
        Boolean InsertIndustry(IntegratorUserIndustry Item);

        /// <summary>
        /// Links multiple industries to the user
        /// </summary>
        /// <param name="Item">Is a list of IntegratorUserIndustry Entity</param>
        /// <returns>True if succssefull else returns false</returns>
        Boolean InsertIndustries(List<IntegratorUserIndustry> Item);

        /// <summary>
        /// Links single Category to the user assocciated with a specific Industry
        /// </summary>
        /// <param name="Item">Is an IntegratorUserIndustry Entity</param>
        /// <returns>True if succssefull else returns false</returns>
        Boolean InsertCategory(IntegratorUserIndustryCategory Item);

        /// <summary>
        /// Links multiple Categories to the user with its assocciated Industry
        /// </summary>
        /// <param name="Item">Is a list of IntegratorUserIndustryCategory Entity</param>
        /// <returns>True if succssefull else returns false</returns>
        Boolean InsertCategories(List<IntegratorUserIndustryCategory> Item);


        /// <summary>
        /// Links single CategoryJob to the user assocciated with a specific Category
        /// </summary>
        /// <param name="Item">Is an IntegratorUserIndustry Entity</param>
        /// <returns>True if succssefull else returns false</returns>
        Boolean InsertJob(IntegratorUserIndustryCategoryJob Item);

        /// <summary>
        /// Links multiple CategoryJobs to the user with its assocciated Category
        /// </summary>
        /// <param name="Item"></param>
        /// <returns>True if succssefull else returns false</returns>
        Boolean InsertJobs(List<IntegratorUserIndustryCategoryJob> Item);


        /// <summary>
        /// Links single JobSkillSet to the user assocciated with a specific CategoryJob
        /// </summary>
        /// <param name="Item"></param>
        /// <returns>True if succssefull else returns false</returns>
        Boolean InsertSkillSet(IntegratorUserIndustryCategoryJobSkillSet Item);


        /// <summary>
        ///  Links multiple JobSkillSets to the user with its assocciated CategoryJob
        /// </summary>
        /// <param name="Item"></param>
        /// <returns>True if succssefull else returns false</returns>
        Boolean InsertSkillSets(List<IntegratorUserIndustryCategoryJobSkillSet> Item);
        #endregion

        #region Select Section
        /// <summary>
        /// Get All Associated Industries for the the User
        /// </summary>
        /// <param name="UserID">UserID</param>
        /// <returns>List of all industies the user is associated with</returns>
        List<CoreKBIndustryType> ListAllIndustries(int UserID);

        /// <summary>
        /// Returns Single Industry by IntegratorUserIndustryID
        /// </summary>
        /// <param name="IntegratorUserIndustryID"></param>
        /// <returns></returns>
        CoreKBIndustryType GetIndustry(int IntegratorUserIndustryID);


        /// <summary>
        /// List All associated Categories for a selected industry that user is associated with.
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="IntegratorUserIndustryID"></param>
        /// <returns></returns>
        List<CoreKBIndustryCategory> ListAllCategoriesPreIndustry(int UserID, int IntegratorUserIndustryID);

        /// <summary>
        /// Return Single Category by IntegratorUserIndustryCategoryID
        /// </summary>
        /// <param name="IntegratorUserIndustryCategoryID"></param>
        /// <returns></returns>
        CoreKBIndustryCategory GetCategory(int IntegratorUserIndustryCategoryID);

        /// <summary>
        /// List All associated Jobs for a selected category that user is associated with.
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="IntegratorUserIndustryCategoryID"></param>
        /// <returns></returns>
        List<CoreKBIndustryCategoryJob> ListAllJobsPreCategory(int UserID, int IntegratorUserIndustryCategoryID);

        /// <summary>
        /// Retrun single Job By IntegratorUserIndustryCategoryJobID
        /// </summary>
        /// <param name="IntegratorUserIndustryCategoryJobID"></param>
        /// <returns></returns>
        CoreKBIndustryCategoryJob GetJob(int IntegratorUserIndustryCategoryJobID);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="IntegratorUserIndustryCategoryJobID"></param>
        /// <returns>List of CoreKBIndustryCategoryJobSkillSet</returns>
        List<CoreKBIndustryCategoryJobSkillSet> ListAllSkillSetsPreJob(int UserID, int IntegratorUserIndustryCategoryJobID);

        /// <summary>
        /// Retrun single SkillSet By IntegratorUserIndustryCategoryJobSkillSetID
        /// </summary>
        /// <param name="IntegratorUserIndustryCategoryJobSkillSetID"></param>
        /// <returns>Single selected skillset [CoreKBIndustryCategoryJobSkillSet]</returns>
        CoreKBIndustryCategoryJobSkillSet GetSkillSet(int IntegratorUserIndustryCategoryJobSkillSetID);

        #endregion
    }
}

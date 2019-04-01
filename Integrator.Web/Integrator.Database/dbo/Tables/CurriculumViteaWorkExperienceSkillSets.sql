CREATE TABLE [dbo].[CurriculumViteaWorkExperienceSkillSets] (
    [CurriculumViteaWorkExperienceSkillSetID]     INT IDENTITY (1, 1) NOT NULL,
    [CurriculumViteaWorkExperienceID]             INT NOT NULL,
    [IntegratorUserIndustryCategoryJobSkillSetID] INT NOT NULL,
    CONSTRAINT [PK_CurriculumViteaWorkExperienceSkillSets] PRIMARY KEY CLUSTERED ([CurriculumViteaWorkExperienceSkillSetID] ASC),
    CONSTRAINT [FK_CurriculumViteaWorkExperienceSkillSets_CurriculumViteaWorkExperiences] FOREIGN KEY ([CurriculumViteaWorkExperienceID]) REFERENCES [dbo].[CurriculumViteaWorkExperiences] ([CurriculumViteaWorkExperienceID]),
    CONSTRAINT [FK_CurriculumViteaWorkExperienceSkillSets_IntegratorUserIndustryCategoryJobSkillSets] FOREIGN KEY ([IntegratorUserIndustryCategoryJobSkillSetID]) REFERENCES [dbo].[IntegratorUserIndustryCategoryJobSkillSets] ([IntegratorUserIndustryCategoryJobSkillSetID])
);


GO
CREATE NONCLUSTERED INDEX [IX_CurriculumViteaWorkExperienceSkillSets_IntegratorUserIndustryCategoryJobSkillSetID]
    ON [dbo].[CurriculumViteaWorkExperienceSkillSets]([IntegratorUserIndustryCategoryJobSkillSetID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CurriculumViteaWorkExperienceSkillSets_CurriculumViteaWorkExperienceID]
    ON [dbo].[CurriculumViteaWorkExperienceSkillSets]([CurriculumViteaWorkExperienceID] ASC);


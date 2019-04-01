CREATE TABLE [dbo].[CompanyIndustryCategoryJobSkillSets] (
    [CompanyIndustryCategoryJobSkillSetID] INT           IDENTITY (1, 1) NOT NULL,
    [CompanyID]                            INT           NOT NULL,
    [CompanyIndustryCategoryJobID]         INT           NOT NULL,
    [CoreKBIndustryCategorySkillSetID]     INT           NOT NULL,
    [Description]                          VARCHAR (150) NULL,
    [DateLastUpdated]                      DATETIME      NULL,
    CONSTRAINT [PK_CompanyIndustryCategoryJobSkillSets] PRIMARY KEY CLUSTERED ([CompanyIndustryCategoryJobSkillSetID] ASC),
    CONSTRAINT [FK_CompanyIndustryCategoryJobSkillSets_Companies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[Company] ([CompanyID]),
    CONSTRAINT [FK_CompanyIndustryCategoryJobSkillSets_CompanyIndustryCategoryJobs] FOREIGN KEY ([CompanyIndustryCategoryJobID]) REFERENCES [dbo].[CompanyIndustryCategoryJobs] ([CompanyIndustryCategoryJobID]),
    CONSTRAINT [FK_CompanyIndustryCategoryJobSkillSets_IndustryCategorySkillSets] FOREIGN KEY ([CoreKBIndustryCategorySkillSetID]) REFERENCES [dbo].[CoreKBIndustryCategoryJobSkillSets] ([IndustryCategorySkillSetID])
);


GO
CREATE NONCLUSTERED INDEX [IX_CompanyIndustryCategoryJobSkillSets_CoreKBIndustryCategorySkillSetID]
    ON [dbo].[CompanyIndustryCategoryJobSkillSets]([CoreKBIndustryCategorySkillSetID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CompanyIndustryCategoryJobSkillSets_CompanyIndustryCategoryJobID]
    ON [dbo].[CompanyIndustryCategoryJobSkillSets]([CompanyIndustryCategoryJobID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CompanyIndustryCategoryJobSkillSets_CompanyID]
    ON [dbo].[CompanyIndustryCategoryJobSkillSets]([CompanyID] ASC);


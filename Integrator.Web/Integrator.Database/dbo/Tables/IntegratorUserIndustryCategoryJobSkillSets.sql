CREATE TABLE [dbo].[IntegratorUserIndustryCategoryJobSkillSets] (
    [IntegratorUserIndustryCategoryJobSkillSetID] INT             IDENTITY (1, 1) NOT NULL,
    [IntegratorUserID]                            INT             NOT NULL,
    [IntegratorUserIndustryCategoryJobID]         INT             NOT NULL,
    [CoreKBIndustryCategorySkillSetID]            INT             NOT NULL,
    [Description]                                 VARCHAR (1000)  NULL,
    [DateLastUpdated]                             DATETIME        NULL,
    [SkillLevel]                                  NUMERIC (18, 2) NOT NULL,
    CONSTRAINT [PK_IntegratorUserIndustryCategoryJobSkillSets] PRIMARY KEY CLUSTERED ([IntegratorUserIndustryCategoryJobSkillSetID] ASC),
    CONSTRAINT [FK_IntegratorUserIndustryCategoryJobSkillSets_IndustryCategorySkillSets] FOREIGN KEY ([CoreKBIndustryCategorySkillSetID]) REFERENCES [dbo].[CoreKBIndustryCategoryJobSkillSets] ([IndustryCategorySkillSetID]),
    CONSTRAINT [FK_IntegratorUserIndustryCategoryJobSkillSets_IntegratorUserIndustryCategoryJobs] FOREIGN KEY ([IntegratorUserIndustryCategoryJobID]) REFERENCES [dbo].[IntegratorUserIndustryCategoryJobs] ([IntegratorUserIndustryCategoryJobID]),
    CONSTRAINT [FK_IntegratorUserIndustryCategoryJobSkillSets_Users] FOREIGN KEY ([IntegratorUserID]) REFERENCES [dbo].[IntegratorUsers] ([IntegratorUserID])
);






GO
CREATE NONCLUSTERED INDEX [IX_IntegratorUserIndustryCategoryJobSkillSets_IntegratorUserIndustryCategoryJobID]
    ON [dbo].[IntegratorUserIndustryCategoryJobSkillSets]([IntegratorUserIndustryCategoryJobID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_IntegratorUserIndustryCategoryJobSkillSets_IntegratorUserID]
    ON [dbo].[IntegratorUserIndustryCategoryJobSkillSets]([IntegratorUserID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_IntegratorUserIndustryCategoryJobSkillSets_CoreKBIndustryCategorySkillSetID]
    ON [dbo].[IntegratorUserIndustryCategoryJobSkillSets]([CoreKBIndustryCategorySkillSetID] ASC);


CREATE TABLE [dbo].[CompanyJobSkills] (
    [CompanyJobSkillID]  INT IDENTITY (1, 1) NOT NULL,
    [CompanyJobID]       INT NOT NULL,
    [CoreKbSkillID]      INT NOT NULL,
    [LevelOfImportantce] INT NOT NULL,
    CONSTRAINT [PK_CompanyJobSkills] PRIMARY KEY CLUSTERED ([CompanyJobSkillID] ASC),
    CONSTRAINT [FK_CompanyJobSkills_CompanyJobs] FOREIGN KEY ([CompanyJobID]) REFERENCES [dbo].[CompanyJobs] ([CompanyJobID]),
    CONSTRAINT [FK_CompanyJobSkills_CoreKBSkills] FOREIGN KEY ([CoreKbSkillID]) REFERENCES [dbo].[CoreKbSkills] ([CoreKbSkillID])
);


GO
CREATE NONCLUSTERED INDEX [IX_CompanyJobSkills_CoreKbSkillID]
    ON [dbo].[CompanyJobSkills]([CoreKbSkillID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CompanyJobSkills_CompanyJobID]
    ON [dbo].[CompanyJobSkills]([CompanyJobID] ASC);


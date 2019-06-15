CREATE TABLE [dbo].[CoreKbJobSkills] (
    [CoreKbJobSkillID] INT IDENTITY (1, 1) NOT NULL,
    [CoreKbJobID]      INT NOT NULL,
    [CoreKbSkillID]    INT NOT NULL,
    CONSTRAINT [PK_CoreKbJobSkills] PRIMARY KEY CLUSTERED ([CoreKbJobSkillID] ASC),
    CONSTRAINT [FK_CoreKBJobSkills_CoreKBJobs] FOREIGN KEY ([CoreKbJobID]) REFERENCES [dbo].[CoreKbJobs] ([CoreKbJobID]),
    CONSTRAINT [FK_CoreKBJobSoftSkills_CoreSoftSkills] FOREIGN KEY ([CoreKbSkillID]) REFERENCES [dbo].[CoreKbSkills] ([CoreKbSkillID])
);


GO
CREATE NONCLUSTERED INDEX [IX_CoreKbJobSkills_CoreKbSkillID]
    ON [dbo].[CoreKbJobSkills]([CoreKbSkillID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CoreKbJobSkills_CoreKbJobID]
    ON [dbo].[CoreKbJobSkills]([CoreKbJobID] ASC);


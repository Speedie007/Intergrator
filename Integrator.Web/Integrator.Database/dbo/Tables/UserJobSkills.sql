CREATE TABLE [dbo].[UserJobSkills] (
    [UserJobSkillID]    INT IDENTITY (1, 1) NOT NULL,
    [UserJobID]         INT NOT NULL,
    [CoreKbSkillID]     INT NOT NULL,
    [UserJobSkillLevel] INT NOT NULL,
    CONSTRAINT [PK_UserJobSkills] PRIMARY KEY CLUSTERED ([UserJobSkillID] ASC),
    CONSTRAINT [FK_UserJobSkills_CoreKBSkills] FOREIGN KEY ([CoreKbSkillID]) REFERENCES [dbo].[CoreKbSkills] ([CoreKbSkillID]) ON DELETE CASCADE,
    CONSTRAINT [FK_UserJobSkills_UserJobs1] FOREIGN KEY ([UserJobID]) REFERENCES [dbo].[UserJobs] ([UserJobID]) ON DELETE CASCADE ON UPDATE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_UserJobSkills_UserJobID]
    ON [dbo].[UserJobSkills]([UserJobID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_UserJobSkills_CoreKbSkillID]
    ON [dbo].[UserJobSkills]([CoreKbSkillID] ASC);


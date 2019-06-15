CREATE TABLE [dbo].[UserJobRelatedIndustries] (
    [UserJobRelatedIndustryID]   INT IDENTITY (1, 1) NOT NULL,
    [UserJobID]                  INT NOT NULL,
    [CoreKbIndustryID]           INT NOT NULL,
    [LevelOfIndustryInvolvement] INT NOT NULL,
    CONSTRAINT [PK_UserJobRelatedIndustries] PRIMARY KEY CLUSTERED ([UserJobRelatedIndustryID] ASC),
    CONSTRAINT [FK_UserJobRelatedIndustries_CoreKbIndustries] FOREIGN KEY ([CoreKbIndustryID]) REFERENCES [dbo].[CoreKbIndustries] ([CoreKbIndustryID]),
    CONSTRAINT [FK_UserJobRelatedIndustries_UserJobs1] FOREIGN KEY ([UserJobID]) REFERENCES [dbo].[UserJobs] ([UserJobID]) ON DELETE CASCADE ON UPDATE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_UserJobRelatedIndustries_UserJobID]
    ON [dbo].[UserJobRelatedIndustries]([UserJobID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_UserJobRelatedIndustries_CoreKbIndustryID]
    ON [dbo].[UserJobRelatedIndustries]([CoreKbIndustryID] ASC);


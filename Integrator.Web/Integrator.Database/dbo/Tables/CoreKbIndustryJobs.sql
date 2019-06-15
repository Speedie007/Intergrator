CREATE TABLE [dbo].[CoreKbIndustryJobs] (
    [CoreKbIndustryJobID] INT IDENTITY (1, 1) NOT NULL,
    [CoreKbIndustryID]    INT NOT NULL,
    [CoreKbJobID]         INT NOT NULL,
    CONSTRAINT [PK_CoreKbIndustryJobs] PRIMARY KEY CLUSTERED ([CoreKbIndustryJobID] ASC),
    CONSTRAINT [FK_CoreKBIndustrySectorJobs_CoreKbIndustrySectors] FOREIGN KEY ([CoreKbIndustryID]) REFERENCES [dbo].[CoreKbIndustries] ([CoreKbIndustryID]),
    CONSTRAINT [FK_CoreKBIndustrySectorJobs_CoreKBJobs] FOREIGN KEY ([CoreKbJobID]) REFERENCES [dbo].[CoreKbJobs] ([CoreKbJobID])
);


GO
CREATE NONCLUSTERED INDEX [IX_CoreKbIndustryJobs_CoreKbJobID]
    ON [dbo].[CoreKbIndustryJobs]([CoreKbJobID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CoreKbIndustryJobs_CoreKbIndustryID]
    ON [dbo].[CoreKbIndustryJobs]([CoreKbIndustryID] ASC);


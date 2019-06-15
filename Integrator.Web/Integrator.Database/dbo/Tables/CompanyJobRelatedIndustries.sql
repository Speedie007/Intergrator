CREATE TABLE [dbo].[CompanyJobRelatedIndustries] (
    [CompanyJobRelatedIndustryID] INT IDENTITY (1, 1) NOT NULL,
    [CoreKbIndustryID]            INT NOT NULL,
    [CompanyJobID]                INT NOT NULL,
    [LevelOfCompanyInvolvement]   BIT NOT NULL,
    CONSTRAINT [PK_CompanyJobRelatedIndustries] PRIMARY KEY CLUSTERED ([CompanyJobRelatedIndustryID] ASC),
    CONSTRAINT [FK_ComanyJobRelatedIndustries_CompanyJobs] FOREIGN KEY ([CompanyJobID]) REFERENCES [dbo].[CompanyJobs] ([CompanyJobID]),
    CONSTRAINT [FK_ComanyJobRelatedIndustries_CoreKbIndustries] FOREIGN KEY ([CoreKbIndustryID]) REFERENCES [dbo].[CoreKbIndustries] ([CoreKbIndustryID])
);


GO
CREATE NONCLUSTERED INDEX [IX_CompanyJobRelatedIndustries_CoreKbIndustryID]
    ON [dbo].[CompanyJobRelatedIndustries]([CoreKbIndustryID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CompanyJobRelatedIndustries_CompanyJobID]
    ON [dbo].[CompanyJobRelatedIndustries]([CompanyJobID] ASC);


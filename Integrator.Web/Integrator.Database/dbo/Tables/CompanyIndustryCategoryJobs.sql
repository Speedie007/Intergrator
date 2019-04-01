CREATE TABLE [dbo].[CompanyIndustryCategoryJobs] (
    [CompanyIndustryCategoryJobID] INT           IDENTITY (1, 1) NOT NULL,
    [CompanyID]                    INT           NOT NULL,
    [CompanyIndustryCategoryID]    INT           NOT NULL,
    [CoreKBIndustryCategoryJobID]  INT           NOT NULL,
    [Description]                  VARCHAR (100) NULL,
    [DateLastUpdated]              DATETIME      NULL,
    CONSTRAINT [PK_CompanyIndustryCategoryJobs] PRIMARY KEY CLUSTERED ([CompanyIndustryCategoryJobID] ASC),
    CONSTRAINT [FK_CompanyIndustryCategoryJobs_Companies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[Company] ([CompanyID]),
    CONSTRAINT [FK_CompanyIndustryCategoryJobs_CompanyIndustryCategories] FOREIGN KEY ([CompanyIndustryCategoryID]) REFERENCES [dbo].[CompanyIndustryCategories] ([CompanyIndustryCategoryID]),
    CONSTRAINT [FK_CompanyIndustryCategoryJobs_IndustryCategoryJobs] FOREIGN KEY ([CoreKBIndustryCategoryJobID]) REFERENCES [dbo].[CoreKBIndustryCategoryJobs] ([IndustryCategoryJobID])
);


GO
CREATE NONCLUSTERED INDEX [IX_CompanyIndustryCategoryJobs_CoreKBIndustryCategoryJobID]
    ON [dbo].[CompanyIndustryCategoryJobs]([CoreKBIndustryCategoryJobID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CompanyIndustryCategoryJobs_CompanyIndustryCategoryID]
    ON [dbo].[CompanyIndustryCategoryJobs]([CompanyIndustryCategoryID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CompanyIndustryCategoryJobs_CompanyID]
    ON [dbo].[CompanyIndustryCategoryJobs]([CompanyID] ASC);


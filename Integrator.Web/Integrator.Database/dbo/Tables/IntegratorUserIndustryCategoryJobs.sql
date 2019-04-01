CREATE TABLE [dbo].[IntegratorUserIndustryCategoryJobs] (
    [IntegratorUserIndustryCategoryJobID] INT           IDENTITY (1, 1) NOT NULL,
    [IntegratorUserID]                    INT           NOT NULL,
    [IntegratorUserIndustryCategoryID]    INT           NOT NULL,
    [CoreKBIndustryCategoryJobID]         INT           NOT NULL,
    [Description]                         VARCHAR (150) NULL,
    [DateLastUpdated]                     DATETIME      NULL,
    [IsPrimaryJobFunction]                BIT           NOT NULL,
    CONSTRAINT [PK_IntegratorUserIndustryCategoryJobs] PRIMARY KEY CLUSTERED ([IntegratorUserIndustryCategoryJobID] ASC),
    CONSTRAINT [FK_IntegratorUserIndustryCategoryJobs_IndustryCategoryJobs] FOREIGN KEY ([CoreKBIndustryCategoryJobID]) REFERENCES [dbo].[CoreKBIndustryCategoryJobs] ([IndustryCategoryJobID]),
    CONSTRAINT [FK_IntegratorUserIndustryCategoryJobs_IntegratorUserIndustryCategories] FOREIGN KEY ([IntegratorUserIndustryCategoryID]) REFERENCES [dbo].[IntegratorUserIndustryCategories] ([IntegratorUserIndustryCategoryID]),
    CONSTRAINT [FK_IntegratorUserIndustryCategoryJobs_Users] FOREIGN KEY ([IntegratorUserID]) REFERENCES [dbo].[IntegratorUsers] ([IntegratorUserID])
);




GO
CREATE NONCLUSTERED INDEX [IX_IntegratorUserIndustryCategoryJobs_IntegratorUserIndustryCategoryID]
    ON [dbo].[IntegratorUserIndustryCategoryJobs]([IntegratorUserIndustryCategoryID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_IntegratorUserIndustryCategoryJobs_IntegratorUserID]
    ON [dbo].[IntegratorUserIndustryCategoryJobs]([IntegratorUserID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_IntegratorUserIndustryCategoryJobs_CoreKBIndustryCategoryJobID]
    ON [dbo].[IntegratorUserIndustryCategoryJobs]([CoreKBIndustryCategoryJobID] ASC);


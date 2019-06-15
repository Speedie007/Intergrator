CREATE TABLE [dbo].[CompanyJobs] (
    [CompanyJobID]   INT           IDENTITY (1, 1) NOT NULL,
    [CompanyID]      INT           NOT NULL,
    [CoreKbJobID]    INT           NOT NULL,
    [JobDescription] VARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_CompanyJobs] PRIMARY KEY CLUSTERED ([CompanyJobID] ASC),
    CONSTRAINT [FK_CompanyJobs_Company] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[Companies] ([CompanyID]),
    CONSTRAINT [FK_CompanyJobs_CoreKBJobs] FOREIGN KEY ([CoreKbJobID]) REFERENCES [dbo].[CoreKbJobs] ([CoreKbJobID])
);


GO
CREATE NONCLUSTERED INDEX [IX_CompanyJobs_CoreKbJobID]
    ON [dbo].[CompanyJobs]([CoreKbJobID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CompanyJobs_CompanyID]
    ON [dbo].[CompanyJobs]([CompanyID] ASC);


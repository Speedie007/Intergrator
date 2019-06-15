CREATE TABLE [dbo].[CompanyJobListings] (
    [CompanyJobListingID] INT      IDENTITY (1, 1) NOT NULL,
    [CompanyJobID]        INT      NOT NULL,
    [DateStarted]         DATETIME DEFAULT (getdate()) NOT NULL,
    [DateEnded]           DATETIME DEFAULT (getdate()) NOT NULL,
    [LevelOfUrgentcy]     INT      NOT NULL,
    CONSTRAINT [PK_CompanyJobListings] PRIMARY KEY CLUSTERED ([CompanyJobListingID] ASC),
    CONSTRAINT [FK_CompanyJobListings_CompanyJobs] FOREIGN KEY ([CompanyJobID]) REFERENCES [dbo].[CompanyJobs] ([CompanyJobID])
);


GO
CREATE NONCLUSTERED INDEX [IX_CompanyJobListings_CompanyJobID]
    ON [dbo].[CompanyJobListings]([CompanyJobID] ASC);


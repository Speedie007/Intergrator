CREATE TABLE [dbo].[CompanyJobRepresentitives] (
    [CompanyJobRepresentitiveID] INT IDENTITY (1, 1) NOT NULL,
    [CompanyRepresentativeID]    INT NOT NULL,
    [CompanyJobID]               INT NOT NULL,
    CONSTRAINT [PK_CompanyJobRepresentitives] PRIMARY KEY CLUSTERED ([CompanyJobRepresentitiveID] ASC),
    CONSTRAINT [FK_CompanyJobRepresentitives_CompanyJobs] FOREIGN KEY ([CompanyJobID]) REFERENCES [dbo].[CompanyJobs] ([CompanyJobID]),
    CONSTRAINT [FK_CompanyJobRepresentitives_CompanyRepresentatives] FOREIGN KEY ([CompanyRepresentativeID]) REFERENCES [dbo].[CompanyRepresentatives] ([CompanyRepresentativeID])
);


GO
CREATE NONCLUSTERED INDEX [IX_CompanyJobRepresentitives_CompanyRepresentativeID]
    ON [dbo].[CompanyJobRepresentitives]([CompanyRepresentativeID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CompanyJobRepresentitives_CompanyJobID]
    ON [dbo].[CompanyJobRepresentitives]([CompanyJobID] ASC);


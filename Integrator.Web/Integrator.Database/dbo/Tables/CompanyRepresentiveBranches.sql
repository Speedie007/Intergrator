CREATE TABLE [dbo].[CompanyRepresentiveBranches] (
    [CompanyRepresentiveBranchID] INT IDENTITY (1, 1) NOT NULL,
    [CompanyBranchID]             INT NOT NULL,
    [CompanyRepresentativeID]     INT NOT NULL,
    CONSTRAINT [PK_CompanyRepresentiveBranches] PRIMARY KEY CLUSTERED ([CompanyRepresentiveBranchID] ASC),
    CONSTRAINT [FK_CompnayRepresentiveBanches_CompanyBranches] FOREIGN KEY ([CompanyBranchID]) REFERENCES [dbo].[CompanyBranches] ([CompanyBranchID]),
    CONSTRAINT [FK_CompnayRepresentiveBanches_CompanyRepresentatives] FOREIGN KEY ([CompanyRepresentativeID]) REFERENCES [dbo].[CompanyRepresentatives] ([CompanyRepresentativeID])
);


GO
CREATE NONCLUSTERED INDEX [IX_CompanyRepresentiveBranches_CompanyRepresentativeID]
    ON [dbo].[CompanyRepresentiveBranches]([CompanyRepresentativeID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CompanyRepresentiveBranches_CompanyBranchID]
    ON [dbo].[CompanyRepresentiveBranches]([CompanyBranchID] ASC);


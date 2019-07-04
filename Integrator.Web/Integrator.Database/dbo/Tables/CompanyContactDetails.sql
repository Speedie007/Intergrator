CREATE TABLE [dbo].[CompanyContactDetails] (
    [CompanyContactDetailID] INT IDENTITY (1, 1) NOT NULL,
    [ContactDetailID]        INT NOT NULL,
    [CompanyBranchID]        INT NOT NULL,
    CONSTRAINT [PK_CompanyContactDetails] PRIMARY KEY CLUSTERED ([CompanyContactDetailID] ASC),
    CONSTRAINT [FK_CompanyContactDetails_CompanyBranches] FOREIGN KEY ([CompanyBranchID]) REFERENCES [dbo].[CompanyBranches] ([CompanyBranchID]),
    CONSTRAINT [FK_CompanyContactDetails_ContactDetails] FOREIGN KEY ([ContactDetailID]) REFERENCES [dbo].[ContactDetails] ([ContactDetailID])
);




GO
CREATE NONCLUSTERED INDEX [IX_CompanyContactDetails_ContactDetailID]
    ON [dbo].[CompanyContactDetails]([ContactDetailID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CompanyContactDetails_CompanyBranchID]
    ON [dbo].[CompanyContactDetails]([CompanyBranchID] ASC);


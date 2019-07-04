CREATE TABLE [dbo].[CompanyBranches] (
    [CompanyBranchID] INT            IDENTITY (1, 1) NOT NULL,
    [AddressID]       INT            NOT NULL,
    [CompanyID]       INT            NOT NULL,
    [BranchName]      NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_CompanyBranches] PRIMARY KEY CLUSTERED ([CompanyBranchID] ASC),
    CONSTRAINT [FK_CompanyAddresses_Companies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[Companies] ([CompanyID]),
    CONSTRAINT [FK_CompanyBranches_Addresses_AddressID] FOREIGN KEY ([AddressID]) REFERENCES [dbo].[Addresses] ([AddressID]) ON DELETE CASCADE
);




GO
CREATE NONCLUSTERED INDEX [IX_CompanyBranches_CompanyID]
    ON [dbo].[CompanyBranches]([CompanyID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CompanyBranches_AddressID]
    ON [dbo].[CompanyBranches]([AddressID] ASC);


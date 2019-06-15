CREATE TABLE [dbo].[CompanyContactDetails] (
    [CompanyContactDetailID] INT IDENTITY (1, 1) NOT NULL,
    [ContactDetailID]        INT NOT NULL,
    [CompanyID]              INT NOT NULL,
    CONSTRAINT [PK_CompanyContactDetails] PRIMARY KEY CLUSTERED ([CompanyContactDetailID] ASC),
    CONSTRAINT [FK_CompanyContactDetails_Companies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[Companies] ([CompanyID]),
    CONSTRAINT [FK_CompanyContactDetails_ContactDetails] FOREIGN KEY ([ContactDetailID]) REFERENCES [dbo].[ContactDetails] ([ContactDetailID])
);


GO
CREATE NONCLUSTERED INDEX [IX_CompanyContactDetails_ContactDetailID]
    ON [dbo].[CompanyContactDetails]([ContactDetailID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CompanyContactDetails_CompanyID]
    ON [dbo].[CompanyContactDetails]([CompanyID] ASC);


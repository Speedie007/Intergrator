CREATE TABLE [dbo].[IntegratorUserContactDetails] (
    [IntegratorUserContactDetailID] INT      IDENTITY (1, 1) NOT NULL,
    [IntegratorUserID]              INT      NOT NULL,
    [ContactDetailID]               INT      NOT NULL,
    [DateLastUpdated]               DATETIME DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_IntegratorUserContactDetails] PRIMARY KEY CLUSTERED ([IntegratorUserContactDetailID] ASC),
    CONSTRAINT [FK_IntegratorUserContactDetails_ContactDetails] FOREIGN KEY ([ContactDetailID]) REFERENCES [dbo].[ContactDetails] ([ContactDetailID]),
    CONSTRAINT [FK_IntegratorUserContactDetails_IntegratorUsers] FOREIGN KEY ([IntegratorUserID]) REFERENCES [dbo].[IntegratorUsers] ([IntegratorUserID])
);


GO
CREATE NONCLUSTERED INDEX [IX_IntegratorUserContactDetails_IntegratorUserID]
    ON [dbo].[IntegratorUserContactDetails]([IntegratorUserID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_IntegratorUserContactDetails_ContactDetailID]
    ON [dbo].[IntegratorUserContactDetails]([ContactDetailID] ASC);


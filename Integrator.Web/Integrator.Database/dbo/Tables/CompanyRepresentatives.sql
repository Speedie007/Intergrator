CREATE TABLE [dbo].[CompanyRepresentatives] (
    [CompanyRepresentativeID] INT IDENTITY (1, 1) NOT NULL,
    [IntegratorUserID]        INT NOT NULL,
    [CompanyID]               INT NOT NULL,
    CONSTRAINT [PK_CompanyRepresentatives] PRIMARY KEY CLUSTERED ([CompanyRepresentativeID] ASC),
    CONSTRAINT [FK_CompanyRepresentatives_Companies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[Companies] ([CompanyID]),
    CONSTRAINT [FK_CompanyRepresentatives_IntegratorUsers] FOREIGN KEY ([IntegratorUserID]) REFERENCES [dbo].[IntegratorUsers] ([IntegratorUserID])
);




GO
CREATE NONCLUSTERED INDEX [IX_CompanyRepresentatives_IntegratorUserID]
    ON [dbo].[CompanyRepresentatives]([IntegratorUserID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CompanyRepresentatives_CompanyID]
    ON [dbo].[CompanyRepresentatives]([CompanyID] ASC);


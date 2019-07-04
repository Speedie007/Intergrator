CREATE TABLE [dbo].[IndividualAddresses] (
    [IndividualAddressID] INT      IDENTITY (1, 1) NOT NULL,
    [AddressID]           INT      NOT NULL,
    [IntegratorUserID]    INT      NOT NULL,
    [DateCreated]         DATETIME DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_IndividualAddresses] PRIMARY KEY CLUSTERED ([IndividualAddressID] ASC),
    CONSTRAINT [FK_CustomerAddresses_Addresses] FOREIGN KEY ([AddressID]) REFERENCES [dbo].[Addresses] ([AddressID]),
    CONSTRAINT [FK_CustomerAddresses_IntegratorUsers] FOREIGN KEY ([IntegratorUserID]) REFERENCES [dbo].[IntegratorUsers] ([IntegratorUserID])
);


GO
CREATE NONCLUSTERED INDEX [IX_IndividualAddresses_IntegratorUserID]
    ON [dbo].[IndividualAddresses]([IntegratorUserID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_IndividualAddresses_AddressID]
    ON [dbo].[IndividualAddresses]([AddressID] ASC);


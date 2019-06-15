CREATE TABLE [dbo].[CompanyAddresses] (
    [CompanyAddressID] INT IDENTITY (1, 1) NOT NULL,
    [AddressID]        INT NOT NULL,
    [CompanyID]        INT NOT NULL,
    CONSTRAINT [PK_CompanyAddresses] PRIMARY KEY CLUSTERED ([CompanyAddressID] ASC),
    CONSTRAINT [FK_CompanyAddresses_Addresses] FOREIGN KEY ([AddressID]) REFERENCES [dbo].[Addresses] ([AddressID]),
    CONSTRAINT [FK_CompanyAddresses_Companies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[Companies] ([CompanyID])
);


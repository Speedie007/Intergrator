CREATE TABLE [dbo].[Addresses] (
    [AddressID]         INT            IDENTITY (1, 1) NOT NULL,
    [City]              NVARCHAR (MAX) NULL,
    [Suburb]            NVARCHAR (MAX) NULL,
    [AreaCode]          NVARCHAR (MAX) NULL,
    [IntegratorUserID]  INT            NOT NULL,
    [CountryID]         INT            NOT NULL,
    [Country]           NVARCHAR (MAX) NULL,
    [AddressType]       INT            NOT NULL,
    [ComplexName]       NVARCHAR (MAX) NULL,
    [ComplexUnitNumber] NVARCHAR (MAX) NULL,
    [POBoxNumber]       NVARCHAR (MAX) NULL,
    [StreetNumber]      NVARCHAR (MAX) NULL,
    [StreetName]        NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED ([AddressID] ASC),
    CONSTRAINT [FK_Addresses_IntegratorUsers_IntegratorUserID] FOREIGN KEY ([IntegratorUserID]) REFERENCES [dbo].[IntegratorUsers] ([IntegratorUserID]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Addresses_IntegratorUserID]
    ON [dbo].[Addresses]([IntegratorUserID] ASC);


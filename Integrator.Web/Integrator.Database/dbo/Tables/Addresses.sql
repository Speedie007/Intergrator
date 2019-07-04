CREATE TABLE [dbo].[Addresses] (
    [AddressID]         INT            IDENTITY (1, 1) NOT NULL,
    [AreaCode]          NVARCHAR (MAX) NULL,
    [SuburbID]          INT            NOT NULL,
    [CountryID]         INT            NOT NULL,
    [AddressType]       INT            NOT NULL,
    [ComplexName]       NVARCHAR (MAX) NULL,
    [ComplexUnitNumber] NVARCHAR (MAX) NULL,
    [POBoxNumber]       NVARCHAR (MAX) NULL,
    [StreetNumber]      NVARCHAR (MAX) NULL,
    [StreetName]        NVARCHAR (MAX) NULL,
    [CityID]            INT            DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED ([AddressID] ASC),
    CONSTRAINT [FK_Addresses_Cities] FOREIGN KEY ([CityID]) REFERENCES [dbo].[Cities] ([CityID]),
    CONSTRAINT [FK_Addresses_Countries] FOREIGN KEY ([CountryID]) REFERENCES [dbo].[Countries] ([CountryID]),
    CONSTRAINT [FK_Addresses_Suburbs] FOREIGN KEY ([SuburbID]) REFERENCES [dbo].[Suburbs] ([SuburbID])
);




GO
CREATE NONCLUSTERED INDEX [IX_Addresses_SuburbID]
    ON [dbo].[Addresses]([SuburbID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Addresses_CountryID]
    ON [dbo].[Addresses]([CountryID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Addresses_CityID]
    ON [dbo].[Addresses]([CityID] ASC);


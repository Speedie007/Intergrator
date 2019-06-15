CREATE TABLE [dbo].[Cities] (
    [CityID]    INT           IDENTITY (1, 1) NOT NULL,
    [CountryID] INT           NOT NULL,
    [CityName]  VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Cities] PRIMARY KEY CLUSTERED ([CityID] ASC),
    CONSTRAINT [FK_Cities_Countries] FOREIGN KEY ([CountryID]) REFERENCES [dbo].[Countries] ([CountryID])
);


GO
CREATE NONCLUSTERED INDEX [IX_Cities_CountryID]
    ON [dbo].[Cities]([CountryID] ASC);


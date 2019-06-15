CREATE TABLE [dbo].[Suburbs] (
    [SuburbID]   INT           IDENTITY (1, 1) NOT NULL,
    [CityID]     INT           NOT NULL,
    [SuburbName] VARCHAR (100) NULL,
    CONSTRAINT [PK_Suburbs] PRIMARY KEY CLUSTERED ([SuburbID] ASC),
    CONSTRAINT [FK_Suburbs_Cities] FOREIGN KEY ([CityID]) REFERENCES [dbo].[Cities] ([CityID])
);


GO
CREATE NONCLUSTERED INDEX [IX_Suburbs_CityID]
    ON [dbo].[Suburbs]([CityID] ASC);


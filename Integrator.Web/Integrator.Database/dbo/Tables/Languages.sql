CREATE TABLE [dbo].[Languages] (
    [LanguageID] INT           IDENTITY (1, 1) NOT NULL,
    [Language]   VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Languages] PRIMARY KEY CLUSTERED ([LanguageID] ASC)
);


﻿CREATE TABLE [dbo].[Countries] (
    [CountryID]   INT           IDENTITY (1, 1) NOT NULL,
    [CountryName] VARCHAR (100) NOT NULL,
    [CountryCode] VARCHAR (10)  NOT NULL,
    CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED ([CountryID] ASC)
);


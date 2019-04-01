﻿CREATE TABLE [dbo].[Interests] (
    [InterestID] INT           IDENTITY (1, 1) NOT NULL,
    [Interest]   VARCHAR (250) NOT NULL,
    CONSTRAINT [PK_Interests] PRIMARY KEY CLUSTERED ([InterestID] ASC)
);


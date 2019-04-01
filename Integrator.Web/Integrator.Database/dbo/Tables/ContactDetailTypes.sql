CREATE TABLE [dbo].[ContactDetailTypes] (
    [ContactDetailTypeID] INT           IDENTITY (1, 1) NOT NULL,
    [ContactDetailType]   VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_ContactDetailTypes] PRIMARY KEY CLUSTERED ([ContactDetailTypeID] ASC)
);


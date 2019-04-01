CREATE TABLE [dbo].[CoreKBIndustryTypes] (
    [IndustryID] INT           IDENTITY (1, 1) NOT NULL,
    [Industry]   VARCHAR (100) NULL,
    CONSTRAINT [PK_CoreKBIndustryTypes] PRIMARY KEY CLUSTERED ([IndustryID] ASC)
);


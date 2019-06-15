CREATE TABLE [dbo].[CoreKbIndustryCategories] (
    [CoreKbIndustryCategoryID] INT            IDENTITY (1, 1) NOT NULL,
    [CoreKBIndustryCategory]   NVARCHAR (100) NULL,
    CONSTRAINT [PK_CoreKbIndustryCategories] PRIMARY KEY CLUSTERED ([CoreKbIndustryCategoryID] ASC)
);




GO



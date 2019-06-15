CREATE TABLE [dbo].[CoreKbIndustries] (
    [CoreKbIndustryID]         INT           IDENTITY (1, 1) NOT NULL,
    [CoreKbIndustryCategoryID] INT           NOT NULL,
    [CoreKBIndustryName]       VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_CoreKbIndustries] PRIMARY KEY CLUSTERED ([CoreKbIndustryID] ASC),
    CONSTRAINT [FK_CoreKbIndustrySectors_CoreKBIdustryCategories] FOREIGN KEY ([CoreKbIndustryCategoryID]) REFERENCES [dbo].[CoreKbIndustryCategories] ([CoreKbIndustryCategoryID])
);


GO
CREATE NONCLUSTERED INDEX [IX_CoreKbIndustries_CoreKbIndustryCategoryID]
    ON [dbo].[CoreKbIndustries]([CoreKbIndustryCategoryID] ASC);


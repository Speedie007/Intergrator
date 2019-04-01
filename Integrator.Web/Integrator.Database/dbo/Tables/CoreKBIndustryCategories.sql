CREATE TABLE [dbo].[CoreKBIndustryCategories] (
    [IndustryCategoryID] INT            IDENTITY (1, 1) NOT NULL,
    [Category]           NVARCHAR (100) NULL,
    [IndustryID]         INT            NOT NULL,
    CONSTRAINT [PK_CoreKBIndustryCategories] PRIMARY KEY CLUSTERED ([IndustryCategoryID] ASC),
    CONSTRAINT [FK_IndustryCategories_Industries] FOREIGN KEY ([IndustryID]) REFERENCES [dbo].[CoreKBIndustryTypes] ([IndustryID])
);


GO
CREATE NONCLUSTERED INDEX [IX_CoreKBIndustryCategories_IndustryID]
    ON [dbo].[CoreKBIndustryCategories]([IndustryID] ASC);


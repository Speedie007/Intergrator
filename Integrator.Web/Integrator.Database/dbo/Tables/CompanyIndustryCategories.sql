CREATE TABLE [dbo].[CompanyIndustryCategories] (
    [CompanyIndustryCategoryID] INT           IDENTITY (1, 1) NOT NULL,
    [CompanyID]                 INT           NOT NULL,
    [CoreKBIndustryCategoryID]  INT           NOT NULL,
    [CompanyIndustryID]         INT           NOT NULL,
    [Description]               VARCHAR (150) NULL,
    [DateLastUpdated]           DATETIME      NULL,
    CONSTRAINT [PK_CompanyIndustryCategories] PRIMARY KEY CLUSTERED ([CompanyIndustryCategoryID] ASC),
    CONSTRAINT [FK_CompanyIndustryCategories_Companies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[Company] ([CompanyID]),
    CONSTRAINT [FK_CompanyIndustryCategories_CompanyIndustries] FOREIGN KEY ([CompanyIndustryID]) REFERENCES [dbo].[CompanyIndustries] ([CompanyIndustryID]),
    CONSTRAINT [FK_CompanyIndustryCategories_IndustryCategories] FOREIGN KEY ([CoreKBIndustryCategoryID]) REFERENCES [dbo].[CoreKBIndustryCategories] ([IndustryCategoryID])
);


GO
CREATE NONCLUSTERED INDEX [IX_CompanyIndustryCategories_CoreKBIndustryCategoryID]
    ON [dbo].[CompanyIndustryCategories]([CoreKBIndustryCategoryID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CompanyIndustryCategories_CompanyIndustryID]
    ON [dbo].[CompanyIndustryCategories]([CompanyIndustryID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CompanyIndustryCategories_CompanyID]
    ON [dbo].[CompanyIndustryCategories]([CompanyID] ASC);


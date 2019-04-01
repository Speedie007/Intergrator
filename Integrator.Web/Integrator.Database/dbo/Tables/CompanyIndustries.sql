CREATE TABLE [dbo].[CompanyIndustries] (
    [CompanyIndustryID] INT           IDENTITY (1, 1) NOT NULL,
    [CompanyID]         INT           NOT NULL,
    [CoreKBIndustryID]  INT           NOT NULL,
    [Description]       VARCHAR (150) NULL,
    [DateLastUpdated]   DATETIME      NULL,
    CONSTRAINT [PK_CompanyIndustries] PRIMARY KEY CLUSTERED ([CompanyIndustryID] ASC),
    CONSTRAINT [FK_CompanyIndustries_Companies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[Company] ([CompanyID]) ON DELETE CASCADE,
    CONSTRAINT [FK_CompanyIndustries_Industries] FOREIGN KEY ([CoreKBIndustryID]) REFERENCES [dbo].[CoreKBIndustryTypes] ([IndustryID])
);


GO
CREATE NONCLUSTERED INDEX [IX_CompanyIndustries_CoreKBIndustryID]
    ON [dbo].[CompanyIndustries]([CoreKBIndustryID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CompanyIndustries_CompanyID]
    ON [dbo].[CompanyIndustries]([CompanyID] ASC);


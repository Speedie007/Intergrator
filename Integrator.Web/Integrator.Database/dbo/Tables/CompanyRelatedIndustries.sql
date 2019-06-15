CREATE TABLE [dbo].[CompanyRelatedIndustries] (
    [CompanyRelatedIndustryID] INT IDENTITY (1, 1) NOT NULL,
    [CoreKbIndustryID]         INT NOT NULL,
    [CompanyID]                INT NOT NULL,
    CONSTRAINT [PK_CompanyRelatedIndustries] PRIMARY KEY CLUSTERED ([CompanyRelatedIndustryID] ASC),
    CONSTRAINT [FK_CompanyRelatedIndustries_Company] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[Companies] ([CompanyID]),
    CONSTRAINT [FK_CompanyRelatedIndustries_CoreKbIndustries] FOREIGN KEY ([CoreKbIndustryID]) REFERENCES [dbo].[CoreKbIndustries] ([CoreKbIndustryID])
);


GO
CREATE NONCLUSTERED INDEX [IX_CompanyRelatedIndustries_CoreKbIndustryID]
    ON [dbo].[CompanyRelatedIndustries]([CoreKbIndustryID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CompanyRelatedIndustries_CompanyID]
    ON [dbo].[CompanyRelatedIndustries]([CompanyID] ASC);


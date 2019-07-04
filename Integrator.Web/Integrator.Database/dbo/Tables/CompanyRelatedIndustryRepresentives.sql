CREATE TABLE [dbo].[CompanyRelatedIndustryRepresentives] (
    [CompanyRelatedIndustryRepresentiveID] INT      IDENTITY (1, 1) NOT NULL,
    [CompanyRelatedIndustryID]             INT      NOT NULL,
    [CompanyRepresentativeID]              INT      NOT NULL,
    [DateAssigned]                         DATETIME DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_CompanyRelatedIndustryRepresentives] PRIMARY KEY CLUSTERED ([CompanyRelatedIndustryRepresentiveID] ASC),
    CONSTRAINT [FK_CompanyRelatedIndustryRepresentives_CompanyRelatedIndustries] FOREIGN KEY ([CompanyRelatedIndustryID]) REFERENCES [dbo].[CompanyRelatedIndustries] ([CompanyRelatedIndustryID]),
    CONSTRAINT [FK_CompanyRelatedIndustryRepresentives_CompanyRepresentatives] FOREIGN KEY ([CompanyRepresentativeID]) REFERENCES [dbo].[CompanyRepresentatives] ([CompanyRepresentativeID])
);


GO
CREATE NONCLUSTERED INDEX [IX_CompanyRelatedIndustryRepresentives_CompanyRepresentativeID]
    ON [dbo].[CompanyRelatedIndustryRepresentives]([CompanyRepresentativeID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CompanyRelatedIndustryRepresentives_CompanyRelatedIndustryID]
    ON [dbo].[CompanyRelatedIndustryRepresentives]([CompanyRelatedIndustryID] ASC);


CREATE TABLE [dbo].[IntegratorUserIndustryCategories] (
    [IntegratorUserIndustryCategoryID] INT           IDENTITY (1, 1) NOT NULL,
    [IntegratorUserID]                 INT           NOT NULL,
    [IntegratorUserIndustryID]         INT           NOT NULL,
    [CoreKBIndustryCategoryID]         INT           NOT NULL,
    [Description]                      VARCHAR (150) NULL,
    [DateLastUpdated]                  DATETIME      NULL,
    CONSTRAINT [PK_IntegratorUserIndustryCategories] PRIMARY KEY CLUSTERED ([IntegratorUserIndustryCategoryID] ASC),
    CONSTRAINT [FK_IntegratorUserIndustryCategories_IndustryCategories] FOREIGN KEY ([CoreKBIndustryCategoryID]) REFERENCES [dbo].[CoreKBIndustryCategories] ([IndustryCategoryID]),
    CONSTRAINT [FK_IntegratorUserIndustryCategories_UserIndustries] FOREIGN KEY ([IntegratorUserIndustryID]) REFERENCES [dbo].[IntegratorUserIndustries] ([IntegratorUserIndustryID]),
    CONSTRAINT [FK_IntegratorUserIndustryCategories_Users] FOREIGN KEY ([IntegratorUserID]) REFERENCES [dbo].[IntegratorUsers] ([IntegratorUserID])
);


GO
CREATE NONCLUSTERED INDEX [IX_IntegratorUserIndustryCategories_IntegratorUserIndustryID]
    ON [dbo].[IntegratorUserIndustryCategories]([IntegratorUserIndustryID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_IntegratorUserIndustryCategories_IntegratorUserID]
    ON [dbo].[IntegratorUserIndustryCategories]([IntegratorUserID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_IntegratorUserIndustryCategories_CoreKBIndustryCategoryID]
    ON [dbo].[IntegratorUserIndustryCategories]([CoreKBIndustryCategoryID] ASC);


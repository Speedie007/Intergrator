CREATE TABLE [dbo].[IntegratorUserIndustries] (
    [IntegratorUserIndustryID] INT            IDENTITY (1, 1) NOT NULL,
    [IntegratorUserID]         INT            NOT NULL,
    [CoreKBIndustryID]         INT            NOT NULL,
    [Description]              NVARCHAR (150) NULL,
    CONSTRAINT [PK_IntegratorUserIndustries] PRIMARY KEY CLUSTERED ([IntegratorUserIndustryID] ASC),
    CONSTRAINT [FK_UserIndustries_Industries] FOREIGN KEY ([CoreKBIndustryID]) REFERENCES [dbo].[CoreKBIndustryTypes] ([IndustryID]),
    CONSTRAINT [FK_UserIndustries_Users] FOREIGN KEY ([IntegratorUserID]) REFERENCES [dbo].[IntegratorUsers] ([IntegratorUserID])
);


GO
CREATE NONCLUSTERED INDEX [IX_IntegratorUserIndustries_IntegratorUserID]
    ON [dbo].[IntegratorUserIndustries]([IntegratorUserID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_IntegratorUserIndustries_CoreKBIndustryID]
    ON [dbo].[IntegratorUserIndustries]([CoreKBIndustryID] ASC);


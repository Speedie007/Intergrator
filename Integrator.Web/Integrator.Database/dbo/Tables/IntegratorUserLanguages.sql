CREATE TABLE [dbo].[IntegratorUserLanguages] (
    [IntegratorUserLanguageID] INT IDENTITY (1, 1) NOT NULL,
    [IntegratorUserID]         INT NOT NULL,
    [LanguageID]               INT NOT NULL,
    [IsPrimaryLanguage]        BIT NOT NULL,
    [CanSpeakAndWrite]         BIT NOT NULL,
    CONSTRAINT [PK_IntegratorUserLanguages] PRIMARY KEY CLUSTERED ([IntegratorUserLanguageID] ASC),
    CONSTRAINT [FK_IntegratorUserLanguages_IntegratorUsers] FOREIGN KEY ([IntegratorUserID]) REFERENCES [dbo].[IntegratorUsers] ([IntegratorUserID]),
    CONSTRAINT [FK_IntegratorUserLanguages_Languages] FOREIGN KEY ([LanguageID]) REFERENCES [dbo].[Languages] ([LanguageID])
);


GO
CREATE NONCLUSTERED INDEX [IX_IntegratorUserLanguages_LanguageID]
    ON [dbo].[IntegratorUserLanguages]([LanguageID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_IntegratorUserLanguages_IntegratorUserID]
    ON [dbo].[IntegratorUserLanguages]([IntegratorUserID] ASC);


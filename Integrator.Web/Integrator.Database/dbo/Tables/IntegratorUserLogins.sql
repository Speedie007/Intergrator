CREATE TABLE [dbo].[IntegratorUserLogins] (
    [LoginProvider]       NVARCHAR (450) NOT NULL,
    [ProviderKey]         NVARCHAR (450) NOT NULL,
    [ProviderDisplayName] NVARCHAR (MAX) NULL,
    [IntegratorUserID]    INT            NOT NULL,
    CONSTRAINT [PK_IntegratorUserLogins] PRIMARY KEY CLUSTERED ([LoginProvider] ASC, [ProviderKey] ASC),
    CONSTRAINT [FK_IntegratorUserLogins_IntegratorUsers_IntegratorUserID] FOREIGN KEY ([IntegratorUserID]) REFERENCES [dbo].[IntegratorUsers] ([IntegratorUserID]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_IntegratorUserLogins_IntegratorUserID]
    ON [dbo].[IntegratorUserLogins]([IntegratorUserID] ASC);


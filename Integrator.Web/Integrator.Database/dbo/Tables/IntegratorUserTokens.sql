CREATE TABLE [dbo].[IntegratorUserTokens] (
    [IntegratorUserID] INT            NOT NULL,
    [LoginProvider]    NVARCHAR (450) NOT NULL,
    [Name]             NVARCHAR (450) NOT NULL,
    [Value]            NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_IntegratorUserTokens] PRIMARY KEY CLUSTERED ([IntegratorUserID] ASC, [LoginProvider] ASC, [Name] ASC),
    CONSTRAINT [FK_IntegratorUserTokens_IntegratorUsers_IntegratorUserID] FOREIGN KEY ([IntegratorUserID]) REFERENCES [dbo].[IntegratorUsers] ([IntegratorUserID]) ON DELETE CASCADE
);


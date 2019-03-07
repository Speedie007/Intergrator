CREATE TABLE [dbo].[IntegratorUserRoles] (
    [IntegratorUserID] INT NOT NULL,
    [IntegratorRoleID] INT NOT NULL,
    CONSTRAINT [PK_IntegratorUserRoles] PRIMARY KEY CLUSTERED ([IntegratorUserID] ASC, [IntegratorRoleID] ASC),
    CONSTRAINT [FK_IntegratorUserRoles_IntegratorRoles_IntegratorRoleID] FOREIGN KEY ([IntegratorRoleID]) REFERENCES [dbo].[IntegratorRoles] ([IntegratorRoleID]) ON DELETE CASCADE,
    CONSTRAINT [FK_IntegratorUserRoles_IntegratorUsers_IntegratorUserID] FOREIGN KEY ([IntegratorUserID]) REFERENCES [dbo].[IntegratorUsers] ([IntegratorUserID]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_IntegratorUserRoles_IntegratorRoleID]
    ON [dbo].[IntegratorUserRoles]([IntegratorRoleID] ASC);


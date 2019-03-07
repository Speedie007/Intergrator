CREATE TABLE [dbo].[IntegratorRoleClaims] (
    [IntegratorRoleClaimID] INT            IDENTITY (1, 1) NOT NULL,
    [BIntegratorRoleID]     INT            NOT NULL,
    [ClaimType]             NVARCHAR (MAX) NULL,
    [ClaimValue]            NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_IntegratorRoleClaims] PRIMARY KEY CLUSTERED ([IntegratorRoleClaimID] ASC),
    CONSTRAINT [FK_IntegratorRoleClaims_IntegratorRoles_BIntegratorRoleID] FOREIGN KEY ([BIntegratorRoleID]) REFERENCES [dbo].[IntegratorRoles] ([IntegratorRoleID]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_IntegratorRoleClaims_BIntegratorRoleID]
    ON [dbo].[IntegratorRoleClaims]([BIntegratorRoleID] ASC);


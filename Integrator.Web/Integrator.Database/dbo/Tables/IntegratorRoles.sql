CREATE TABLE [dbo].[IntegratorRoles] (
    [IntegratorRoleID] INT            IDENTITY (1, 1) NOT NULL,
    [Name]             NVARCHAR (256) NULL,
    [NormalizedName]   NVARCHAR (256) NULL,
    [ConcurrencyStamp] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_IntegratorRoles] PRIMARY KEY CLUSTERED ([IntegratorRoleID] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex]
    ON [dbo].[IntegratorRoles]([NormalizedName] ASC) WHERE ([NormalizedName] IS NOT NULL);


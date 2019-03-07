CREATE TABLE [dbo].[IntegratorUserClaims] (
    [IntegratorUserClaimID] INT            IDENTITY (1, 1) NOT NULL,
    [IntegratorUserID]      INT            NOT NULL,
    [ClaimType]             NVARCHAR (MAX) NULL,
    [ClaimValue]            NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_IntegratorUserClaims] PRIMARY KEY CLUSTERED ([IntegratorUserClaimID] ASC),
    CONSTRAINT [FK_IntegratorUserClaims_IntegratorUsers_IntegratorUserID] FOREIGN KEY ([IntegratorUserID]) REFERENCES [dbo].[IntegratorUsers] ([IntegratorUserID]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_IntegratorUserClaims_IntegratorUserID]
    ON [dbo].[IntegratorUserClaims]([IntegratorUserID] ASC);


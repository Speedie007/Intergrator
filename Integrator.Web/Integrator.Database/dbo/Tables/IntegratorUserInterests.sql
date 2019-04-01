CREATE TABLE [dbo].[IntegratorUserInterests] (
    [IntegratorUserInterestID] INT        IDENTITY (1, 1) NOT NULL,
    [IntegratorUserID]         INT        NOT NULL,
    [InterestID]               INT        NOT NULL,
    [InterestLevel]            FLOAT (53) NOT NULL,
    CONSTRAINT [PK_IntegratorUserInterests] PRIMARY KEY CLUSTERED ([IntegratorUserInterestID] ASC),
    CONSTRAINT [FK_IntegratorUserInterests_IntegratorUsers] FOREIGN KEY ([IntegratorUserID]) REFERENCES [dbo].[IntegratorUsers] ([IntegratorUserID]),
    CONSTRAINT [FK_IntegratorUserInterests_Interests] FOREIGN KEY ([InterestID]) REFERENCES [dbo].[Interests] ([InterestID])
);




GO
CREATE NONCLUSTERED INDEX [IX_IntegratorUserInterests_IntegratorUserID]
    ON [dbo].[IntegratorUserInterests]([IntegratorUserID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_IntegratorUserInterests_InterestID]
    ON [dbo].[IntegratorUserInterests]([InterestID] ASC);


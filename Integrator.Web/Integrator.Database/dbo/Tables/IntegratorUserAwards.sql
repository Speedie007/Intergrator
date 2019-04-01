CREATE TABLE [dbo].[IntegratorUserAwards] (
    [IntegratorUserAwardID] INT            IDENTITY (1, 1) NOT NULL,
    [IntegratorUserID]      INT            NOT NULL,
    [AwardTitle]            VARCHAR (100)  NOT NULL,
    [AwardDescription]      VARCHAR (2000) NOT NULL,
    CONSTRAINT [PK_IntegratorUserAwards] PRIMARY KEY CLUSTERED ([IntegratorUserAwardID] ASC),
    CONSTRAINT [FK_IntegratorUserAwards_IntegratorUsers] FOREIGN KEY ([IntegratorUserID]) REFERENCES [dbo].[IntegratorUsers] ([IntegratorUserID])
);


GO
CREATE NONCLUSTERED INDEX [IX_IntegratorUserAwards_IntegratorUserID]
    ON [dbo].[IntegratorUserAwards]([IntegratorUserID] ASC);


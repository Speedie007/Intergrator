CREATE TABLE [dbo].[AgentAreas] (
    [AgentAreaID]      INT      IDENTITY (1, 1) NOT NULL,
    [SuburbID]         INT      NOT NULL,
    [IntegratorUserID] INT      NOT NULL,
    [DateAssigned]     DATETIME DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_AgentAreas] PRIMARY KEY CLUSTERED ([AgentAreaID] ASC),
    CONSTRAINT [FK_AgentAreas_IntegratorUsers] FOREIGN KEY ([IntegratorUserID]) REFERENCES [dbo].[IntegratorUsers] ([IntegratorUserID]),
    CONSTRAINT [FK_AgentAreas_Suburbs] FOREIGN KEY ([SuburbID]) REFERENCES [dbo].[Suburbs] ([SuburbID])
);


GO
CREATE NONCLUSTERED INDEX [IX_AgentAreas_SuburbID]
    ON [dbo].[AgentAreas]([SuburbID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_AgentAreas_IntegratorUserID]
    ON [dbo].[AgentAreas]([IntegratorUserID] ASC);


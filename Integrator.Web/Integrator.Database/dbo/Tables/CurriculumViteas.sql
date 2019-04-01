CREATE TABLE [dbo].[CurriculumViteas] (
    [CurriculumViteaID] INT           IDENTITY (1, 1) NOT NULL,
    [IntegratorUserID]  INT           NOT NULL,
    [DateLastUpdated]   DATETIME      NOT NULL,
    [CareerSummary]     VARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_CurriculumViteas] PRIMARY KEY CLUSTERED ([CurriculumViteaID] ASC),
    CONSTRAINT [FK_CurriculumViteas_IntegratorUsers] FOREIGN KEY ([IntegratorUserID]) REFERENCES [dbo].[IntegratorUsers] ([IntegratorUserID])
);


GO
CREATE NONCLUSTERED INDEX [IX_CurriculumViteas_IntegratorUserID]
    ON [dbo].[CurriculumViteas]([IntegratorUserID] ASC);


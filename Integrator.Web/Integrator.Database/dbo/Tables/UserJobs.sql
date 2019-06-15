CREATE TABLE [dbo].[UserJobs] (
    [UserJobID]                 INT           IDENTITY (1, 1) NOT NULL,
    [CurriculumViteaID]         INT           NOT NULL,
    [IntegratorUserID]          INT           NOT NULL,
    [CoreKbJobID]               INT           NOT NULL,
    [CompanyID]                 INT           NOT NULL,
    [DateStarted]               DATE          DEFAULT (getdate()) NOT NULL,
    [DateEnded]                 DATE          DEFAULT (getdate()) NOT NULL,
    [Achievments]               VARCHAR (MAX) DEFAULT ('') NULL,
    [WorkExperienceDescription] VARCHAR (MAX) NOT NULL,
    [IsCurrentJob]              BIT           NOT NULL,
    CONSTRAINT [PK_UserJobs] PRIMARY KEY CLUSTERED ([UserJobID] ASC),
    CONSTRAINT [FK_UserJobs_Company] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[Companies] ([CompanyID]),
    CONSTRAINT [FK_UserJobs_CoreKBJobs] FOREIGN KEY ([CoreKbJobID]) REFERENCES [dbo].[CoreKbJobs] ([CoreKbJobID]),
    CONSTRAINT [FK_UserJobs_CurriculumViteas] FOREIGN KEY ([CurriculumViteaID]) REFERENCES [dbo].[CurriculumViteas] ([CurriculumViteaID]),
    CONSTRAINT [FK_UserJobs_IntegratorUsers] FOREIGN KEY ([IntegratorUserID]) REFERENCES [dbo].[IntegratorUsers] ([IntegratorUserID])
);


GO
CREATE NONCLUSTERED INDEX [IX_UserJobs_IntegratorUserID]
    ON [dbo].[UserJobs]([IntegratorUserID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_UserJobs_CurriculumViteaID]
    ON [dbo].[UserJobs]([CurriculumViteaID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_UserJobs_CoreKbJobID]
    ON [dbo].[UserJobs]([CoreKbJobID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_UserJobs_CompanyID]
    ON [dbo].[UserJobs]([CompanyID] ASC);


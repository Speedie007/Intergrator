CREATE TABLE [dbo].[CurriculumViteaWorkExperiences] (
    [CurriculumViteaWorkExperienceID]     INT            IDENTITY (1, 1) NOT NULL,
    [CurriculumViteaID]                   INT            NOT NULL,
    [IntegratorUserIndustryCategoryJobID] INT            NOT NULL,
    [DateStarted]                         DATE           DEFAULT (getdate()) NOT NULL,
    [DateEnded]                           DATE           DEFAULT (getdate()) NOT NULL,
    [CompanyID]                           INT            NOT NULL,
    [Achievments]                         VARCHAR (MAX)  DEFAULT ('') NOT NULL,
    [WorkExperienceDescription]           NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_CurriculumViteaWorkExperiences] PRIMARY KEY CLUSTERED ([CurriculumViteaWorkExperienceID] ASC),
    CONSTRAINT [FK_CurriculumViteaWorkExperiences_Company] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[Company] ([CompanyID]),
    CONSTRAINT [FK_UseEmploymentHistory_IntegratorUserIndustryCategoryJobs] FOREIGN KEY ([IntegratorUserIndustryCategoryJobID]) REFERENCES [dbo].[IntegratorUserIndustryCategoryJobs] ([IntegratorUserIndustryCategoryJobID]),
    CONSTRAINT [FK_UserWorkExperienceHistory_CurriculumViteas] FOREIGN KEY ([CurriculumViteaID]) REFERENCES [dbo].[CurriculumViteas] ([CurriculumViteaID])
);




GO
CREATE NONCLUSTERED INDEX [IX_CurriculumViteaWorkExperiences_IntegratorUserIndustryCategoryJobID]
    ON [dbo].[CurriculumViteaWorkExperiences]([IntegratorUserIndustryCategoryJobID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CurriculumViteaWorkExperiences_CurriculumViteaID]
    ON [dbo].[CurriculumViteaWorkExperiences]([CurriculumViteaID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CurriculumViteaWorkExperiences_CompanyID]
    ON [dbo].[CurriculumViteaWorkExperiences]([CompanyID] ASC);


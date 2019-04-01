CREATE TABLE [dbo].[CurriculumVitaeWorkExperienceReferences] (
    [CurriculumVitaeWorkExperienceReferenceID] INT           IDENTITY (1, 1) NOT NULL,
    [CurriculumViteaWorkExperienceID]          INT           NOT NULL,
    [ContactFirstName]                         VARCHAR (100) NOT NULL,
    [ContactLastName]                          VARCHAR (100) NOT NULL,
    [HasBeenVerified]                          BIT           NOT NULL,
    CONSTRAINT [PK_CurriculumVitaeWorkExperienceReferences] PRIMARY KEY CLUSTERED ([CurriculumVitaeWorkExperienceReferenceID] ASC),
    CONSTRAINT [FK_CurriculumVitaeWorkExperienceReferences_CurriculumViteaWorkExperiences] FOREIGN KEY ([CurriculumViteaWorkExperienceID]) REFERENCES [dbo].[CurriculumViteaWorkExperiences] ([CurriculumViteaWorkExperienceID])
);


GO
CREATE NONCLUSTERED INDEX [IX_CurriculumVitaeWorkExperienceReferences_CurriculumViteaWorkExperienceID]
    ON [dbo].[CurriculumVitaeWorkExperienceReferences]([CurriculumViteaWorkExperienceID] ASC);


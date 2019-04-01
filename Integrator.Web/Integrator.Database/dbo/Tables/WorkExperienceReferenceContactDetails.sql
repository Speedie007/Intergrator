CREATE TABLE [dbo].[WorkExperienceReferenceContactDetails] (
    [WorkExperienceReferenceContactDetailID]   INT IDENTITY (1, 1) NOT NULL,
    [ContactDetailID]                          INT NOT NULL,
    [CurriculumVitaeWorkExperienceReferenceID] INT NOT NULL,
    CONSTRAINT [PK_WorkExperienceReferenceContactDetails] PRIMARY KEY CLUSTERED ([WorkExperienceReferenceContactDetailID] ASC),
    CONSTRAINT [FK_WorkExperienceReferenceContactDetails_ContactDetails] FOREIGN KEY ([ContactDetailID]) REFERENCES [dbo].[ContactDetails] ([ContactDetailID]),
    CONSTRAINT [FK_WorkExperienceReferenceContactDetails_CurriculumVitaeWorkExperienceReferences] FOREIGN KEY ([CurriculumVitaeWorkExperienceReferenceID]) REFERENCES [dbo].[CurriculumVitaeWorkExperienceReferences] ([CurriculumVitaeWorkExperienceReferenceID])
);


GO
CREATE NONCLUSTERED INDEX [IX_WorkExperienceReferenceContactDetails_CurriculumVitaeWorkExperienceReferenceID]
    ON [dbo].[WorkExperienceReferenceContactDetails]([CurriculumVitaeWorkExperienceReferenceID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_WorkExperienceReferenceContactDetails_ContactDetailID]
    ON [dbo].[WorkExperienceReferenceContactDetails]([ContactDetailID] ASC);


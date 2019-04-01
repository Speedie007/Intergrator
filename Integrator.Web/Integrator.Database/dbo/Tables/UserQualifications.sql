CREATE TABLE [dbo].[UserQualifications] (
    [UserQualificationID]        INT           IDENTITY (1, 1) NOT NULL,
    [IntegratorUserID]           INT           NOT NULL,
    [EductaionalInstitutionID]   INT           NOT NULL,
    [QualificationLevelID]       INT           NOT NULL,
    [QualificationTitle]         VARCHAR (175) NOT NULL,
    [YearStartedQualification]   DATE          DEFAULT (getdate()) NOT NULL,
    [YearCompletedQualification] DATE          DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_UserQualifications] PRIMARY KEY CLUSTERED ([UserQualificationID] ASC),
    CONSTRAINT [FK_UserQualifications_EductaionalInstitutions] FOREIGN KEY ([EductaionalInstitutionID]) REFERENCES [dbo].[EductaionalInstitutions] ([EductaionalInstitutionID]),
    CONSTRAINT [FK_UserQualifications_IntegratorUsers] FOREIGN KEY ([IntegratorUserID]) REFERENCES [dbo].[IntegratorUsers] ([IntegratorUserID]),
    CONSTRAINT [FK_UserQualifications_QualificationLevels] FOREIGN KEY ([QualificationLevelID]) REFERENCES [dbo].[QualificationLevels] ([QualificationLevelID])
);




GO
CREATE NONCLUSTERED INDEX [IX_UserQualifications_QualificationLevelID]
    ON [dbo].[UserQualifications]([QualificationLevelID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_UserQualifications_IntegratorUserID]
    ON [dbo].[UserQualifications]([IntegratorUserID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_UserQualifications_EductaionalInstitutionID]
    ON [dbo].[UserQualifications]([EductaionalInstitutionID] ASC);


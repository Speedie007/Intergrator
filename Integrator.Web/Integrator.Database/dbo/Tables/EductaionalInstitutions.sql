CREATE TABLE [dbo].[EductaionalInstitutions] (
    [EductaionalInstitutionID] INT           IDENTITY (1, 1) NOT NULL,
    [EductaionalInstitution]   VARCHAR (150) NULL,
    CONSTRAINT [PK_EductaionalInstitutions] PRIMARY KEY CLUSTERED ([EductaionalInstitutionID] ASC)
);


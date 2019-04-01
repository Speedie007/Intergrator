CREATE TABLE [dbo].[QualificationLevels] (
    [QualificationLevelID] INT           IDENTITY (1, 1) NOT NULL,
    [QualificationLevel]   VARCHAR (100) NULL,
    CONSTRAINT [PK_QualificationLevels] PRIMARY KEY CLUSTERED ([QualificationLevelID] ASC)
);


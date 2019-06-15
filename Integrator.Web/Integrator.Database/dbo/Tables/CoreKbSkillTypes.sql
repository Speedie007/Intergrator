CREATE TABLE [dbo].[CoreKbSkillTypes] (
    [CoreKbSkillTypeID] INT           IDENTITY (1, 1) NOT NULL,
    [CoreKBSkillType]   VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_CoreKbSkillTypes] PRIMARY KEY CLUSTERED ([CoreKbSkillTypeID] ASC)
);


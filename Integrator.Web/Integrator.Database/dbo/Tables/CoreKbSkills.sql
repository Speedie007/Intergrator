CREATE TABLE [dbo].[CoreKbSkills] (
    [CoreKbSkillID]       INT           IDENTITY (1, 1) NOT NULL,
    [CoreSkillCategoryID] INT           NOT NULL,
    [CoreSkill]           VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_CoreKbSkills] PRIMARY KEY CLUSTERED ([CoreKbSkillID] ASC),
    CONSTRAINT [FK_CoreKBSkills_CoreSkillCategories] FOREIGN KEY ([CoreSkillCategoryID]) REFERENCES [dbo].[CoreSkillCategories] ([CoreSkillCategoryID])
);


GO
CREATE NONCLUSTERED INDEX [IX_CoreKbSkills_CoreSkillCategoryID]
    ON [dbo].[CoreKbSkills]([CoreSkillCategoryID] ASC);


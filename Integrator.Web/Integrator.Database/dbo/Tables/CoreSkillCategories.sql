CREATE TABLE [dbo].[CoreSkillCategories] (
    [CoreSkillCategoryID]   INT           IDENTITY (1, 1) NOT NULL,
    [CoreKbSkillTypeID]     INT           NOT NULL,
    [CoreSkillCategoryName] VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_CoreSkillCategories] PRIMARY KEY CLUSTERED ([CoreSkillCategoryID] ASC),
    CONSTRAINT [FK_CoreSkillCategories_CoreKBSkillTypes] FOREIGN KEY ([CoreKbSkillTypeID]) REFERENCES [dbo].[CoreKbSkillTypes] ([CoreKbSkillTypeID])
);


GO
CREATE NONCLUSTERED INDEX [IX_CoreSkillCategories_CoreKbSkillTypeID]
    ON [dbo].[CoreSkillCategories]([CoreKbSkillTypeID] ASC);


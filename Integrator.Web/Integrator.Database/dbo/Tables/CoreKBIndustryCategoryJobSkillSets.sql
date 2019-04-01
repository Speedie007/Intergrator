CREATE TABLE [dbo].[CoreKBIndustryCategoryJobSkillSets] (
    [IndustryCategorySkillSetID] INT           IDENTITY (1, 1) NOT NULL,
    [IndustryCategoryJobID]      INT           NOT NULL,
    [IndustryCategorySkillSet]   VARCHAR (100) NULL,
    CONSTRAINT [PK_CoreKBIndustryCategoryJobSkillSets] PRIMARY KEY CLUSTERED ([IndustryCategorySkillSetID] ASC),
    CONSTRAINT [FK_IndustryCategorySkillSets_IndustryCategoryJobs] FOREIGN KEY ([IndustryCategoryJobID]) REFERENCES [dbo].[CoreKBIndustryCategoryJobs] ([IndustryCategoryJobID])
);


GO
CREATE NONCLUSTERED INDEX [IX_CoreKBIndustryCategoryJobSkillSets_IndustryCategoryJobID]
    ON [dbo].[CoreKBIndustryCategoryJobSkillSets]([IndustryCategoryJobID] ASC);


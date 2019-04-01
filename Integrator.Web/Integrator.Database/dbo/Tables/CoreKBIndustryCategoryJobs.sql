CREATE TABLE [dbo].[CoreKBIndustryCategoryJobs] (
    [IndustryCategoryJobID] INT          IDENTITY (1, 1) NOT NULL,
    [IndustryCategoryID]    INT          NOT NULL,
    [JobTitle]              VARCHAR (50) NULL,
    CONSTRAINT [PK_CoreKBIndustryCategoryJobs] PRIMARY KEY CLUSTERED ([IndustryCategoryJobID] ASC),
    CONSTRAINT [FK_IndustryCategoryJobs_IndustryCategories] FOREIGN KEY ([IndustryCategoryID]) REFERENCES [dbo].[CoreKBIndustryCategories] ([IndustryCategoryID])
);


GO
CREATE NONCLUSTERED INDEX [IX_CoreKBIndustryCategoryJobs_IndustryCategoryID]
    ON [dbo].[CoreKBIndustryCategoryJobs]([IndustryCategoryID] ASC);


CREATE TABLE [dbo].[CoreKbJobs] (
    [CoreKbJobID] INT           IDENTITY (1, 1) NOT NULL,
    [CoreKBJob]   VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_CoreKbJobs] PRIMARY KEY CLUSTERED ([CoreKbJobID] ASC)
);


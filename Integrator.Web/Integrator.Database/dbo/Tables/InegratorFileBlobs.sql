CREATE TABLE [dbo].[InegratorFileBlobs] (
    [FileID]   INT   NOT NULL,
    [FileBlob] IMAGE NOT NULL,
    CONSTRAINT [PK_InegratorFileBlobs] PRIMARY KEY CLUSTERED ([FileID] ASC),
    CONSTRAINT [FK_InegratorFileBlobs_IntegratorFiles] FOREIGN KEY ([FileID]) REFERENCES [dbo].[IntegratorFiles] ([FileID])
);






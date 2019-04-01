CREATE TABLE [dbo].[UserFiles] (
    [UserFileID]       INT IDENTITY (1, 1) NOT NULL,
    [FileID]           INT NOT NULL,
    [IntegratorUserID] INT NOT NULL,
    CONSTRAINT [PK_UserFiles] PRIMARY KEY CLUSTERED ([UserFileID] ASC),
    CONSTRAINT [FK_UserFiles_IntegratorFiles] FOREIGN KEY ([FileID]) REFERENCES [dbo].[IntegratorFiles] ([FileID]),
    CONSTRAINT [FK_UserFiles_Users] FOREIGN KEY ([IntegratorUserID]) REFERENCES [dbo].[IntegratorUsers] ([IntegratorUserID])
);


GO
CREATE NONCLUSTERED INDEX [IX_UserFiles_IntegratorUserID]
    ON [dbo].[UserFiles]([IntegratorUserID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_UserFiles_FileID]
    ON [dbo].[UserFiles]([FileID] ASC);


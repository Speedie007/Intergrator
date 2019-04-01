CREATE TABLE [dbo].[UserPictures] (
    [PictureID]        INT      IDENTITY (1, 1) NOT NULL,
    [IntegratorUserID] INT      NOT NULL,
    [FilesID]          INT      NOT NULL,
    [DateLastUpdated]  DATETIME NOT NULL,
    CONSTRAINT [PK_UserPictures] PRIMARY KEY CLUSTERED ([PictureID] ASC),
    CONSTRAINT [FK_UserPicture_IntegratorFiles] FOREIGN KEY ([FilesID]) REFERENCES [dbo].[IntegratorFiles] ([FileID]),
    CONSTRAINT [FK_UserPicture_Users] FOREIGN KEY ([IntegratorUserID]) REFERENCES [dbo].[IntegratorUsers] ([IntegratorUserID])
);


GO
CREATE NONCLUSTERED INDEX [IX_UserPictures_IntegratorUserID]
    ON [dbo].[UserPictures]([IntegratorUserID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_UserPictures_FilesID]
    ON [dbo].[UserPictures]([FilesID] ASC);


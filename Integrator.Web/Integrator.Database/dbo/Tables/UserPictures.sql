CREATE TABLE [dbo].[UserPictures] (
    [FileID]                  INT NOT NULL,
    [IntegratorUserID]        INT NOT NULL,
    [IsCurrentProfilePicture] BIT NOT NULL,
    CONSTRAINT [PK_UserPictures] PRIMARY KEY CLUSTERED ([FileID] ASC),
    CONSTRAINT [FK_UserPicture_Users] FOREIGN KEY ([IntegratorUserID]) REFERENCES [dbo].[IntegratorUsers] ([IntegratorUserID]),
    CONSTRAINT [FK_UserPictures_IntegratorFiles] FOREIGN KEY ([FileID]) REFERENCES [dbo].[IntegratorFiles] ([FileID]) ON DELETE CASCADE
);




GO
CREATE NONCLUSTERED INDEX [IX_UserPictures_IntegratorUserID]
    ON [dbo].[UserPictures]([IntegratorUserID] ASC);


GO



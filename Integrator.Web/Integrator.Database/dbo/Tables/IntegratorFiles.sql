CREATE TABLE [dbo].[IntegratorFiles] (
    [FileID]        INT           IDENTITY (1, 1) NOT NULL,
    [ContentType]   VARCHAR (100) NOT NULL,
    [FileName]      VARCHAR (200) NOT NULL,
    [FileExtension] VARCHAR (25)  NOT NULL,
    [FileSize]      INT           NOT NULL,
    [DateCreated]   DATETIME      NOT NULL,
    CONSTRAINT [PK_IntegratorFiles] PRIMARY KEY CLUSTERED ([FileID] ASC)
);


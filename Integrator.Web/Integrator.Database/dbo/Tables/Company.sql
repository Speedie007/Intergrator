CREATE TABLE [dbo].[Company] (
    [CompanyID]   INT            IDENTITY (1, 1) NOT NULL,
    [CompanyName] NVARCHAR (100) NULL,
    CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED ([CompanyID] ASC)
);


CREATE TABLE [dbo].[Companies] (
    [CompanyID]   INT            IDENTITY (1, 1) NOT NULL,
    [CompanyName] NVARCHAR (150) NULL,
    CONSTRAINT [PK_Companies] PRIMARY KEY CLUSTERED ([CompanyID] ASC)
);


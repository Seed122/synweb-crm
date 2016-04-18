﻿CREATE TABLE [dbo].[Note]
(
	[NoteId] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[CreationDate] DATETIME NOT NULL DEFAULT GETDATE(),
	[Text] NVARCHAR(MAX) NOT NULL,
	[Creator] NVARCHAR(256) NOT NULL,
)
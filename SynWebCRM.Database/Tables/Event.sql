﻿CREATE TABLE [dbo].[Event]
(
	[EventId] INT NOT NULL IDENTITY(1,1),
	[CreationDate] DATETIME DEFAULT GETDATE(),
	[StartDate] DATETIME NOT NULL,
	[EndDate] DATETIME NULL,
	[Name] NVARCHAR(200) NOT NULL,
	[Description] NVARCHAR(MAX) NULL,
	--[Url] NVARCHAR(500) NULL, 
    CONSTRAINT [PK_Event] PRIMARY KEY ([EventId]),
)

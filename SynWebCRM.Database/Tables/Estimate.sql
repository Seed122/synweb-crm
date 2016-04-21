﻿CREATE TABLE [dbo].[Estimate] --смета
(
	[EstimateId] INT NOT NULL PRIMARY KEY IDENTITY,
	[CreationDate] DATETIME NOT NULL DEFAULT GETDATE(),
	[Guid] UNIQUEIDENTIFIER NOT NULL UNIQUE DEFAULT NEWID(),
	[Title] NVARCHAR(200) NULL,
	[Text] NVARCHAR(MAX) NULL,
	[DealId] INT NOT NULL,
	[Discount] INT NULL,
	[HourlyRate] DECIMAL(18,2) NOT NULL DEFAULT 0,
	[Total] DECIMAL(18,2) NOT NULL,
	[Creator] NVARCHAR(256) NULL,
    CONSTRAINT [FK_Estimate_Deal] FOREIGN KEY ([DealId]) REFERENCES [Deal]([DealId]),
)

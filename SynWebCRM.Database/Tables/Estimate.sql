﻿CREATE TABLE [dbo].[Estimate] --смета
(
	[EstimateId] INT NOT NULL PRIMARY KEY IDENTITY,
	[CreationDate] DATETIME NOT NULL DEFAULT GETDATE(),
	[Guid] UNIQUEIDENTIFIER NOT NULL UNIQUE DEFAULT NEWID(),
	[CustomerId] INT NOT NULL,
	[Discount] INT NULL,
	[Total] DECIMAL(18,2) NOT NULL,
	[Creator] NVARCHAR(256) NULL,
    CONSTRAINT [FK_Estimate_Customer] FOREIGN KEY ([CustomerId]) REFERENCES [Customer]([CustomerId]),
)
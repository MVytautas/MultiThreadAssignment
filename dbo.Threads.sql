﻿CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ThreadId] INT NOT NULL, 
    [Text] NVARCHAR(MAX) NOT NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([Id])
)

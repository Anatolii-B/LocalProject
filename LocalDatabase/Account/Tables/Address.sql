CREATE TABLE [acc].[Address]
(
	[Id] INT NOT NULL IDENTITY (1,1),
	[FullAddres] NVARCHAR(512),
	[UserId] INT NOT NULL,
	CONSTRAINT [PK_Address_Id] PRIMARY KEY ([Id]),
	CONSTRAINT [FK_User_Id] FOREIGN KEY ([UserId]) REFERENCES [acc].[User]([Id])
)

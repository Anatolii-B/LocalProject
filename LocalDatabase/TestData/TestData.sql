/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT INTO [acc].[User] ([Id], [FirstName], [LastName], [Age], [Email], [Password]) VALUES (1, 'Quan', 'Chi', '22', 'qc@mail.com', 'pswd')
INSERT INTO [acc].[User] ([Id], [FirstName], [LastName], [Age], [Email], [Password]) VALUES (2, 'Kun', 'Lao', '34', 'kl@mail.com', 'pswd')
INSERT INTO [acc].[User] ([Id], [FirstName], [LastName], [Age], [Email], [Password]) VALUES (3, 'Erron', 'Black', '24', 'eb@mail.com', 'pswd')
INSERT INTO [acc].[User] ([Id], [FirstName], [LastName], [Age], [Email], [Password]) VALUES (4, 'Sub', 'Zero', '28', 'sz@mail.com', 'pswd')
INSERT INTO [acc].[User] ([Id], [FirstName], [LastName], [Age], [Email], [Password]) VALUES (5, 'Liu', 'Kang', '27', 'lk@mail.com', 'pswd')

INSERT INTO [acc].[Address] ([FullAddres], [UserId]) VALUES ('Thomas Nolan Kaszas, 5322 Otter Ln, Middleberge FL 32068', 1)
INSERT INTO [acc].[Address] ([FullAddres], [UserId]) VALUES ('Peter Lin, 74 Green St, Tunapuna, TRINIDAD AND TOBAGO', 2)
INSERT INTO [acc].[Address] ([FullAddres], [UserId]) VALUES ('Yuto Murase, 42 1 Motohakone Hakonemaci, Ashigarashimo Gun, Kanagawa 250 05, JAPAN', 3)
INSERT INTO [acc].[Address] ([FullAddres], [UserId]) VALUES ('Thomas Nolan Kaszas, 5322 Otter Ln, Middleberge FL 32068', 4)
INSERT INTO [acc].[Address] ([FullAddres], [UserId]) VALUES ('Susan Therese O''Neal, 226 E Fee Ave, Melbourne FL 32901', 5)
INSERT INTO [acc].[Address] ([FullAddres], [UserId]) VALUES ('Nicholas Desmond Simon Graham, P.O. Box 1230 Georgetown, Cayman Islands B. W. I.', 1)

﻿
DROP TABLE [UTILISATEUR]


/*
    Création Table Utilisateur
*/
CREATE TABLE [dbo].[UTILISATEUR]
(
	[ID] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [LOGIN] VARCHAR(50) NOT NULL, 
    [PASSWORD] VARCHAR(100) NOT NULL
)
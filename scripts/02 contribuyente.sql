/*
   jueves, 26 de marzo de 201521:21:51
   User: 
   Server: (local)
   Database: Incautaciones
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Contribuyente
	(
	Entida_Codigo int NOT NULL,
	Contri_Visible bit NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Contribuyente ADD CONSTRAINT
	PK_Contribuyente PRIMARY KEY CLUSTERED 
	(
	Entida_Codigo
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Contribuyente SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Incautacion ADD CONSTRAINT
	FK_Incautacion_Contribuyente FOREIGN KEY
	(
	Entida_Contribuyente
	) REFERENCES dbo.Contribuyente
	(
	Entida_Codigo
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Incautacion SET (LOCK_ESCALATION = TABLE)
GO
COMMIT

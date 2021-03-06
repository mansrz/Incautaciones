/*
   jueves, 26 de marzo de 201521:19:35
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
ALTER TABLE dbo.MovimientoInventario SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Incautacion
	(
	Empres_Codigo int NOT NULL,
	Sucurs_Codigo int NOT NULL,
	Parame_TipoIncautacionMov int NOT NULL,
	Pardet_TipoIncautacionMov int NOT NULL,
	Entida_Contribuyente int NOT NULL,
	Incautacion_Numero char(15) NOT NULL,
	Incaut_Secuncia int NOT NULL,
	Parame_Tipomovinv int NOT NULL,
	Pardet_TipoMovinv int NOT NULL,
	Movinv_Secuencia int NOT NULL,
	Incaut_Fecha date NOT NULL,
	Incaut_Responsable nvarchar(50) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Incautacion ADD CONSTRAINT
	PK_Incautacion PRIMARY KEY CLUSTERED 
	(
	Empres_Codigo,
	Sucurs_Codigo,
	Parame_TipoIncautacionMov,
	Pardet_TipoIncautacionMov,
	Entida_Contribuyente,
	Incautacion_Numero,
	Incaut_Secuncia
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Incautacion ADD CONSTRAINT
	FK_Incautacion_MovimientoInventario FOREIGN KEY
	(
	Parame_Tipomovinv,
	Pardet_TipoMovinv,
	Empres_Codigo,
	Sucurs_Codigo,
	Movinv_Secuencia
	) REFERENCES dbo.MovimientoInventario
	(
	Parame_Tipomovinv,
	Pardet_Tipomovinv,
	Empres_Bodega,
	Sucurs_Bodega,
	Movinv_Secuencia
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Incautacion SET (LOCK_ESCALATION = TABLE)
GO
COMMIT

USE [Incautaciones]
GO
/****** Object:  StoredProcedure [dbo].[proc_Incautacion]    Script Date: 04/12/2015 13:36:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



ALTER PROCEDURE [dbo].[proc_Incautacion]
(	@accion	char(2), 
	@Empres_Codigo	int=null, 
	@Sucurs_Codigo	int=null, 
	@Parame_TipoIncautacionMov	int=null, 
	@Pardet_TipoIncautacionMov	int=null, 
	@Entida_Contribuyente	int=null, 
	@Incautacion_Numero	char(15)=null, 
	@Parame_Tipomovinv	int=null, 
	@Pardet_TipoMovinv	int=null, 
	@Movinv_Secuencia int=null,
	@Incaut_Secuencia int = null,
	
	@Incaut_Fecha date=null,
	@Incaut_responsable nvarchar = null,
	@fechapago	datetime=null,
	@valorfactura	money=null,
	@fecdesde	datetime=null,
	@fechasta	datetime=null
)
as
begin
	declare @Codigopago int
	if @accion='i'
	begin
		set @Incaut_Secuencia = ISNULL((SELECT TOP 1 Incaut_Secuncia FROM Incautacion ORDER BY Incaut_secuncia DESC),0) +1
			
		INSERT INTO Incautacion
			   (Empres_Codigo
			   ,Sucurs_Codigo
			   ,Parame_TipoIncautacionMov
			   ,Pardet_TipoIncautacionMov
			   ,Entida_Contribuyente
			   ,Incautacion_Numero
			   ,Incaut_Secuncia
			   ,Parame_Tipomovinv
			   ,Pardet_TipoMovinv
			   ,Movinv_Secuencia
			   ,Incaut_Fecha
			   ,Incaut_Responsable)
		 VALUES
			   (@Empres_Codigo
			   ,@Sucurs_Codigo
			   ,@Parame_TipoIncautacionMov
			   ,@Pardet_TipoIncautacionMov
			   ,@Entida_Contribuyente
			   ,@Incautacion_Numero
			   ,@Incaut_Secuencia
			   ,@Parame_Tipomovinv
			   ,@Pardet_TipoMovinv
			   ,@Movinv_Secuencia 
			   ,@Incaut_Fecha
			   ,@Incaut_Responsable)

	end

	if @accion='m'
	begin
		update Incautacion
		set  Incaut_Secuncia=@Incaut_Secuencia
           ,Parame_Tipomovinv=Parame_Tipomovinv
           ,Pardet_TipoMovinv=Pardet_TipoMovinv
           ,Movinv_Secuencia=Movinv_Secuencia
           ,Incaut_Fecha=Incaut_Fecha
           ,Incaut_Responsable=Incaut_Responsable
    where Empres_Codigo= @Empres_Codigo and Sucurs_Codigo= @Sucurs_Codigo and Parame_TipoIncautacionMov= @Parame_TipoIncautacionMov and Pardet_TipoIncautacionMov= @Pardet_TipoIncautacionMov and Entida_Contribuyente= @Entida_Contribuyente and Incautacion_Numero= @Incautacion_Numero
	end

	
	if @accion='c'
	begin
		select Empres_Codigo
           ,Sucurs_Codigo
           ,Parame_TipoIncautacionMov
           ,Pardet_TipoIncautacionMov
           ,Entida_Contribuyente
           ,Incautacion_Numero
           ,Incaut_Secuncia
           ,Parame_Tipomovinv
           ,Pardet_TipoMovinv
           ,Movinv_Secuencia
           ,Incaut_Fecha
           ,Incaut_Responsable
    from Incaut
		where Empres_Codigo= @Empres_Codigo and Sucurs_Codigo= @Sucurs_Codigo and Parame_TipoIncautacionMov= @Parame_TipoIncautacionMov and Pardet_TipoIncautacionMov= @Pardet_TipoIncautacionMov and Entida_Contribuyente= @Entida_Contribuyente and Incautacion_Numero= @Incautacion_Numero
		return 0
	end
	if @accion='e'
	begin
		delete Incautacion
		where Empres_Codigo= @Empres_Codigo and Sucurs_Codigo= @Sucurs_Codigo and Parame_TipoIncautacionMov= @Parame_TipoIncautacionMov and Pardet_TipoIncautacionMov= @Pardet_TipoIncautacionMov and Entida_Contribuyente= @Entida_Contribuyente and Incautacion_Numero= @Incautacion_Numero
		return 0
	end
	if @accion='f'
	begin
		SELECT     dbo.Incautacion.Empres_Codigo, dbo.Incautacion.Sucurs_Codigo, dbo.Incautacion.Parame_TipoIncautacionMov, dbo.Incautacion.Pardet_TipoIncautacionMov, 
			dbo.Incautacion.Entida_Contribuyente, dbo.Incautacion.Incautacion_Numero, dbo.Incautacion.Parame_Tipomovinv, dbo.Incautacion.Pardet_TipoMovinv, 
			dbo.Incautacion.Movinv_Secuencia
		FROM         dbo.MovimientoInventario INNER JOIN
		                      dbo.Incautacion ON dbo.MovimientoInventario.Parame_Tipomovinv = dbo.Incautacion.Parame_Tipomovinv AND 
		                      dbo.MovimientoInventario.Pardet_Tipomovinv = dbo.Incautacion.Pardet_Tipomovinv AND 
		                      dbo.MovimientoInventario.Empres_Bodega = dbo.Incautacion.Empres_Codigo AND 
		                      dbo.MovimientoInventario.Sucurs_Bodega = dbo.Incautacion.Sucurs_Codigo AND 
		                      dbo.MovimientoInventario.Movinv_Secuencia = dbo.Incautacion.Movinv_Secuencia
		where dbo.Incautacion.Empres_Codigo= @Empres_Codigo 
		and coalesce(@Sucurs_Codigo, dbo.Incautacion.Sucurs_Codigo)=dbo.Incautacion.Sucurs_Codigo 
		and coalesce(@Parame_TipoIncautacionMov, dbo.Incautacion.Parame_TipoIncautacionMov)= dbo.Incautacion.Parame_TipoIncautacionMov
		and coalesce(@Pardet_TipoIncautacionMov, dbo.Incautacion.Pardet_TipoIncautacionMov)= dbo.Incautacion.Pardet_TipoIncautacionMov
		and dbo.MovimientoInventario.Movinv_Fecha between @fecdesde and @fechasta
		return 0
	end
end



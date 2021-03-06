USE [incautaciones]
GO
/****** Object:  StoredProcedure [dbo].[proc_Contribuyente]    Script Date: 04/07/2015 09:30:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO




CREATE PROCEDURE [dbo].[proc_Contribuyente]
(	@accion	char(1), 
	@Entida_Codigo	int=null, 
	@Contri_Visible	int=null,
	
	@filtro		varchar(200)=null
)
as
begin
	if @accion='i'
	begin
		insert into Contribuyente 
			(Entida_Codigo, Contri_Visible)
		values (@Entida_Codigo, @Contri_Visible)
		return 0
	end
	if @accion='m'
	begin
		update Contribuyente
			set Contri_Visible= @Contri_Visible
		where Entida_Codigo= @Entida_Codigo
		return 0
	end
	if @accion='c'
	begin
		select Entida_Codigo, Contri_Visible
			from Contribuyente
		where Entida_Codigo= @Entida_Codigo
		return 0
	end
	if @accion='e'
	begin
		delete Contribuyente
		where Entida_Codigo= @Entida_Codigo
		return 0
	end
	if @accion='f'
	begin
		SELECT     dbo.Contribuyente.Entida_Codigo, dbo.Contribuyente.Contri_Visible, dbo.vw_Persona.NombreCompleto
		FROM         dbo.Contribuyente INNER JOIN
		                      dbo.vw_Persona ON dbo.Contribuyente.Entida_Codigo = dbo.vw_Persona.Entida_Codigo
		where dbo.Contribuyente.Contri_Visible=1
		and (case when @filtro is null then 1
			when dbo.vw_Persona.NombreCompleto like '%' + @filtro + '%' then 1
			when exists (select * from dbo.EntidadIdentificacion 
				where dbo.EntidadIdentificacion.Identi_Numero like '%' + @filtro + '%' and dbo.Contribuyente.Entida_Codigo = dbo.EntidadIdentificacion.Entida_Codigo) then 1
			else 0 end)=1
		order by dbo.vw_Persona.NombreCompleto
		return 0
	end
end




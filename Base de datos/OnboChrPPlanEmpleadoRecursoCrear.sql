USE [BIOSALCTEMP]
GO

/****** Object:  StoredProcedure [dbo].[OnboChrPPlanEmpleadoRecursoCrear]    Script Date: 08/06/2023 13:57:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


Create PROCEDURE [dbo].[OnboChrPPlanEmpleadoRecursoCrear]	
	@CodigoPlan int = null,
	@CodigoEmpleado int = null,
	@CodigoRecurso int = null,
	@FechaCumplimiento datetime = NULL,
	@Estado nvarchar(1) = NULL,
	@UsuarioInserto nvarchar(10) = NULL,
	@FechaInserto datetime = NULL,
	@UsuarioModifico nvarchar(10) = NULL,
	@FechaModifico datetime = NULL

AS
BEGIN
	DECLARE @index int = null;
	
	SELECT @index = isnull(max(CodigoPlan),0) + 1  FROM OnboChrTPlanEmpleadoRecurso 
	
	INSERT INTO OnboChrTPlanEmpleadoRecurso	
	(CodigoPlan, CodigoEmpleado, CodigoRecurso, FechaCumplimiento, Estado, UsuarioInserto, FechaInserto)
	VALUES
	(@index, @CodigoEmpleado, @CodigoRecurso, @FechaCumplimiento, 'A', @UsuarioInserto, GETDATE())
END

GO



USE [BIOSALCTEMP]
GO

/****** Object:  StoredProcedure [dbo].[OnboChrPEmpleadoRecursoListar]    Script Date: 08/06/2023 13:57:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[OnboChrPEmpleadoRecursoListar]

AS
BEGIN
SELECT 
per.CodigoPlan,
per.codigoempleado, 
       oct.nombreempleado + ' ' + oct.apellidoempleado AS NombreCompleto, 
       per.codigorecurso, 
       r.NombreRecurso, 
       orr.nombreResponsable, 
       per.fechaCumplimiento
FROM OnboChrTPlanEmpleadoRecurso per
     INNER JOIN OnboChrTEmpleado oct ON per.codigoEmpleado = oct.codigoEmpleado
     INNER JOIN OnboChrTRecurso r ON per.codigorecurso = r.codigorecurso
     INNER JOIN OnboChrTResponsableRecurso orr ON r.CodigoResponsable = orr.CodigoResponsable
WHERE per.Estado = 'A'
end
GO



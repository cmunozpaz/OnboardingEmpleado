USE [BIOSALCTEMP]
GO

/****** Object:  StoredProcedure [dbo].[OnboChrPEmpleadoRecursoEliminar]    Script Date: 08/06/2023 13:53:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[OnboChrPEmpleadoRecursoEliminar]       
@CodigoPlan         INT = NULL,
@UsuarioInserto VARCHAR(25) = NULL
AS
  
        BEGIN
            UPDATE OnboChrTPlanEmpleadoRecurso
            SET    Estado = 'I',
                   UsuarioModifico = @UsuarioInserto,
                   FechaModifico = Getdate()
            WHERE  CodigoPlan = @CodigoPlan
        END
GO



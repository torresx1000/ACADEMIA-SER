use academia_ser 

CREATE PROCEDURE [dbo].[spListaAsistencia] 
AS
	SELECT AsistenciaID,TarjetaDeIngresoID,estado_asistencia, justificacion, des_justificacion
	from Asistencia



CREATE PROCEDURE [dbo].[spInsertarAsistencia] 
	(@AsistenciaID int,
	@TarjetaDeIngresoID int,
	@estado_asistencia char(1),
	@justificacion char(1),
	@des_justificacion varchar(100)
)
as
begin 

	insert into Asistencia(AsistenciaID,TarjetaDeIngresoID,estado_asistencia, justificacion, des_justificacion) values
	(@AsistenciaID, @TarjetaDeIngresoID, @estado_asistencia, @justificacion, @des_justificacion)
end

--actualizar
create  PROCEDURE [dbo].[spActualizarAsistencia] 
	(@AsistenciaID int,
	@TarjetaDeIngresoID int,
	@estado_asistencia char(1),
	@justificacion char(1),
	@des_justificacion varchar(100)
)
as
begin 
	update  Asistencia set 
	TarjetaDeIngresoID= @TarjetaDeIngresoID,
	estado_asistencia= @estado_asistencia,
	justificacion= @justificacion,
	des_justificacion= @des_justificacion
	
	where AsistenciaID = @AsistenciaID
end


CREATE PROCEDURE [dbo].[ListaBancoDePregunstas] 
AS
	SELECT BancoDePreguntasID,numero_preguntas,opcion_pregunta,descripcion_pregunta
	from BancoDePreguntas
----------------------------------------------------------------------------------------------------
--INSERTAR

CREATE PROCEDURE [dbo].[InsertarBancoDePregusntas] 
	(
	@BancoDePreguntasID int,
	@numero_preguntas int,
	@opcion_pregunta char(50),
	@descripcion_pregunta varchar(50)	
)
as
begin 

	insert into BancoDePreguntas(BancoDePreguntasID,numero_preguntas,opcion_pregunta,descripcion_pregunta) values
	(@BancoDePreguntasID,@numero_preguntas,@opcion_pregunta,@descripcion_pregunta 
)
end
--------------------------------------------------------------------------------------------------------------------
--Actualizar

create  PROCEDURE [dbo].[ActualizarBancoDePreguntas] 
	(
	@BancoDePreguntasID int,
	@numero_preguntas int,
	@opcion_pregunta char(50),
	@descripcion_pregunta varchar(50)
	)
as
begin 
	update  BancoDePreguntas set 

	numero_preguntas=@numero_preguntas,
	opcion_pregunta=@opcion_pregunta,
	descripcion_pregunta=@descripcion_pregunta
	
	where BancoDePreguntasID = @BancoDePreguntasID
end
